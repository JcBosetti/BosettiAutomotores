
namespace Main.Forms {
	partial class addServices {
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.nameClientLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.addClientbutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.surnameClientLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DNIClientLabel = new System.Windows.Forms.Label();
            this.AddClientPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CarLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.añoLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.kmLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tipoTabajoLabel = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.printbutton = new System.Windows.Forms.Button();
            this.mecanicoLabel = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Repuestoslabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.addTableButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.AddClientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 25);
            this.topPanel.TabIndex = 0;
            // 
            // addServiceButton
            // 
            this.addServiceButton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.addServiceButton.FlatAppearance.BorderSize = 0;
            this.addServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addServiceButton.Location = new System.Drawing.Point(340, 408);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(146, 39);
            this.addServiceButton.TabIndex = 1;
            this.addServiceButton.Text = "Nuevo Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Location = new System.Drawing.Point(644, 408);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(146, 39);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // nameClientLabel
            // 
            this.nameClientLabel.AutoSize = true;
            this.nameClientLabel.Location = new System.Drawing.Point(12, 27);
            this.nameClientLabel.Name = "nameClientLabel";
            this.nameClientLabel.Size = new System.Drawing.Size(102, 13);
            this.nameClientLabel.TabIndex = 4;
            this.nameClientLabel.Text = "Nombre del Cliente: ";
            this.nameClientLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 5;
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.BuscarButton.FlatAppearance.BorderSize = 0;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BuscarButton.Location = new System.Drawing.Point(642, 1);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(146, 39);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // addClientbutton
            // 
            this.addClientbutton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.addClientbutton.FlatAppearance.BorderSize = 0;
            this.addClientbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.addClientbutton.Location = new System.Drawing.Point(642, 38);
            this.addClientbutton.Name = "addClientbutton";
            this.addClientbutton.Size = new System.Drawing.Size(146, 39);
            this.addClientbutton.TabIndex = 7;
            this.addClientbutton.Text = "Nuevo Cliente";
            this.addClientbutton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 9;
            // 
            // surnameClientLabel
            // 
            this.surnameClientLabel.AutoSize = true;
            this.surnameClientLabel.Location = new System.Drawing.Point(192, 27);
            this.surnameClientLabel.Name = "surnameClientLabel";
            this.surnameClientLabel.Size = new System.Drawing.Size(102, 13);
            this.surnameClientLabel.TabIndex = 8;
            this.surnameClientLabel.Text = "Apellido del Cliente: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(375, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 11;
            // 
            // DNIClientLabel
            // 
            this.DNIClientLabel.AutoSize = true;
            this.DNIClientLabel.Location = new System.Drawing.Point(372, 27);
            this.DNIClientLabel.Name = "DNIClientLabel";
            this.DNIClientLabel.Size = new System.Drawing.Size(84, 13);
            this.DNIClientLabel.TabIndex = 10;
            this.DNIClientLabel.Text = "DNI del Cliente: ";
            // 
            // AddClientPanel
            // 
            this.AddClientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddClientPanel.Controls.Add(this.BuscarButton);
            this.AddClientPanel.Controls.Add(this.textBox3);
            this.AddClientPanel.Controls.Add(this.nameClientLabel);
            this.AddClientPanel.Controls.Add(this.DNIClientLabel);
            this.AddClientPanel.Controls.Add(this.textBox1);
            this.AddClientPanel.Controls.Add(this.textBox2);
            this.AddClientPanel.Controls.Add(this.addClientbutton);
            this.AddClientPanel.Controls.Add(this.surnameClientLabel);
            this.AddClientPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddClientPanel.Location = new System.Drawing.Point(0, 25);
            this.AddClientPanel.Name = "AddClientPanel";
            this.AddClientPanel.Size = new System.Drawing.Size(800, 81);
            this.AddClientPanel.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // CarLabel
            // 
            this.CarLabel.AutoSize = true;
            this.CarLabel.Location = new System.Drawing.Point(13, 126);
            this.CarLabel.Name = "CarLabel";
            this.CarLabel.Size = new System.Drawing.Size(45, 13);
            this.CarLabel.TabIndex = 14;
            this.CarLabel.Text = "Modelo:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(193, 126);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 13);
            this.versionLabel.TabIndex = 16;
            this.versionLabel.Text = "Versión:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(196, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // añoLabel
            // 
            this.añoLabel.AutoSize = true;
            this.añoLabel.Location = new System.Drawing.Point(374, 126);
            this.añoLabel.Name = "añoLabel";
            this.añoLabel.Size = new System.Drawing.Size(29, 13);
            this.añoLabel.TabIndex = 18;
            this.añoLabel.Text = "Año:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(377, 142);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 21);
            this.comboBox3.TabIndex = 17;
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Location = new System.Drawing.Point(557, 127);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(64, 13);
            this.kmLabel.TabIndex = 19;
            this.kmLabel.Text = "Kilometraje: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(560, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 20;
            // 
            // tipoTabajoLabel
            // 
            this.tipoTabajoLabel.AutoSize = true;
            this.tipoTabajoLabel.Location = new System.Drawing.Point(13, 187);
            this.tipoTabajoLabel.Name = "tipoTabajoLabel";
            this.tipoTabajoLabel.Size = new System.Drawing.Size(85, 13);
            this.tipoTabajoLabel.TabIndex = 22;
            this.tipoTabajoLabel.Text = "Tipo de Trabajo:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(16, 203);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(140, 21);
            this.comboBox4.TabIndex = 21;
            // 
            // printbutton
            // 
            this.printbutton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.printbutton.FlatAppearance.BorderSize = 0;
            this.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.printbutton.Location = new System.Drawing.Point(10, 408);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(146, 39);
            this.printbutton.TabIndex = 23;
            this.printbutton.Text = "Imprimir Presupuesto";
            this.printbutton.UseVisualStyleBackColor = true;
            // 
            // mecanicoLabel
            // 
            this.mecanicoLabel.AutoSize = true;
            this.mecanicoLabel.Location = new System.Drawing.Point(193, 187);
            this.mecanicoLabel.Name = "mecanicoLabel";
            this.mecanicoLabel.Size = new System.Drawing.Size(104, 13);
            this.mecanicoLabel.TabIndex = 25;
            this.mecanicoLabel.Text = "Mecanico Asignado:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(196, 203);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(140, 21);
            this.comboBox5.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(16, 350);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(772, 20);
            this.textBox5.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Descripcion de falla:";
            // 
            // Repuestoslabel
            // 
            this.Repuestoslabel.AutoSize = true;
            this.Repuestoslabel.Location = new System.Drawing.Point(13, 243);
            this.Repuestoslabel.Name = "Repuestoslabel";
            this.Repuestoslabel.Size = new System.Drawing.Size(111, 13);
            this.Repuestoslabel.TabIndex = 28;
            this.Repuestoslabel.Text = "Insumos y Repuestos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.PrecioUnitario,
            this.Cantidad,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(16, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 69);
            this.dataGridView1.TabIndex = 29;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Main.Properties.Resources.TrashCan_24px;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(565, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addTableButton
            // 
            this.addTableButton.BackgroundImage = global::Main.Properties.Resources.Create_24px;
            this.addTableButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addTableButton.FlatAppearance.BorderSize = 0;
            this.addTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTableButton.Location = new System.Drawing.Point(565, 264);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(25, 24);
            this.addTableButton.TabIndex = 30;
            this.addTableButton.UseVisualStyleBackColor = true;
            this.addTableButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(492, 408);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(146, 39);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Limpiar Datos";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // addServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addTableButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Repuestoslabel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mecanicoLabel);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.tipoTabajoLabel);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.kmLabel);
            this.Controls.Add(this.añoLabel);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CarLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddClientPanel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.AddClientPanel.ResumeLayout(false);
            this.AddClientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label nameClientLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button addClientbutton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label surnameClientLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label DNIClientLabel;
        private System.Windows.Forms.Panel AddClientPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label CarLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label añoLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label tipoTabajoLabel;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Label mecanicoLabel;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Repuestoslabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.Button button1;
    }
}