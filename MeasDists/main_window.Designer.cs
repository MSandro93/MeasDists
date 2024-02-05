namespace MeasDists
{
    partial class main_window
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawing_surface = new System.Windows.Forms.PictureBox();
            this.load_butt = new System.Windows.Forms.Button();
            this.toggle_grid_butt = new System.Windows.Forms.Button();
            this.rotate_scrollBar = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.set_ref_butt = new System.Windows.Forms.Button();
            this.measurements_ListBox = new System.Windows.Forms.ListBox();
            this.add_measurement_butt = new System.Windows.Forms.Button();
            this.remove_measurement_butt = new System.Windows.Forms.Button();
            this.angle_measurement_ListBox = new System.Windows.Forms.ListBox();
            this.add_angle_measurement_butt = new System.Windows.Forms.Button();
            this.dbg1 = new System.Windows.Forms.Label();
            this.dbg2 = new System.Windows.Forms.Label();
            this.dbg3 = new System.Windows.Forms.Label();
            this.remove_angle_measurement_butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawing_surface)).BeginInit();
            this.SuspendLayout();
            // 
            // drawing_surface
            // 
            this.drawing_surface.Cursor = System.Windows.Forms.Cursors.Cross;
            this.drawing_surface.Location = new System.Drawing.Point(12, 12);
            this.drawing_surface.Name = "drawing_surface";
            this.drawing_surface.Size = new System.Drawing.Size(940, 560);
            this.drawing_surface.TabIndex = 0;
            this.drawing_surface.TabStop = false;
            this.drawing_surface.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawing_surface_MouseClick);
            this.drawing_surface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawing_surface_MouseMove);
            // 
            // load_butt
            // 
            this.load_butt.Location = new System.Drawing.Point(977, 12);
            this.load_butt.Name = "load_butt";
            this.load_butt.Size = new System.Drawing.Size(141, 23);
            this.load_butt.TabIndex = 1;
            this.load_butt.Text = "&Load from clipbaord";
            this.load_butt.UseVisualStyleBackColor = true;
            this.load_butt.Click += new System.EventHandler(this.button1_Click);
            // 
            // toggle_grid_butt
            // 
            this.toggle_grid_butt.Enabled = false;
            this.toggle_grid_butt.Location = new System.Drawing.Point(977, 50);
            this.toggle_grid_butt.Name = "toggle_grid_butt";
            this.toggle_grid_butt.Size = new System.Drawing.Size(141, 23);
            this.toggle_grid_butt.TabIndex = 2;
            this.toggle_grid_butt.Text = "&Toggle Grid";
            this.toggle_grid_butt.UseVisualStyleBackColor = true;
            this.toggle_grid_butt.Click += new System.EventHandler(this.toggle_grid_butt_Click);
            // 
            // rotate_scrollBar
            // 
            this.rotate_scrollBar.LargeChange = 5;
            this.rotate_scrollBar.Location = new System.Drawing.Point(977, 105);
            this.rotate_scrollBar.Maximum = 200;
            this.rotate_scrollBar.Minimum = -200;
            this.rotate_scrollBar.Name = "rotate_scrollBar";
            this.rotate_scrollBar.Size = new System.Drawing.Size(144, 17);
            this.rotate_scrollBar.TabIndex = 3;
            this.rotate_scrollBar.TabStop = true;
            this.rotate_scrollBar.ValueChanged += new System.EventHandler(this.rotate_scrollBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(974, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "adjust rotation";
            // 
            // set_ref_butt
            // 
            this.set_ref_butt.Location = new System.Drawing.Point(977, 149);
            this.set_ref_butt.Name = "set_ref_butt";
            this.set_ref_butt.Size = new System.Drawing.Size(141, 23);
            this.set_ref_butt.TabIndex = 5;
            this.set_ref_butt.Text = "&Set reference";
            this.set_ref_butt.UseVisualStyleBackColor = true;
            this.set_ref_butt.Click += new System.EventHandler(this.set_ref_butt_Click);
            // 
            // measurements_ListBox
            // 
            this.measurements_ListBox.FormattingEnabled = true;
            this.measurements_ListBox.Location = new System.Drawing.Point(977, 237);
            this.measurements_ListBox.Name = "measurements_ListBox";
            this.measurements_ListBox.Size = new System.Drawing.Size(141, 82);
            this.measurements_ListBox.TabIndex = 6;
            this.measurements_ListBox.SelectedValueChanged += new System.EventHandler(this.measurements_ListBox_SelectedValueChanged);
            // 
            // add_measurement_butt
            // 
            this.add_measurement_butt.Enabled = false;
            this.add_measurement_butt.Location = new System.Drawing.Point(977, 325);
            this.add_measurement_butt.Name = "add_measurement_butt";
            this.add_measurement_butt.Size = new System.Drawing.Size(141, 29);
            this.add_measurement_butt.TabIndex = 7;
            this.add_measurement_butt.Text = "&Add measurement";
            this.add_measurement_butt.UseVisualStyleBackColor = true;
            this.add_measurement_butt.Click += new System.EventHandler(this.add_measurement_butt_Click);
            // 
            // remove_measurement_butt
            // 
            this.remove_measurement_butt.Enabled = false;
            this.remove_measurement_butt.Location = new System.Drawing.Point(977, 360);
            this.remove_measurement_butt.Name = "remove_measurement_butt";
            this.remove_measurement_butt.Size = new System.Drawing.Size(141, 29);
            this.remove_measurement_butt.TabIndex = 8;
            this.remove_measurement_butt.Text = "&Remove measurement";
            this.remove_measurement_butt.UseVisualStyleBackColor = true;
            this.remove_measurement_butt.Click += new System.EventHandler(this.remove_measurement_butt_Click);
            // 
            // angle_measurement_ListBox
            // 
            this.angle_measurement_ListBox.FormattingEnabled = true;
            this.angle_measurement_ListBox.Location = new System.Drawing.Point(977, 464);
            this.angle_measurement_ListBox.Name = "angle_measurement_ListBox";
            this.angle_measurement_ListBox.Size = new System.Drawing.Size(141, 82);
            this.angle_measurement_ListBox.TabIndex = 9;
            this.angle_measurement_ListBox.SelectedValueChanged += new System.EventHandler(this.angle_measurement_ListBox_SelectedValueChanged);
            // 
            // add_angle_measurement_butt
            // 
            this.add_angle_measurement_butt.Enabled = false;
            this.add_angle_measurement_butt.Location = new System.Drawing.Point(977, 552);
            this.add_angle_measurement_butt.Name = "add_angle_measurement_butt";
            this.add_angle_measurement_butt.Size = new System.Drawing.Size(141, 29);
            this.add_angle_measurement_butt.TabIndex = 10;
            this.add_angle_measurement_butt.Text = "Add An&gle measurement";
            this.add_angle_measurement_butt.UseVisualStyleBackColor = true;
            this.add_angle_measurement_butt.Click += new System.EventHandler(this.add_angle_measurement_butt_Click);
            // 
            // dbg1
            // 
            this.dbg1.AutoSize = true;
            this.dbg1.Location = new System.Drawing.Point(12, 609);
            this.dbg1.Name = "dbg1";
            this.dbg1.Size = new System.Drawing.Size(31, 13);
            this.dbg1.TabIndex = 11;
            this.dbg1.Text = "dbg1";
            // 
            // dbg2
            // 
            this.dbg2.AutoSize = true;
            this.dbg2.Location = new System.Drawing.Point(83, 609);
            this.dbg2.Name = "dbg2";
            this.dbg2.Size = new System.Drawing.Size(31, 13);
            this.dbg2.TabIndex = 12;
            this.dbg2.Text = "dbg2";
            // 
            // dbg3
            // 
            this.dbg3.AutoSize = true;
            this.dbg3.Location = new System.Drawing.Point(141, 609);
            this.dbg3.Name = "dbg3";
            this.dbg3.Size = new System.Drawing.Size(31, 13);
            this.dbg3.TabIndex = 13;
            this.dbg3.Text = "dbg3";
            // 
            // remove_angle_measurement_butt
            // 
            this.remove_angle_measurement_butt.Enabled = false;
            this.remove_angle_measurement_butt.Location = new System.Drawing.Point(977, 587);
            this.remove_angle_measurement_butt.Name = "remove_angle_measurement_butt";
            this.remove_angle_measurement_butt.Size = new System.Drawing.Size(141, 35);
            this.remove_angle_measurement_butt.TabIndex = 14;
            this.remove_angle_measurement_butt.Text = "&Remove angle measurement";
            this.remove_angle_measurement_butt.UseVisualStyleBackColor = true;
            this.remove_angle_measurement_butt.Click += new System.EventHandler(this.remove_angle_measurement_butt_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 647);
            this.Controls.Add(this.remove_angle_measurement_butt);
            this.Controls.Add(this.dbg3);
            this.Controls.Add(this.dbg2);
            this.Controls.Add(this.dbg1);
            this.Controls.Add(this.add_angle_measurement_butt);
            this.Controls.Add(this.angle_measurement_ListBox);
            this.Controls.Add(this.remove_measurement_butt);
            this.Controls.Add(this.add_measurement_butt);
            this.Controls.Add(this.measurements_ListBox);
            this.Controls.Add(this.set_ref_butt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotate_scrollBar);
            this.Controls.Add(this.toggle_grid_butt);
            this.Controls.Add(this.load_butt);
            this.Controls.Add(this.drawing_surface);
            this.KeyPreview = true;
            this.Name = "main_window";
            this.Text = "MeasDists";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_window_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.drawing_surface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawing_surface;
        private System.Windows.Forms.Button load_butt;
        private System.Windows.Forms.Button toggle_grid_butt;
        private System.Windows.Forms.HScrollBar rotate_scrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button set_ref_butt;
        private System.Windows.Forms.ListBox measurements_ListBox;
        private System.Windows.Forms.Button add_measurement_butt;
        private System.Windows.Forms.Button remove_measurement_butt;
        private System.Windows.Forms.ListBox angle_measurement_ListBox;
        private System.Windows.Forms.Button add_angle_measurement_butt;
        private System.Windows.Forms.Label dbg1;
        private System.Windows.Forms.Label dbg2;
        private System.Windows.Forms.Label dbg3;
        private System.Windows.Forms.Button remove_angle_measurement_butt;
    }
}

