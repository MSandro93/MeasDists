using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MeasDists
{
    public partial class main_window : Form
    {
        Image source_image = null;
        int sys_state = 0;
        bool grid_toggle_grid = false;
        float ref_mm;
        float   mm_per_pixel;

        Point ref_p1;
        Point ref_p2;

        Pen p_black = new Pen(Color.Black, 1);

        public main_window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                source_image = Clipboard.GetImage();
                drawing_surface.Image = (Image)source_image.Clone();

                sys_state = 1;
                toggle_grid_butt.Enabled = true;
            }

            else
            {
                MessageBox.Show("No image found in clipboard");
                sys_state = 0;
                toggle_grid_butt.Enabled = false;
            }
        }

        //TODO: maybe fix the grid to be more homogeneous. Not sure about this so far..
        private void toggle_grid_butt_Click(object sender, EventArgs e)
        {
            grid_toggle_grid ^= true;

            if (drawing_surface.Image != null)
            {
                drawing_surface.Image.Dispose();
            }
            drawing_surface.Image = (Image)source_image.Clone();

            apply_roation(drawing_surface.Image, rotate_scrollBar.Value / 10.0f);

            if (grid_toggle_grid)
            {
                draw_grid(drawing_surface.Image, 10, 10);
                drawing_surface.Refresh();
            }

            else
            {
                drawing_surface.Refresh();
                return;
            }
        }

        private void rotate_scrollBar_ValueChanged(object sender, EventArgs e)
        {

            if (drawing_surface.Image != null)
            {
                drawing_surface.Image.Dispose();
            }
            drawing_surface.Image = (Image)source_image.Clone();

            

            apply_roation(drawing_surface.Image, rotate_scrollBar.Value / 10.0f);

            // draw grid at rotated image if toggled on.
            if (grid_toggle_grid)
            {
                drawing_surface.Image = draw_grid(drawing_surface.Image, 10, 10);
                drawing_surface.Refresh();
            }

            else
            {
                drawing_surface.Image = drawing_surface.Image;
                drawing_surface.Refresh();
                return;
            }
            //

        }


        private void set_ref_butt_Click(object sender, EventArgs e)
        {
            sys_state = 2;
            rotate_scrollBar.Enabled = false;

            //apply current rotaion so source iamge, thus rotation scroll bar is locked and rotation is fixed now
            source_image = apply_roation(source_image, rotate_scrollBar.Value / 10.0f);
            //



        }

        private Image apply_roation(Image img_, float angle_)
        {
            //apply current rotaion so source iamge, thus rotation scroll bar is locked and rotation is fixed now
            Graphics g_ = Graphics.FromImage(img_);
            g_.TranslateTransform(img_.Width / 2.0f, img_.Height / 2.0f); //set rotation point to center
            g_.RotateTransform((float)rotate_scrollBar.Value / 10.0f);
            g_.TranslateTransform((float)-img_.Width / 2.0f, (float)-img_.Height / 2.0f);
       //     g_.ResetTransform();
            g_.DrawImage(img_, 0, 0);  //"save" rotated image.
            return img_;
            //
        }


        private Image draw_grid(Image img_, int cnt_x, int cnt_y)
        {
            Pen p_ = new Pen(Color.Red, 1);
            Graphics g_ = Graphics.FromImage(img_);

            //draw 10 vertical grid lines
            int width_grid = (int)(drawing_surface.Width / 10.0f);
            for (int x_ = width_grid; x_ < drawing_surface.Width; x_ += width_grid)
            {
                g_.DrawLine(p_, x_, 0, x_, drawing_surface.Height);
            }
            //

            //draw 10 horizontal grid lines
            int height_grid = (int)(drawing_surface.Height / 10.0f);
            for (int y_ = height_grid; y_ < drawing_surface.Height; y_ += height_grid)
            {
                g_.DrawLine(p_, 0, y_, drawing_surface.Width, y_);
            }
            //

            g_.DrawImage(img_, 0, 0);
            return img_;
        }

        private void drawing_surface_MouseClick(object sender, MouseEventArgs e)
        {
            switch (sys_state)
            {
                case 2:
                {
                        ref_p1 = new Point(e.Location.X, e.Location.Y);
                        sys_state = 3;
                        break;
                }

                case 3:
                {
                    ref_p2 = new Point(e.Location.X, e.Location.Y);
                    sys_state = 4;


                    Inputbox ref_input_box = new Inputbox(this);
                    ref_input_box.Show();

                    break;
                }

                default:
                {
                    break;
                }
            }
        }

        private void drawing_surface_MouseMove(object sender, MouseEventArgs e)
        {
            switch (sys_state)
            {
                case 3:  //draw line from ref_p1 to mouse position
                {
                    if (drawing_surface.Image != null)
                    {
                        drawing_surface.Image.Dispose();
                    }
                    drawing_surface.Image = (Image)source_image.Clone();

                    // draw grid at rotated image if toggled on.
                    if (grid_toggle_grid)
                    {
                        drawing_surface.Image = draw_grid(drawing_surface.Image, 10, 10);
                    }
                    //

                    Graphics g_ = Graphics.FromImage(drawing_surface.Image);
                    Pen p_black = new Pen(Color.Black, 1);
                    g_.DrawLine(p_black, ref_p1, new Point(e.Location.X, e.Location.Y));
                    g_.DrawImage(drawing_surface.Image, 0, 0);
                    g_.Dispose();
                    drawing_surface.Refresh();


                    break;
                }

                default:
                {
                    break;
                }

            }
        }

        public void SetRef_mm(float f_, bool valid_)
        {
            if (valid_)
            {
                if (f_ != 0.0f)
                {
                    ref_mm = f_;
                    sys_state = 5;
                    set_ref_butt.Enabled = false;

                    double ref_len_pxl = Math.Sqrt( Math.Pow(Math.Abs( ref_p1.X - ref_p2.X ), 2) + Math.Pow(Math.Abs(ref_p1.Y - ref_p2.Y), 2));
                    mm_per_pixel = ref_mm / Convert.ToSingle(ref_len_pxl);
                }
            }
            else
            {
                sys_state = 4;
            }
        }
    }
}
