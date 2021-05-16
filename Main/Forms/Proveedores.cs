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
	public partial class Proveedores : Form {
		public Proveedores() {
			InitializeComponent();
		}
        private void Proveedores_Load(object sender, EventArgs e)
        {
            pictureBannerProveedores.Image = Image.FromFile(@"Assets\ProveedoresBanner.gif");
        }
    }
}
