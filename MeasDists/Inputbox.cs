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
        bool val_transmitted = false;   //if the user closes the dialog by the 'x', no value for reference measurement is sent to main-program. Therefor a parameter is sent to main-form to signal aborting of reference measurement process. This leads to rolign back systate so the user can try again. This Abortion-signal is send by Close event of form. Unfurtantly this event is triggert, when user hits OK too. So two times a sigal is sent. The secound time, aborting is signalizes, which leads to systate 4. Not applying rotation to the already rotated stored source image only happens if systate >5.

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
            val_transmitted = true;
            this.Close();
        }

        private void Inputbox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!val_transmitted)
            {
                parent_.SetRef_mm(0.0f, false);
            }
        }

        private void ref_textBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
