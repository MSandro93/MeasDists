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
using System.Windows;

namespace MeasDists
{
    public partial class main_window : Form
    {
        Image source_image = null;
        int sys_state = 0;
        bool grid_toggle_grid = false;
        float ref_mm;
        float mm_per_pixel;

        System.Drawing.Point ref_p1;
        System.Drawing.Point ref_p2;

        System.Drawing.Point current_p1;
        System.Drawing.Point current_p2;
        System.Drawing.Point current_p3;

        Pen p_black = new Pen(Color.Black, 1);
        Pen p_red = new Pen(Color.Red, 1);

        List<Measurement> measurements = new List<Measurement>();
        List<Angle_Measurement> angle_measurements = new List<Angle_Measurement>();

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

            if (sys_state < 5) //before the rotation slider is locked, the source image stays unmodified in memory. After lokcking the rotation, the source iamge is overwritten in memory. Applying the rotation again to it leads to additional rotation which shall not happen
            {
                drawing_surface.Image = apply_roation(drawing_surface.Image, rotate_scrollBar.Value / 10.0f);
            }

            if (grid_toggle_grid)
            {
                draw_grid(drawing_surface.Image, 10, 10);
            }

            draw_measuremnts("");
            drawing_surface.Refresh();
        }

        private void rotate_scrollBar_ValueChanged(object sender, EventArgs e)
        {

            if (drawing_surface.Image != null)
            {
                drawing_surface.Image.Dispose();
            }
            drawing_surface.Image = (Image)source_image.Clone();



            drawing_surface.Image = apply_roation(drawing_surface.Image, rotate_scrollBar.Value / 10.0f);

            // draw grid at rotated image if toggled on.
            if (grid_toggle_grid)
            {
                drawing_surface.Image = draw_grid(drawing_surface.Image, 10, 10);
            }
            //

            //draw_measuremnts()  // not needed here, because rotating only allowed before setting reference or markers.
            drawing_surface.Refresh();
        }


        private void set_ref_butt_Click(object sender, EventArgs e)
        {
            sys_state = 2;
            rotate_scrollBar.Enabled = false;

            //apply current rotation to source iamge, thus rotation scroll bar is locked and rotation is fixed now
            source_image = apply_roation(source_image, rotate_scrollBar.Value / 10.0f);
            //
        }

        private Image apply_roation(Image img_, float angle_)
        {
            //apply current rotaion so source iamge, thus rotation scroll bar is locked and rotation is fixed now
            Graphics g_ = Graphics.FromImage(img_);
            g_.TranslateTransform(img_.Width / 2.0f, img_.Height / 2.0f); //set rotation System.Drawing.Point to center
            g_.RotateTransform((float)rotate_scrollBar.Value / 10.0f);
            g_.TranslateTransform((float)-img_.Width / 2.0f, (float)-img_.Height / 2.0f);
            g_.DrawImage(img_, 0, 0);  //"save" rotated image.
            return img_;
            //
        }


        private Image draw_grid(Image img_, int cnt_x, int cnt_y)
        {
            Graphics g_ = Graphics.FromImage(img_);

            //draw 10 vertical grid lines
            int width_grid = (int)(drawing_surface.Width / 10.0f);
            for (int x_ = width_grid; x_ < drawing_surface.Width; x_ += width_grid)
            {
                g_.DrawLine(p_red, x_, 0, x_, drawing_surface.Height);
            }
            //

            //draw 10 horizontal grid lines
            int height_grid = (int)(drawing_surface.Height / 10.0f);
            for (int y_ = height_grid; y_ < drawing_surface.Height; y_ += height_grid)
            {
                g_.DrawLine(p_red, 0, y_, drawing_surface.Width, y_);
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
                        ref_p1 = new System.Drawing.Point(e.Location.X, e.Location.Y);
                        sys_state = 3;
                        break;
                    }

                case 3:
                    {
                        ref_p2 = new System.Drawing.Point(e.Location.X, e.Location.Y);
                        sys_state = 4;


                        Inputbox ref_input_box = new Inputbox(this);
                        ref_input_box.Show();

                        break;
                    }

                case 5:
                    {
                        current_p1 = new System.Drawing.Point(e.Location.X, e.Location.Y);
                        sys_state = 6;
                        break;
                    }

                case 6:
                    {
                        current_p2 = new System.Drawing.Point(e.Location.X, e.Location.Y);
                        sys_state = 5;

                        measurements.Add(new Measurement(current_p1,
                                                         current_p2,
                                                         new System.Drawing.PointF(current_p1.X * mm_per_pixel, current_p1.Y * mm_per_pixel),
                                                         new System.Drawing.PointF(current_p2.X * mm_per_pixel, current_p2.Y * mm_per_pixel),
                                                         "M" + measurements.Count.ToString()
                                                        )
                                         );

                        updateListBox();

                        draw_measuremnts("");
                        draw_AngleMeasurements("");
                        drawing_surface.Refresh();

                        break;
                    }

                case 100: //wait for setting center for new angle measurement
                    {
                        current_p1 = new System.Drawing.Point(e.Location.X, e.Location.Y);

                        Graphics g_ = Graphics.FromImage(drawing_surface.Image);

                        drawMarker(g_, p_black, e.Location.X, e.Location.Y, 7);

                        g_.DrawImage(drawing_surface.Image, 0, 0);

                        draw_measuremnts("");
                        draw_AngleMeasurements("");
                        drawing_surface.Refresh();

                        sys_state = 101;
                        break;
                    }

                case 101: //wait for setting Schenkel 1 of new angle measurement
                    {
                        current_p2 = new System.Drawing.Point(e.Location.X, e.Location.Y);

                        Graphics g_ = Graphics.FromImage(drawing_surface.Image);

                        drawMarker(g_, p_black, e.Location.X, e.Location.Y, 7);

                        g_.DrawImage(drawing_surface.Image, 0, 0);
                        g_.Dispose();

                        draw_measuremnts("");
                        draw_AngleMeasurements("");
                        drawing_surface.Refresh();

                        sys_state = 102;
                        break;
                    }

                case 102: //wait for setting Schenkel 2 of new angle measurement
                    {
                        current_p3 = new System.Drawing.Point(e.Location.X, e.Location.Y);

                        Graphics g_ = Graphics.FromImage(drawing_surface.Image);

                        drawMarker(g_, p_black, e.Location.X, e.Location.Y, 7);

                        g_.DrawImage(drawing_surface.Image, 0, 0);
                        g_.Dispose();


                        Vector vectorP1P2 = new Vector((current_p2.X - current_p1.X), (current_p2.Y - current_p1.Y));
                        Vector vectorP1P3 = new Vector((e.Location.X - current_p1.X), (e.Location.Y - current_p1.Y));

                        //calculate angle bwtween both vectors  
                        float angle = Convert.ToSingle(Vector.AngleBetween(vectorP1P2, vectorP1P3));
                        if (angle < 0)
                        {
                            angle = 180 + (180 + angle);  //snap over
                        }
                        //

                        angle_measurements.Add(new Angle_Measurement(current_p1, current_p2, current_p3, angle, "A" + angle_measurements.Count+1.ToString()));

                        updateAngleListBox();

                        draw_measuremnts("");
                        draw_AngleMeasurements("");
                        drawing_surface.Refresh();

                        sys_state = 4;
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
                        g_.DrawLine(p_black, ref_p1, new System.Drawing.Point(e.Location.X, e.Location.Y));
                        g_.DrawImage(drawing_surface.Image, 0, 0);
                        g_.Dispose();
                        draw_measuremnts("");
                        draw_AngleMeasurements("");
                        drawing_surface.Refresh();


                        break;
                    }

                case 6:  //draw line from current_p1 to mouse position
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
                        g_.DrawLine(p_black, current_p1, new System.Drawing.Point(e.Location.X, e.Location.Y));
                        g_.DrawImage(drawing_surface.Image, 0, 0);
                        g_.Dispose();
                        draw_measuremnts("");
                        draw_AngleMeasurements("");
                        drawing_surface.Refresh();


                        break;
                    }

                case 101:
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

                        drawMarker(g_, p_black, current_p1.X, current_p1.Y, 7);

                        g_.DrawLine(p_black, current_p1, new System.Drawing.Point(e.Location.X, e.Location.Y));
                        g_.DrawImage(drawing_surface.Image, 0, 0);
                        g_.Dispose();
                        draw_measuremnts("");
                        draw_AngleMeasurements("");
                        drawing_surface.Refresh();


                        break;
                    }

                case 102:
                    {
                        Vector vectorP1P2 = new Vector((current_p2.X - current_p1.X), (current_p2.Y - current_p1.Y));
                        Vector vectorP1P3 = new Vector((e.Location.X - current_p1.X), (e.Location.Y - current_p1.Y));

                        float startAngle = Convert.ToSingle(Vector.AngleBetween(new Vector(10.0, 0.0), vectorP1P2));
                        float zwischenwinkel  = Convert.ToSingle(Vector.AngleBetween(vectorP1P2, vectorP1P3));
                        if (zwischenwinkel < 0)
                        {
                            zwischenwinkel = 180 + (180 + zwischenwinkel);  //snap over
                        }


                        //dbg1.Text = startAngle.ToString("0.0");
                        //dbg2.Text = zwischenwinkel.ToString("0.0");

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

                        drawMarker(g_, p_black, current_p1.X, current_p1.Y, 7); // draw center marker

                        g_.DrawLine(p_black, current_p1, new System.Drawing.Point(e.Location.X, e.Location.Y)); //draw line from center marker to cursor
                        g_.DrawLine(p_black, current_p1, current_p2);                                           //re-draw line from center maker to first angel marker                                                           //

                        drawMarker(g_, p_black, current_p2.X, current_p2.Y, 7); //re-draw secound marker (first angle point)

                        //draw arc to indicate angel orientation
                        int radius_circle = Convert.ToInt32(Math.Round(vectorP1P2.Length * 0.3));
                        int center_x = current_p1.X - Convert.ToInt32(Math.Round(radius_circle / 2.0f));
                        int center_y = current_p1.Y - Convert.ToInt32(Math.Round(radius_circle / 2.0f));
                        //

                        g_.DrawArc(p_black, center_x, center_y, radius_circle, radius_circle, startAngle, zwischenwinkel);

                        g_.DrawImage(drawing_surface.Image, 0, 0);
                        g_.Dispose();
                        draw_measuremnts("");
                        draw_AngleMeasurements("");
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

                    double ref_len_pxl = Math.Sqrt(Math.Pow(Math.Abs(ref_p1.X - ref_p2.X), 2) + Math.Pow(Math.Abs(ref_p1.Y - ref_p2.Y), 2));
                    mm_per_pixel = ref_mm / Convert.ToSingle(ref_len_pxl);

                    measurements.Add(new Measurement(ref_p1, ref_p2, new System.Drawing.PointF(ref_p1.X * mm_per_pixel, ref_p1.Y * mm_per_pixel), new System.Drawing.PointF(ref_p2.X * mm_per_pixel, ref_p2.Y * mm_per_pixel), "ref"));
                    updateListBox();
                    draw_measuremnts("");
                    draw_AngleMeasurements("");
                    add_measurement_butt.Enabled = true;
                    add_angle_measurement_butt.Enabled = true;
                }
            }
            else
            {
                sys_state = 4;
            }
        }

        public void updateListBox()
        {
            measurements_ListBox.Items.Clear();

            foreach (Measurement m in measurements)
            {
                measurements_ListBox.Items.Add(m.name + " | " + m.len_mm.ToString("0.000") + "mm");
            }
        }

        private void add_measurement_butt_Click(object sender, EventArgs e)
        {
            sys_state = 5;
        }

        private void draw_measuremnts(String selected)
        {
            foreach (Measurement m in measurements)
            {
                Graphics g_ = Graphics.FromImage(drawing_surface.Image);
                if (m.name == selected)
                {
                    g_.DrawLine(p_red, m.a_px, m.b_px);
                }
                else
                {
                    g_.DrawLine(p_black, m.a_px, m.b_px);
                }

                g_.DrawImage(drawing_surface.Image, 0, 0);
                g_.Dispose();
            }
            drawing_surface.Refresh();
        }

        private void measurements_ListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            char[] separators = new char[] { ' ', '|' };
            String s = measurements_ListBox.SelectedItems[0].ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries)[0];
            draw_measuremnts(s);

            remove_measurement_butt.Enabled = true;
        }


        private void remove_measurement_butt_Click(object sender, EventArgs e)
        {
            char[] separators = new char[] { ' ', '|' };
            String text_selected = measurements_ListBox.SelectedItems[0].ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries)[0];

            if (text_selected == "ref")
            {
                return;
            }

            foreach (Measurement m in measurements)
            {
                if (m.name == text_selected)
                {
                    measurements.Remove(m);
                    break;
                }
            }

            updateListBox();

            if (drawing_surface.Image != null)
            {
                drawing_surface.Image.Dispose();
            }
            drawing_surface.Image = (Image)source_image.Clone();

            if (grid_toggle_grid)
            {
                draw_grid(drawing_surface.Image, 10, 10);
            }

            draw_measuremnts("");
        }

        private void add_angle_measurement_butt_Click(object sender, EventArgs e)
        {
            sys_state = 100;
        }

        private void updateAngleListBox()
        {
            angle_measurement_ListBox.Items.Clear();

            foreach (Angle_Measurement am in angle_measurements)
            {
                angle_measurement_ListBox.Items.Add(am.name + " | " + am.angle.ToString("0.0") + "°");
            }
        }


        static void drawMarker(Graphics g__, Pen pen_, int x_, int y_, int size_)
        {
            //draw third marker (second angle point)
            g__.DrawLine(pen_, x_ - size_, y_, x_ + size_, y_);
            g__.DrawLine(pen_, x_,y_ - size_, x_, y_+ size_);
            //
        }

        static void drawMarker(Graphics g__, Pen pen_, System.Drawing.Point p_, int size_)
        {
            //draw third marker (second angle point)
            g__.DrawLine(pen_, p_.X - size_, p_.Y, p_.X + size_, p_.Y);
            g__.DrawLine(pen_, p_.X, p_.Y - size_, p_.X, p_.Y + size_);
            //
        }

        private void draw_AngleMeasurements(String selcted_)
        {
            Graphics g_ = Graphics.FromImage(drawing_surface.Image);
            Pen p_;

            foreach (Angle_Measurement am in angle_measurements)
            {
                if (am.name == selcted_)
                {
                    p_ = p_red;
                }
                else
                {
                    p_ = p_black;
                }

                drawMarker(g_, p_, am.a_px, 7); //draw center marker
                drawMarker(g_, p_, am.b_px, 7); //draw first angle  marker
                drawMarker(g_, p_, am.c_px, 7); //draw second angle  marker

                //draw arc for indicating angle direction
                Vector v1 = new Vector((am.b_px.X - am.a_px.X), (am.b_px.Y - am.a_px.Y));
                float startAngle = Convert.ToSingle(Vector.AngleBetween(new Vector(10.0, 0.0), v1));
                int radius_circle = Convert.ToInt32(Math.Round(v1.Length * 0.3));
                int center_x = am.a_px.X - Convert.ToInt32(Math.Round(radius_circle / 2.0f));
                int center_y = am.a_px.Y - Convert.ToInt32(Math.Round(radius_circle / 2.0f));

                g_.DrawArc(p_, center_x, center_y, radius_circle, radius_circle, startAngle, am.angle);
                //

                //draw lines
                g_.DrawLine(p_black, am.a_px.X, am.a_px.Y, am.b_px.X, am.b_px.Y); //re-draw line from center marker to cursor
                g_.DrawLine(p_black, am.a_px.X, am.a_px.Y, am.c_px.X, am.c_px.Y); //re-draw line from center maker to first angel marker                                                           //

                //
            }
        }
    }
}
