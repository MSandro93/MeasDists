namespace MeasDists
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.drawing_surface = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.load_butt = new System.Windows.Forms.Button();
            this.toggle_grid_butt = new System.Windows.Forms.Button();
            this.rotate_scrollBar = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawing_surface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawing_surface
            // 
            this.drawing_surface.Location = new System.Drawing.Point(12, 12);
            this.drawing_surface.Name = "drawing_surface";
            this.drawing_surface.Size = new System.Drawing.Size(940, 560);
            this.drawing_surface.TabIndex = 0;
            this.drawing_surface.TabStop = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(977, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Set reference";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotate_scrollBar);
            this.Controls.Add(this.toggle_grid_butt);
            this.Controls.Add(this.load_butt);
            this.Controls.Add(this.drawing_surface);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawing_surface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawing_surface;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button load_butt;
        private System.Windows.Forms.Button toggle_grid_butt;
        private System.Windows.Forms.HScrollBar rotate_scrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

