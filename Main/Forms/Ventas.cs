using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Forms {
	public partial class Ventas : Form {
		public Ventas() {
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VendorsForm()
        {
            pictureBannerVentas.Image = Image.FromFile(@"Assets\Facturación Banner.gif");
        }
    }
    
}
