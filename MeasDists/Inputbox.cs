using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeasDists
{
    public partial class Inputbox : Form
    {
        public main_window parent_;

        public Inputbox(main_window parent)
        {
            parent_ = parent;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ref_val = 0.0f;

            try
            {
                String text_s = ref_textBox.Text;
                text_s = text_s.Replace('.', ',');
                ref_val = Convert.ToSingle(text_s);
            }
            catch
            {
                MessageBox.Show(this, "This is no float... Try again...", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ref_textBox.Text = "";
                return;
            }

            if (ref_val == 0.0f)
            {
                MessageBox.Show(this, "This is no float... Try again...", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ref_textBox.Text = "";
                return;
            }

            parent_.SetRef_mm(ref_val, true);
            this.Close();
        }

        private void Inputbox_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent_.SetRef_mm(0.0f, false);
        }
    }
}
