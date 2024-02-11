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
            this.col_grid = new System.Windows.Forms.Button();
            this.col_marker = new System.Windows.Forms.Button();
            this.col_selmarker = new System.Windows.Forms.Button();
            this.Ok_butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // col_grid
            // 
            this.col_grid.Location = new System.Drawing.Point(12, 12);
            this.col_grid.Name = "col_grid";
            this.col_grid.Size = new System.Drawing.Size(100, 100);
            this.col_grid.TabIndex = 1;
            this.col_grid.UseVisualStyleBackColor = true;
            this.col_grid.Click += new System.EventHandler(this.col_grid_Click);
            // 
            // col_marker
            // 
            this.col_marker.Location = new System.Drawing.Point(145, 12);
            this.col_marker.Name = "col_marker";
            this.col_marker.Size = new System.Drawing.Size(100, 100);
            this.col_marker.TabIndex = 3;
            this.col_marker.UseVisualStyleBackColor = true;
            this.col_marker.Click += new System.EventHandler(this.col_marker_Click);
            // 
            // col_selmarker
            // 
            this.col_selmarker.Location = new System.Drawing.Point(278, 12);
            this.col_selmarker.Name = "col_selmarker";
            this.col_selmarker.Size = new System.Drawing.Size(100, 100);
            this.col_selmarker.TabIndex = 5;
            this.col_selmarker.UseVisualStyleBackColor = true;
            this.col_selmarker.Click += new System.EventHandler(this.col_selmarker_Click);
            // 
            // Ok_butt
            // 
            this.Ok_butt.Location = new System.Drawing.Point(159, 168);
            this.Ok_butt.Name = "Ok_butt";
            this.Ok_butt.Size = new System.Drawing.Size(75, 35);
            this.Ok_butt.TabIndex = 6;
            this.Ok_butt.Text = "&Ok";
            this.Ok_butt.UseVisualStyleBackColor = true;
            this.Ok_butt.Click += new System.EventHandler(this.Ok_butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grid color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marker Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected Marker Color";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 219);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ok_butt);
            this.Controls.Add(this.col_selmarker);
            this.Controls.Add(this.col_marker);
            this.Controls.Add(this.col_grid);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button col_grid;
        private System.Windows.Forms.Button col_marker;
        private System.Windows.Forms.Button col_selmarker;
        private System.Windows.Forms.Button Ok_butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}