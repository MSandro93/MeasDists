namespace MeasDists
{
    partial class Inputbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ref_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter value for reference measurement in mm:";
            // 
            // ref_textBox
            // 
            this.ref_textBox.Location = new System.Drawing.Point(241, 20);
            this.ref_textBox.Name = "ref_textBox";
            this.ref_textBox.Size = new System.Drawing.Size(87, 20);
            this.ref_textBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inputbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 94);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ref_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Inputbox";
            this.Text = "Reference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ref_textBox;
        private System.Windows.Forms.Button button1;
    }
}