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
    public partial class Form1 : Form
    {
        Image source_image = null;
        int sys_state = 0;
        bool grid_toggle_grid = false;

        public Form1()
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

            drawing_surface.Image.Dispose();
            drawing_surface.Image = (Image)source_image.Clone();

            apply_roation(drawing_surface.Image, rotate_scrollBar.Value / 10.0f);

            if (grid_toggle_grid)
            {
                Pen p_ = new Pen(Color.Red, 1);
                Graphics g_ = Graphics.FromImage(drawing_surface.Image);

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
                    g_.DrawLine(p_, 0, y_,  drawing_surface.Width, y_);
                }
                //
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

            Image img_tmp = source_image;
            Graphics g_ = Graphics.FromImage(img_tmp);

            apply_roation(img_tmp, rotate_scrollBar.Value / 10.0f);

            // draw grid at rotated image if toggled on.
            if (grid_toggle_grid)
            {
                Pen p_ = new Pen(Color.Red, 1);

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
                drawing_surface.Image = img_tmp;
                drawing_surface.Refresh();
            }

            else
            {
                drawing_surface.Image = img_tmp;
                drawing_surface.Refresh();
                return;
            }
            //

        }


        private void button1_Click_1(object sender, EventArgs e)
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
            g_.ResetTransform();
            g_.DrawImage(img_, 0, 0);  //"save" rotated image.
            return img_;
            //
        }



    }
}
