
namespace Main.Forms {
	partial class Proveedores {
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
            this.pictureBannerProveedores = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1020, 471);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Main.Properties.Resources.ButRegistrarFacturaDeCompras2;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 160);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Main.Properties.Resources.ButProveedo;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(266, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 160);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Main.Properties.Resources.ButNotaDePedido;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(520, 42);
            this.button3.Margin = new System.Windows.Forms.Padding(12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 160);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBannerProveedores
            // 
            this.pictureBannerProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBannerProveedores.Image = global::Main.Properties.Resources.ProveedoresBanner;
            this.pictureBannerProveedores.Location = new System.Drawing.Point(0, 0);
            this.pictureBannerProveedores.Name = "pictureBannerProveedores";
            this.pictureBannerProveedores.Size = new System.Drawing.Size(1020, 150);
            this.pictureBannerProveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBannerProveedores.TabIndex = 1;
            this.pictureBannerProveedores.TabStop = false;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 621);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBannerProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerProveedores)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.PictureBox pictureBannerProveedores;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}