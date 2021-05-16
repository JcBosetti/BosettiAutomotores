
namespace Main.Forms {
	partial class Ventas {
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBannerVentas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1020, 471);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Main.Properties.Resources.ButFactura;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 160);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Main.Properties.Resources.ButPresupuesto;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(266, 42);
            this.button3.Margin = new System.Windows.Forms.Padding(12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 160);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Main.Properties.Resources.ButHistorial;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(520, 42);
            this.button4.Margin = new System.Windows.Forms.Padding(12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 160);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Main.Properties.Resources.ButClientes;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(774, 42);
            this.button5.Margin = new System.Windows.Forms.Padding(12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 160);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBannerVentas
            // 
            this.pictureBannerVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBannerVentas.Image = global::Main.Properties.Resources.Facturación_Banner;
            this.pictureBannerVentas.Location = new System.Drawing.Point(0, 0);
            this.pictureBannerVentas.Name = "pictureBannerVentas";
            this.pictureBannerVentas.Size = new System.Drawing.Size(1020, 150);
            this.pictureBannerVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBannerVentas.TabIndex = 2;
            this.pictureBannerVentas.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Main.Properties.Resources.FlechaAtras;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(983, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 621);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBannerVentas);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Vendors";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerVentas)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBannerVentas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}