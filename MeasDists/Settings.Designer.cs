namespace MeasDists
{
    partial class Settings
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
            this.button1 = new System.Windows.Forms.Button();
            this.col_grid = new System.Windows.Forms.Button();
            this.col_marker = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.col_selmarker = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Ok_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set &Grid Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // col_grid
            // 
            this.col_grid.Location = new System.Drawing.Point(12, 12);
            this.col_grid.Name = "col_grid";
            this.col_grid.Size = new System.Drawing.Size(100, 100);
            this.col_grid.TabIndex = 1;
            this.col_grid.UseVisualStyleBackColor = true;
            // 
            // col_marker
            // 
            this.col_marker.Location = new System.Drawing.Point(145, 12);
            this.col_marker.Name = "col_marker";
            this.col_marker.Size = new System.Drawing.Size(100, 100);
            this.col_marker.TabIndex = 3;
            this.col_marker.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Set &Marker Color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // col_selmarker
            // 
            this.col_selmarker.Location = new System.Drawing.Point(278, 12);
            this.col_selmarker.Name = "col_selmarker";
            this.col_selmarker.Size = new System.Drawing.Size(100, 100);
            this.col_selmarker.TabIndex = 5;
            this.col_selmarker.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Set &Selected Marker Color";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ok_butt
            // 
            this.Ok_butt.Location = new System.Drawing.Point(154, 194);
            this.Ok_butt.Name = "Ok_butt";
            this.Ok_butt.Size = new System.Drawing.Size(75, 35);
            this.Ok_butt.TabIndex = 6;
            this.Ok_butt.Text = "&Ok";
            this.Ok_butt.UseVisualStyleBackColor = true;
            this.Ok_butt.Click += new System.EventHandler(this.Ok_butt_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 249);
            this.Controls.Add(this.Ok_butt);
            this.Controls.Add(this.col_selmarker);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.col_marker);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.col_grid);
            this.Controls.Add(this.button1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button col_grid;
        private System.Windows.Forms.Button col_marker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button col_selmarker;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Ok_butt;
    }
}