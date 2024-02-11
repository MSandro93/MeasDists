using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MeasDists
{
    public partial class Settings : Form
    {
        main_window parent_;
        Color gridCol       = Color.Empty;
        Color markersCol    = Color.Empty;
        Color selMarkersCol = Color.Empty;
        bool set = false;

        public Settings(main_window parent, Color colGrid_, Color colMarkers_, Color colSelMarkers_)
        {
            parent_ = parent;

            gridCol         = colGrid_;
            markersCol      = colMarkers_;
            selMarkersCol   = colSelMarkers_;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = col_grid.BackColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                col_grid.BackColor = MyDialog.Color;
                gridCol = MyDialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = col_grid.BackColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                col_marker.BackColor = MyDialog.Color;
                markersCol = MyDialog.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = col_grid.BackColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                col_selmarker.BackColor = MyDialog.Color;
                selMarkersCol = MyDialog.Color;
            }
        }

        private void Ok_butt_Click(object sender, EventArgs e)
        {
            if (!set)
            {
                parent_.setColors(gridCol, markersCol, selMarkersCol);
                set = true;
            }

            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            col_grid.BackColor      = gridCol;
            col_marker.BackColor    = markersCol;
            col_selmarker.BackColor = selMarkersCol;
        }
    }
}
