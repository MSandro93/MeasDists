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
            this.remove_angle_measurement_butt = new System.Windows.Forms.Button();
            this.rot_label = new System.Windows.Forms.Label();
            this.color_settings_butt = new System.Windows.Forms.Button();
            this.controls_groupbox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawing_surface)).BeginInit();
            this.controls_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawing_surface
            // 
            this.drawing_surface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawing_surface.Cursor = System.Windows.Forms.Cursors.Arrow;
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
            this.load_butt.Location = new System.Drawing.Point(6, 11);
            this.load_butt.Name = "load_butt";
            this.load_butt.Size = new System.Drawing.Size(141, 23);
            this.load_butt.TabIndex = 1;
            this.load_butt.Text = "&Load from clipbaord";
            this.load_butt.UseVisualStyleBackColor = true;
            this.load_butt.Click += new System.EventHandler(this.load_butt_Click);
            // 
            // toggle_grid_butt
            // 
            this.toggle_grid_butt.Enabled = false;
            this.toggle_grid_butt.Location = new System.Drawing.Point(6, 49);
            this.toggle_grid_butt.Name = "toggle_grid_butt";
            this.toggle_grid_butt.Size = new System.Drawing.Size(141, 23);
            this.toggle_grid_butt.TabIndex = 2;
            this.toggle_grid_butt.Text = "&Toggle Grid";
            this.toggle_grid_butt.UseVisualStyleBackColor = true;
            this.toggle_grid_butt.Click += new System.EventHandler(this.toggle_grid_butt_Click);
            // 
            // rotate_scrollBar
            // 
            this.rotate_scrollBar.Enabled = false;
            this.rotate_scrollBar.LargeChange = 5;
            this.rotate_scrollBar.Location = new System.Drawing.Point(6, 104);
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
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "adjust rotation";
            // 
            // set_ref_butt
            // 
            this.set_ref_butt.Enabled = false;
            this.set_ref_butt.Location = new System.Drawing.Point(6, 148);
            this.set_ref_butt.Name = "set_ref_butt";
            this.set_ref_butt.Size = new System.Drawing.Size(141, 23);
            this.set_ref_butt.TabIndex = 5;
            this.set_ref_butt.Text = "&Set reference";
            this.set_ref_butt.UseVisualStyleBackColor = true;
            this.set_ref_butt.Click += new System.EventHandler(this.set_ref_butt_Click);
            // 
            // measurements_ListBox
            // 
            this.measurements_ListBox.Enabled = false;
            this.measurements_ListBox.FormattingEnabled = true;
            this.measurements_ListBox.Location = new System.Drawing.Point(6, 236);
            this.measurements_ListBox.Name = "measurements_ListBox";
            this.measurements_ListBox.Size = new System.Drawing.Size(141, 82);
            this.measurements_ListBox.TabIndex = 6;
            this.measurements_ListBox.SelectedValueChanged += new System.EventHandler(this.measurements_ListBox_SelectedValueChanged);
            // 
            // add_measurement_butt
            // 
            this.add_measurement_butt.Enabled = false;
            this.add_measurement_butt.Location = new System.Drawing.Point(6, 324);
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
            this.remove_measurement_butt.Location = new System.Drawing.Point(6, 359);
            this.remove_measurement_butt.Name = "remove_measurement_butt";
            this.remove_measurement_butt.Size = new System.Drawing.Size(141, 29);
            this.remove_measurement_butt.TabIndex = 8;
            this.remove_measurement_butt.Text = "&Remove measurement";
            this.remove_measurement_butt.UseVisualStyleBackColor = true;
            this.remove_measurement_butt.Click += new System.EventHandler(this.remove_measurement_butt_Click);
            // 
            // angle_measurement_ListBox
            // 
            this.angle_measurement_ListBox.Enabled = false;
            this.angle_measurement_ListBox.FormattingEnabled = true;
            this.angle_measurement_ListBox.Location = new System.Drawing.Point(6, 463);
            this.angle_measurement_ListBox.Name = "angle_measurement_ListBox";
            this.angle_measurement_ListBox.Size = new System.Drawing.Size(141, 82);
            this.angle_measurement_ListBox.TabIndex = 9;
            this.angle_measurement_ListBox.SelectedValueChanged += new System.EventHandler(this.angle_measurement_ListBox_SelectedValueChanged);
            // 
            // add_angle_measurement_butt
            // 
            this.add_angle_measurement_butt.Enabled = false;
            this.add_angle_measurement_butt.Location = new System.Drawing.Point(6, 551);
            this.add_angle_measurement_butt.Name = "add_angle_measurement_butt";
            this.add_angle_measurement_butt.Size = new System.Drawing.Size(141, 29);
            this.add_angle_measurement_butt.TabIndex = 10;
            this.add_angle_measurement_butt.Text = "Add An&gle measurement";
            this.add_angle_measurement_butt.UseVisualStyleBackColor = true;
            this.add_angle_measurement_butt.Click += new System.EventHandler(this.add_angle_measurement_butt_Click);
            // 
            // remove_angle_measurement_butt
            // 
            this.remove_angle_measurement_butt.Enabled = false;
            this.remove_angle_measurement_butt.Location = new System.Drawing.Point(6, 586);
            this.remove_angle_measurement_butt.Name = "remove_angle_measurement_butt";
            this.remove_angle_measurement_butt.Size = new System.Drawing.Size(141, 35);
            this.remove_angle_measurement_butt.TabIndex = 14;
            this.remove_angle_measurement_butt.Text = "&Remove angle measurement";
            this.remove_angle_measurement_butt.UseVisualStyleBackColor = true;
            this.remove_angle_measurement_butt.Click += new System.EventHandler(this.remove_angle_measurement_butt_Click);
            // 
            // rot_label
            // 
            this.rot_label.AutoSize = true;
            this.rot_label.Enabled = false;
            this.rot_label.Location = new System.Drawing.Point(130, 91);
            this.rot_label.Name = "rot_label";
            this.rot_label.Size = new System.Drawing.Size(17, 13);
            this.rot_label.TabIndex = 15;
            this.rot_label.Text = "0°";
            // 
            // color_settings_butt
            // 
            this.color_settings_butt.Location = new System.Drawing.Point(854, 593);
            this.color_settings_butt.Name = "color_settings_butt";
            this.color_settings_butt.Size = new System.Drawing.Size(98, 35);
            this.color_settings_butt.TabIndex = 16;
            this.color_settings_butt.Text = "&Color Settings";
            this.color_settings_butt.UseVisualStyleBackColor = true;
            this.color_settings_butt.Click += new System.EventHandler(this.color_settings_butt_Click);
            // 
            // controls_groupbox
            // 
            this.controls_groupbox.Controls.Add(this.load_butt);
            this.controls_groupbox.Controls.Add(this.toggle_grid_butt);
            this.controls_groupbox.Controls.Add(this.rot_label);
            this.controls_groupbox.Controls.Add(this.rotate_scrollBar);
            this.controls_groupbox.Controls.Add(this.remove_angle_measurement_butt);
            this.controls_groupbox.Controls.Add(this.label1);
            this.controls_groupbox.Controls.Add(this.add_angle_measurement_butt);
            this.controls_groupbox.Controls.Add(this.set_ref_butt);
            this.controls_groupbox.Controls.Add(this.angle_measurement_ListBox);
            this.controls_groupbox.Controls.Add(this.measurements_ListBox);
            this.controls_groupbox.Controls.Add(this.remove_measurement_butt);
            this.controls_groupbox.Controls.Add(this.add_measurement_butt);
            this.controls_groupbox.Location = new System.Drawing.Point(968, 7);
            this.controls_groupbox.Name = "controls_groupbox";
            this.controls_groupbox.Size = new System.Drawing.Size(153, 630);
            this.controls_groupbox.TabIndex = 17;
            this.controls_groupbox.TabStop = false;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 641);
            this.Controls.Add(this.controls_groupbox);
            this.Controls.Add(this.color_settings_butt);
            this.Controls.Add(this.drawing_surface);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1150, 680);
            this.Name = "main_window";
            this.Text = "MeasDists";
            this.Load += new System.EventHandler(this.main_window_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_window_KeyDown);
            this.Resize += new System.EventHandler(this.main_window_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.drawing_surface)).EndInit();
            this.controls_groupbox.ResumeLayout(false);
            this.controls_groupbox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button remove_angle_measurement_butt;
        private System.Windows.Forms.Label rot_label;
        private System.Windows.Forms.Button color_settings_butt;
        private System.Windows.Forms.GroupBox controls_groupbox;
    }
}

