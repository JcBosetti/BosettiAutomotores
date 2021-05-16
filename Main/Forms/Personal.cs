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
	public partial class Personal : Form {
		public Personal() {
			InitializeComponent();
		}

        private void Personal_Load(object sender, EventArgs e)
        {
            pictureBannerPersonal.Image = Image.FromFile(@"Assets\PersonalBanner.gif");
        }
    }
}
