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
	public partial class ServiceInvoices : Form {
		public ServiceInvoices() {
			InitializeComponent();
		}

        private void ServiceForm()
        {
            pictureBannerService.Image = Image.FromFile(@"Assets\ServiceBanner.gif");

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
