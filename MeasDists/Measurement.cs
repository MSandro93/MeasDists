using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasDists
{
    internal class Measurement
    {
        public PointF a_mm, b_mm;
        public Point a_px,  b_px;
        public float len_mm;
        public int len_px;
        public String name;

        public Measurement(Point p1_px_, Point p2_px_, PointF p1_mm_, PointF p2_mm_, String name_)
        {
            a_mm = p1_mm_;
            b_mm = p2_mm_;
            a_px = p1_px_;
            b_px = p2_px_;

            len_mm = Convert.ToSingle( Math.Sqrt(Math.Pow(Math.Abs(p1_mm_.X - p2_mm_.X), 2) + Math.Pow(Math.Abs(p1_mm_.Y - p2_mm_.Y), 2)) );
            len_px = Convert.ToInt32( Math.Round (Math.Sqrt(Math.Pow(Math.Abs(p1_mm_.X - p2_mm_.X), 2) + Math.Pow(Math.Abs(p1_mm_.Y - p2_mm_.Y), 2))));

            name = name_;
        }
    }

    internal class Angle_Measurement
    {
        public Point a_px, b_px, c_px;
        public float angle;
        public String name;

        public Angle_Measurement(Point p1_px_, Point p2_px_, Point p3_px_, float angle_, String name_)
        {
            a_px = p1_px_;
            b_px = p2_px_;
            c_px = p3_px_;

            angle = angle_;
            name = name_;
        }
    }
}
