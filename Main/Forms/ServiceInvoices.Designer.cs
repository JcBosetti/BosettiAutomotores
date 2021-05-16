
namespace Main.Forms {
	partial class ServiceInvoices {
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
            this.button1 = new System.Windows.Forms.Button();
            this.refreshServiceButton = new System.Windows.Forms.Button();
            this.FacturarButton = new System.Windows.Forms.Button();
            this.progressButton = new System.Windows.Forms.Button();
            this.pictureBannerService = new System.Windows.Forms.PictureBox();
            this.addServiceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerService)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Main.Properties.Resources.FlechaAtras;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(982, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // refreshServiceButton
            // 
            this.refreshServiceButton.BackgroundImage = global::Main.Properties.Resources.ButActualizar;
            this.refreshServiceButton.FlatAppearance.BorderSize = 0;
            this.refreshServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshServiceButton.Location = new System.Drawing.Point(763, 165);
            this.refreshServiceButton.Name = "refreshServiceButton";
            this.refreshServiceButton.Size = new System.Drawing.Size(230, 160);
            this.refreshServiceButton.TabIndex = 7;
            this.refreshServiceButton.UseVisualStyleBackColor = true;
            // 
            // FacturarButton
            // 
            this.FacturarButton.BackgroundImage = global::Main.Properties.Resources.ButFacturar;
            this.FacturarButton.FlatAppearance.BorderSize = 0;
            this.FacturarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FacturarButton.Location = new System.Drawing.Point(515, 165);
            this.FacturarButton.Name = "FacturarButton";
            this.FacturarButton.Size = new System.Drawing.Size(230, 160);
            this.FacturarButton.TabIndex = 6;
            this.FacturarButton.UseVisualStyleBackColor = true;
            // 
            // progressButton
            // 
            this.progressButton.BackgroundImage = global::Main.Properties.Resources.ButTrabajos;
            this.progressButton.FlatAppearance.BorderSize = 0;
            this.progressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.progressButton.Location = new System.Drawing.Point(268, 165);
            this.progressButton.Name = "progressButton";
            this.progressButton.Size = new System.Drawing.Size(230, 160);
            this.progressButton.TabIndex = 5;
            this.progressButton.UseVisualStyleBackColor = true;
            // 
            // pictureBannerService
            // 
            this.pictureBannerService.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBannerService.Image = global::Main.Properties.Resources.ServiceBanner1;
            this.pictureBannerService.Location = new System.Drawing.Point(0, 0);
            this.pictureBannerService.Name = "pictureBannerService";
            this.pictureBannerService.Size = new System.Drawing.Size(1020, 150);
            this.pictureBannerService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBannerService.TabIndex = 4;
            this.pictureBannerService.TabStop = false;
            // 
            // addServiceButton
            // 
            this.addServiceButton.BackgroundImage = global::Main.Properties.Resources.ButDiagnostico;
            this.addServiceButton.FlatAppearance.BorderSize = 0;
            this.addServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addServiceButton.Location = new System.Drawing.Point(19, 165);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(230, 160);
            this.addServiceButton.TabIndex = 3;
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServiceInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1020, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshServiceButton);
            this.Controls.Add(this.FacturarButton);
            this.Controls.Add(this.progressButton);
            this.Controls.Add(this.pictureBannerService);
            this.Controls.Add(this.addServiceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceInvoices";
            this.Text = "ServiceInvoices";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerService)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.PictureBox pictureBannerService;
        private System.Windows.Forms.Button progressButton;
        private System.Windows.Forms.Button FacturarButton;
        private System.Windows.Forms.Button refreshServiceButton;
        private System.Windows.Forms.Button button1;
    }
}