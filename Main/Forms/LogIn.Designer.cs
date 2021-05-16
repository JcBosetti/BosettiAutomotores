
namespace Main.Forms {
	partial class LogIn {
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
            this.panelLatLogin = new System.Windows.Forms.Panel();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubTitle = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.labelImgTitle = new System.Windows.Forms.Label();
            this.labelPicSubTitle = new System.Windows.Forms.Label();
            this.panelLatLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLatLogin
            // 
            this.panelLatLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.panelLatLogin.Controls.Add(this.buttonLog);
            this.panelLatLogin.Controls.Add(this.labelPass);
            this.panelLatLogin.Controls.Add(this.labelUser);
            this.panelLatLogin.Controls.Add(this.pictureBoxPass);
            this.panelLatLogin.Controls.Add(this.pictureBoxUser);
            this.panelLatLogin.Controls.Add(this.labelTitle);
            this.panelLatLogin.Controls.Add(this.labelSubTitle);
            this.panelLatLogin.Controls.Add(this.textBoxPass);
            this.panelLatLogin.Controls.Add(this.textBoxUser);
            this.panelLatLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLatLogin.Location = new System.Drawing.Point(473, 0);
            this.panelLatLogin.Name = "panelLatLogin";
            this.panelLatLogin.Size = new System.Drawing.Size(327, 450);
            this.panelLatLogin.TabIndex = 0;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(64, 165);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(216, 22);
            this.textBoxUser.TabIndex = 0;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(64, 225);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(216, 22);
            this.textBoxPass.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
            this.labelTitle.Location = new System.Drawing.Point(105, 49);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(129, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Bienvenido";
            // 
            // labelSubTitle
            // 
            this.labelSubTitle.AutoSize = true;
            this.labelSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
            this.labelSubTitle.Location = new System.Drawing.Point(111, 68);
            this.labelSubTitle.Name = "labelSubTitle";
            this.labelSubTitle.Size = new System.Drawing.Size(115, 15);
            this.labelSubTitle.TabIndex = 3;
            this.labelSubTitle.Text = "Ingresa a tu usuario";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
            this.labelUser.Location = new System.Drawing.Point(36, 147);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(56, 15);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "Usuario: ";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
            this.labelPass.Location = new System.Drawing.Point(36, 207);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(73, 15);
            this.labelPass.TabIndex = 7;
            this.labelPass.Text = "Contraseña:";
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogin.Image = global::Main.Properties.Resources.LogIn;
            this.pictureBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(473, 450);
            this.pictureBoxLogin.TabIndex = 1;
            this.pictureBoxLogin.TabStop = false;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.pictureBoxPass.Image = global::Main.Properties.Resources.passWhite;
            this.pictureBoxPass.Location = new System.Drawing.Point(39, 225);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPass.TabIndex = 5;
            this.pictureBoxPass.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.pictureBoxUser.Image = global::Main.Properties.Resources.iconUserWhite;
            this.pictureBoxUser.Location = new System.Drawing.Point(39, 165);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxUser.TabIndex = 4;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonLog
            // 
            this.buttonLog.BackgroundImage = global::Main.Properties.Resources.LogButton;
            this.buttonLog.FlatAppearance.BorderSize = 0;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
            this.buttonLog.Location = new System.Drawing.Point(39, 322);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(241, 51);
            this.buttonLog.TabIndex = 10;
            this.buttonLog.Text = "Ingresar";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // labelImgTitle
            // 
            this.labelImgTitle.AutoSize = true;
            this.labelImgTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(194)))));
            this.labelImgTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelImgTitle.Location = new System.Drawing.Point(12, 18);
            this.labelImgTitle.Name = "labelImgTitle";
            this.labelImgTitle.Size = new System.Drawing.Size(289, 25);
            this.labelImgTitle.TabIndex = 11;
            this.labelImgTitle.Text = "Bosetti Automotores S.R.L";
            // 
            // labelPicSubTitle
            // 
            this.labelPicSubTitle.AutoSize = true;
            this.labelPicSubTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(194)))));
            this.labelPicSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelPicSubTitle.Location = new System.Drawing.Point(22, 39);
            this.labelPicSubTitle.Name = "labelPicSubTitle";
            this.labelPicSubTitle.Size = new System.Drawing.Size(258, 18);
            this.labelPicSubTitle.TabIndex = 12;
            this.labelPicSubTitle.Text = "Sistema de Gestión Integral de Ventas";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelImgTitle);
            this.Controls.Add(this.labelPicSubTitle);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.panelLatLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.panelLatLogin.ResumeLayout(false);
            this.panelLatLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Panel panelLatLogin;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubTitle;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Label labelImgTitle;
        private System.Windows.Forms.Label labelPicSubTitle;
    }
}