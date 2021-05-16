
namespace Main.Forms
{
    partial class Stock
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBannerStock = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerStock)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1020, 471);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Main.Properties.Resources.ButInventarioVer;
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
            this.button1.BackgroundImage = global::Main.Properties.Resources.ButGestionarInsumos;
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
            this.button3.BackgroundImage = global::Main.Properties.Resources.ButGestionInventario;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(520, 42);
            this.button3.Margin = new System.Windows.Forms.Padding(12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 160);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Main.Properties.Resources.ButGestorAlerta;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(774, 42);
            this.button4.Margin = new System.Windows.Forms.Padding(12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 160);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBannerStock
            // 
            this.pictureBannerStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBannerStock.Image = global::Main.Properties.Resources.Stock_Banner;
            this.pictureBannerStock.Location = new System.Drawing.Point(0, 0);
            this.pictureBannerStock.Name = "pictureBannerStock";
            this.pictureBannerStock.Size = new System.Drawing.Size(1020, 150);
            this.pictureBannerStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBannerStock.TabIndex = 0;
            this.pictureBannerStock.TabStop = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 621);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBannerStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBannerStock;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}