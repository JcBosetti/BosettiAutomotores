
namespace Main.Forms {
	partial class Estadisticas {
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
            this.pictureBannerEstadisticas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBannerEstadisticas
            // 
            this.pictureBannerEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBannerEstadisticas.Image = global::Main.Properties.Resources.EstadisticasBanner;
            this.pictureBannerEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.pictureBannerEstadisticas.Name = "pictureBannerEstadisticas";
            this.pictureBannerEstadisticas.Size = new System.Drawing.Size(1050, 150);
            this.pictureBannerEstadisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBannerEstadisticas.TabIndex = 2;
            this.pictureBannerEstadisticas.TabStop = false;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 621);
            this.Controls.Add(this.pictureBannerEstadisticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseInvoices";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerEstadisticas)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.PictureBox pictureBannerEstadisticas;
    }
}