
namespace Main {
	partial class Form1 {
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
            this.labelEstadisticas = new System.Windows.Forms.Label();
            this.labelPersonal = new System.Windows.Forms.Label();
            this.labelProveedores = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.labelVentas = new System.Windows.Forms.Label();
            this.TopPanel = new Utilities.GradientPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowpanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.labelID = new System.Windows.Forms.Label();
            this.panelFacturacion = new System.Windows.Forms.Panel();
            this.panelService = new System.Windows.Forms.Panel();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.panelEstadisticas = new System.Windows.Forms.Panel();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.VentasButtom = new System.Windows.Forms.PictureBox();
            this.ServiceButtom = new System.Windows.Forms.PictureBox();
            this.InventarioButtom = new System.Windows.Forms.PictureBox();
            this.proveedoresButtom = new System.Windows.Forms.PictureBox();
            this.personalButtom = new System.Windows.Forms.PictureBox();
            this.graficasButtom = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowpanelButtons.SuspendLayout();
            this.panelFacturacion.SuspendLayout();
            this.panelService.SuspendLayout();
            this.panelInventario.SuspendLayout();
            this.panelProveedores.SuspendLayout();
            this.panelPersonal.SuspendLayout();
            this.panelEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficasButtom)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEstadisticas
            // 
            this.labelEstadisticas.AutoSize = true;
            this.labelEstadisticas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEstadisticas.Location = new System.Drawing.Point(10, 57);
            this.labelEstadisticas.Name = "labelEstadisticas";
            this.labelEstadisticas.Size = new System.Drawing.Size(63, 13);
            this.labelEstadisticas.TabIndex = 10;
            this.labelEstadisticas.Text = "Estadisticas";
            // 
            // labelPersonal
            // 
            this.labelPersonal.AutoSize = true;
            this.labelPersonal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPersonal.Location = new System.Drawing.Point(17, 55);
            this.labelPersonal.Name = "labelPersonal";
            this.labelPersonal.Size = new System.Drawing.Size(48, 13);
            this.labelPersonal.TabIndex = 11;
            this.labelPersonal.Text = "Personal";
            // 
            // labelProveedores
            // 
            this.labelProveedores.AutoSize = true;
            this.labelProveedores.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProveedores.Location = new System.Drawing.Point(8, 64);
            this.labelProveedores.Name = "labelProveedores";
            this.labelProveedores.Size = new System.Drawing.Size(67, 13);
            this.labelProveedores.TabIndex = 10;
            this.labelProveedores.Text = "Proveedores";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStock.Location = new System.Drawing.Point(15, 63);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(54, 13);
            this.labelStock.TabIndex = 9;
            this.labelStock.Text = "Inventario";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.ForeColor = System.Drawing.SystemColors.Control;
            this.labelService.Location = new System.Drawing.Point(19, 62);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(43, 13);
            this.labelService.TabIndex = 8;
            this.labelService.Text = "Service";
            // 
            // labelVentas
            // 
            this.labelVentas.AutoSize = true;
            this.labelVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVentas.Location = new System.Drawing.Point(11, 63);
            this.labelVentas.Name = "labelVentas";
            this.labelVentas.Size = new System.Drawing.Size(63, 13);
            this.labelVentas.TabIndex = 0;
            this.labelVentas.Text = "Facturación";
            // 
            // TopPanel
            // 
            this.TopPanel.ColorBottom = System.Drawing.Color.Transparent;
            this.TopPanel.ColorTop = System.Drawing.Color.Transparent;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1100, 29);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.Load += new System.EventHandler(this.gradientPanel1_Load);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMain.BackgroundImage = global::Main.Properties.Resources.GenaroFondo;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(80, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1020, 621);
            this.panelMain.TabIndex = 2;
            this.panelMain.MouseEnter += new System.EventHandler(this.panelMain_MouseEnter);
            // 
            // flowpanelButtons
            // 
            this.flowpanelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.flowpanelButtons.Controls.Add(this.labelID);
            this.flowpanelButtons.Controls.Add(this.pictureBoxUser);
            this.flowpanelButtons.Controls.Add(this.panelFacturacion);
            this.flowpanelButtons.Controls.Add(this.panelService);
            this.flowpanelButtons.Controls.Add(this.panelInventario);
            this.flowpanelButtons.Controls.Add(this.panelProveedores);
            this.flowpanelButtons.Controls.Add(this.panelPersonal);
            this.flowpanelButtons.Controls.Add(this.panelEstadisticas);
            this.flowpanelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowpanelButtons.Location = new System.Drawing.Point(0, 29);
            this.flowpanelButtons.Name = "flowpanelButtons";
            this.flowpanelButtons.Size = new System.Drawing.Size(84, 621);
            this.flowpanelButtons.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.labelID.Location = new System.Drawing.Point(3, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 11;
            this.labelID.Text = "ID";
            // 
            // panelFacturacion
            // 
            this.panelFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.panelFacturacion.Controls.Add(this.VentasButtom);
            this.panelFacturacion.Controls.Add(this.labelVentas);
            this.panelFacturacion.Location = new System.Drawing.Point(3, 102);
            this.panelFacturacion.Name = "panelFacturacion";
            this.panelFacturacion.Size = new System.Drawing.Size(80, 80);
            this.panelFacturacion.TabIndex = 0;
            this.panelFacturacion.MouseEnter += new System.EventHandler(this.panelFacturacion_MouseEnter);
            // 
            // panelService
            // 
            this.panelService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.panelService.Controls.Add(this.labelService);
            this.panelService.Controls.Add(this.ServiceButtom);
            this.panelService.Location = new System.Drawing.Point(3, 188);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(80, 80);
            this.panelService.TabIndex = 12;
            this.panelService.MouseEnter += new System.EventHandler(this.panelService_MouseEnter);
            // 
            // panelInventario
            // 
            this.panelInventario.Controls.Add(this.InventarioButtom);
            this.panelInventario.Controls.Add(this.labelStock);
            this.panelInventario.Location = new System.Drawing.Point(3, 274);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(80, 80);
            this.panelInventario.TabIndex = 6;
            this.panelInventario.MouseEnter += new System.EventHandler(this.panelInventario_MouseEnter);
            // 
            // panelProveedores
            // 
            this.panelProveedores.Controls.Add(this.labelProveedores);
            this.panelProveedores.Controls.Add(this.proveedoresButtom);
            this.panelProveedores.Location = new System.Drawing.Point(3, 360);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(80, 80);
            this.panelProveedores.TabIndex = 12;
            this.panelProveedores.MouseEnter += new System.EventHandler(this.panelProveedores_MouseEnter);
            // 
            // panelPersonal
            // 
            this.panelPersonal.Controls.Add(this.labelPersonal);
            this.panelPersonal.Controls.Add(this.personalButtom);
            this.panelPersonal.Location = new System.Drawing.Point(3, 446);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(80, 80);
            this.panelPersonal.TabIndex = 11;
            this.panelPersonal.MouseEnter += new System.EventHandler(this.panelPersonal_MouseEnter);
            // 
            // panelEstadisticas
            // 
            this.panelEstadisticas.Controls.Add(this.labelEstadisticas);
            this.panelEstadisticas.Controls.Add(this.graficasButtom);
            this.panelEstadisticas.Location = new System.Drawing.Point(3, 532);
            this.panelEstadisticas.Name = "panelEstadisticas";
            this.panelEstadisticas.Size = new System.Drawing.Size(80, 80);
            this.panelEstadisticas.TabIndex = 12;
            this.panelEstadisticas.MouseEnter += new System.EventHandler(this.panelEstadisticas_MouseEnter);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackgroundImage = global::Main.Properties.Resources.Usuarios_64px;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxUser.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // VentasButtom
            // 
            this.VentasButtom.Image = global::Main.Properties.Resources.VentasTp1;
            this.VentasButtom.Location = new System.Drawing.Point(17, 7);
            this.VentasButtom.Name = "VentasButtom";
            this.VentasButtom.Size = new System.Drawing.Size(51, 54);
            this.VentasButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VentasButtom.TabIndex = 5;
            this.VentasButtom.TabStop = false;
            this.VentasButtom.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // ServiceButtom
            // 
            this.ServiceButtom.Image = global::Main.Properties.Resources.ServiceTp;
            this.ServiceButtom.Location = new System.Drawing.Point(11, 12);
            this.ServiceButtom.Name = "ServiceButtom";
            this.ServiceButtom.Size = new System.Drawing.Size(55, 54);
            this.ServiceButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ServiceButtom.TabIndex = 7;
            this.ServiceButtom.TabStop = false;
            this.ServiceButtom.Click += new System.EventHandler(this.ServiceButtom_Click);
            // 
            // InventarioButtom
            // 
            this.InventarioButtom.Image = global::Main.Properties.Resources.inventarioTp;
            this.InventarioButtom.Location = new System.Drawing.Point(15, 12);
            this.InventarioButtom.Name = "InventarioButtom";
            this.InventarioButtom.Size = new System.Drawing.Size(51, 54);
            this.InventarioButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InventarioButtom.TabIndex = 4;
            this.InventarioButtom.TabStop = false;
            this.InventarioButtom.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // proveedoresButtom
            // 
            this.proveedoresButtom.Image = global::Main.Properties.Resources.ProveedoresTp;
            this.proveedoresButtom.Location = new System.Drawing.Point(15, 12);
            this.proveedoresButtom.Name = "proveedoresButtom";
            this.proveedoresButtom.Size = new System.Drawing.Size(51, 54);
            this.proveedoresButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proveedoresButtom.TabIndex = 6;
            this.proveedoresButtom.TabStop = false;
            this.proveedoresButtom.Click += new System.EventHandler(this.proveedoresButtom_Click);
            // 
            // personalButtom
            // 
            this.personalButtom.Image = global::Main.Properties.Resources.EmpleadoTp1;
            this.personalButtom.Location = new System.Drawing.Point(16, 14);
            this.personalButtom.Name = "personalButtom";
            this.personalButtom.Size = new System.Drawing.Size(51, 54);
            this.personalButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personalButtom.TabIndex = 2;
            this.personalButtom.TabStop = false;
            // 
            // graficasButtom
            // 
            this.graficasButtom.Image = global::Main.Properties.Resources.GraficasTp;
            this.graficasButtom.Location = new System.Drawing.Point(15, 14);
            this.graficasButtom.Name = "graficasButtom";
            this.graficasButtom.Size = new System.Drawing.Size(51, 54);
            this.graficasButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.graficasButtom.TabIndex = 3;
            this.graficasButtom.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Main.Properties.Resources.exit;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1073, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 24);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.flowpanelButtons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.flowpanelButtons.ResumeLayout(false);
            this.flowpanelButtons.PerformLayout();
            this.panelFacturacion.ResumeLayout(false);
            this.panelFacturacion.PerformLayout();
            this.panelService.ResumeLayout(false);
            this.panelService.PerformLayout();
            this.panelInventario.ResumeLayout(false);
            this.panelInventario.PerformLayout();
            this.panelProveedores.ResumeLayout(false);
            this.panelProveedores.PerformLayout();
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.panelEstadisticas.ResumeLayout(false);
            this.panelEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficasButtom)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.Button button1;
        private Utilities.GradientPanel TopPanel;
        private System.Windows.Forms.PictureBox personalButtom;
        private System.Windows.Forms.PictureBox graficasButtom;
        private System.Windows.Forms.PictureBox VentasButtom;
        private System.Windows.Forms.PictureBox InventarioButtom;
        private System.Windows.Forms.PictureBox proveedoresButtom;
        private System.Windows.Forms.PictureBox ServiceButtom;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelEstadisticas;
        private System.Windows.Forms.Label labelPersonal;
        private System.Windows.Forms.Label labelProveedores;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelVentas;
        private System.Windows.Forms.FlowLayoutPanel flowpanelButtons;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panelFacturacion;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Panel panelEstadisticas;
        private System.Windows.Forms.Label labelID;
    }
}

