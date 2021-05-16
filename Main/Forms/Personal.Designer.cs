
namespace Main.Forms {
	partial class Personal {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBannerPersonal = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(767, 150);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 471);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Main.Properties.Resources.ButCambioEmpleado;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 170);
            this.button2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 160);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Main.Properties.Resources.ButMasEmpleados;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 160);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Main.Properties.Resources.ButMenosEmpleado;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 335);
            this.button3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 160);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBannerPersonal
            // 
            this.pictureBannerPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBannerPersonal.Image = global::Main.Properties.Resources.PersonalBanner;
            this.pictureBannerPersonal.Location = new System.Drawing.Point(0, 0);
            this.pictureBannerPersonal.Name = "pictureBannerPersonal";
            this.pictureBannerPersonal.Size = new System.Drawing.Size(1020, 150);
            this.pictureBannerPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBannerPersonal.TabIndex = 2;
            this.pictureBannerPersonal.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 440);
            this.dataGridView1.TabIndex = 3;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 621);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBannerPersonal);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Personal";
            this.Text = "Models";
            this.Load += new System.EventHandler(this.Personal_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.PictureBox pictureBannerPersonal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}