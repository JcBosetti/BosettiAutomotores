using Main.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main {
    public partial class Form1 : Form {
        public Form1() 
        {  
            InitializeComponent();  
        }
        private void AbrirPanel(object formhijo, Panel panelSelected)
        {
            if(this.panelMain.Controls.Count == 1)
            {
                this.panelMain.Controls.Clear();
            }

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(fh);
            this.panelMain.Tag = fh;
            fh.Show();
            panelInventario.BackColor = Color.FromArgb(46, 63, 82);
            panelFacturacion.BackColor = Color.FromArgb(46, 63, 82);
            panelPersonal.BackColor = Color.FromArgb(46, 63, 82);
            panelProveedores.BackColor = Color.FromArgb(46, 63, 82);
            panelEstadisticas.BackColor = Color.FromArgb(46, 63, 82);
            panelService.BackColor = Color.FromArgb(46, 63, 82);
            panelSelected.BackColor = Color.FromArgb(80, 114, 157);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gradientPanel1_Load(object sender, EventArgs e)
        {
            labelID.Text = "10";
            authority();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {   
            AbrirPanel(new Stock(), panelInventario);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Ventas(),panelFacturacion);
        }

        private void ServiceButtom_Click(object sender, EventArgs e)
        {
            AbrirPanel(new ServiceInvoices(), panelService);
        }

        private void panelService_MouseEnter(object sender, EventArgs e)
        {
            panelColor(panelService);
        }
        private void panelFacturacion_MouseEnter(object sender, EventArgs e)
        {
            panelColor(panelFacturacion);
        }

        //Funcion Dinamica de los botones

        private void panelInventario_MouseEnter(object sender, EventArgs e)
        {
            panelColor(panelInventario);
        }

        private void panelProveedores_MouseEnter(object sender, EventArgs e)
        {
            panelColor(panelProveedores);
        }

        private void panelPersonal_MouseEnter(object sender, EventArgs e)
        {
            panelColor(panelPersonal);
        }
        private void panelEstadisticas_MouseEnter(object sender, EventArgs e)
        {
            panelColor(panelEstadisticas);
        }
        private void panelColor(Panel panelSelect)
        {
            if(this.panelMain.Controls.Count == 0)
            {
                panelInventario.BackColor = Color.FromArgb(46, 63, 82);
                panelFacturacion.BackColor = Color.FromArgb(46, 63, 82);
                panelPersonal.BackColor = Color.FromArgb(46, 63, 82);
                panelProveedores.BackColor = Color.FromArgb(46, 63, 82);
                panelEstadisticas.BackColor = Color.FromArgb(46, 63, 82);
                panelService.BackColor = Color.FromArgb(46, 63, 82);
                if (panelMain != panelSelect)
                {
                    panelSelect.BackColor = Color.FromArgb(55, 68, 88);
                }
            }

            if (panelInventario.BackColor != Color.FromArgb(80, 114, 157))
            {
                 panelInventario.BackColor = Color.FromArgb(46, 63, 82);
            }
            if (panelFacturacion.BackColor != Color.FromArgb(80, 114, 157))
            {
                panelFacturacion.BackColor = Color.FromArgb(46, 63, 82);
            }
            if (panelPersonal.BackColor != Color.FromArgb(80, 114, 157))
            {
                panelPersonal.BackColor = Color.FromArgb(46, 63, 82);
            }
            if (panelProveedores.BackColor != Color.FromArgb(80, 114, 157))
            {
                panelProveedores.BackColor = Color.FromArgb(46, 63, 82);
            }
            if (panelEstadisticas.BackColor != Color.FromArgb(80, 114, 157))
            {
                panelEstadisticas.BackColor = Color.FromArgb(46, 63, 82);
            }
            if (panelService.BackColor != Color.FromArgb(80, 114, 157))
            {
                panelService.BackColor = Color.FromArgb(46, 63, 82);
            }
            if (panelSelect.BackColor == Color.FromArgb(46, 63, 82))
            {
                panelSelect.BackColor = Color.FromArgb(55, 68, 88);
            }
            

        }

        private void panelMain_MouseEnter(object sender, EventArgs e)
        {
            panelColor(panelMain);
        }

        private void authority()
        {
            panelFacturacion.Visible = false;
            panelEstadisticas.Visible = false;
            panelProveedores.Visible = false;
            panelPersonal.Visible = false;
            panelService.Visible = false;
            panelInventario.Visible = false;
            //-------------- Configuracion de visual de autoridad -----------------//

            if (labelID.Text.Equals("0"))
            {
                // -------------- Auxiliares y Mecanicos ---------------------//
                panelInventario.Visible = true;
            }
            if (labelID.Text.Equals("1"))
            {
                //------------------- Inventarios -----------------------------//
                panelInventario.Visible = true;
            }
            if (labelID.Text.Equals("2"))
            {
                // -------------------- Ventas ---------------------------//
                panelInventario.Visible = true;
                panelFacturacion.Visible = true;
            }
            if (labelID.Text.Equals("3"))
            {
                // -------------------- Compras -----------------------//
                panelInventario.Visible = true;
                panelProveedores.Visible = true;
            }
            if (labelID.Text.Equals("4"))
            {
                // ------------------ Service -----------------------//
                panelInventario.Visible = true;
                panelService.Visible = true;

            }
            if (labelID.Text.Equals("5"))
            {
                // -------------- Gerente Ventas -----------------//
                panelInventario.Visible = true;
                panelFacturacion.Visible = true;
                panelEstadisticas.Visible = true;

            }
            if (labelID.Text.Equals("6"))
            {
                // -------------- Gerente Compras ---------------//
                panelInventario.Visible = true;
                panelProveedores.Visible = true;
                panelEstadisticas.Visible = true;
            }
            if (labelID.Text.Equals("7"))
            {
                // -------------- Gerente Services ------------//
                panelInventario.Visible = true;
                panelService.Visible = true;
                panelEstadisticas.Visible = true;
            }
            if (labelID.Text.Equals("8"))
            {
                // ------------- Gerente General ------------//
                panelInventario.Visible = true;
                panelProveedores.Visible = true;
                panelEstadisticas.Visible = true;
                panelService.Visible = true;
                panelFacturacion.Visible = true;
                panelPersonal.Visible = false;
            }
            if (labelID.Text.Equals("10"))
            {
                // ------------ Diosito y Programadores ----//
                panelInventario.Visible = true;
                panelProveedores.Visible = true;
                panelEstadisticas.Visible = true;
                panelService.Visible = true;
                panelFacturacion.Visible = true;
                panelPersonal.Visible = true;

            }
        }

        private void proveedoresButtom_Click(object sender, EventArgs e)
        {
            
        }
    }
}
