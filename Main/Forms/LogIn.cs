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
	public partial class LogIn : Form {
		public LogIn() {
			InitializeComponent();
		}

        private void LogInForm()
        {
            pictureBoxLogin.Image = Image.FromFile(@"Assets\LogIn.gif");
        }
            

        private void buttonLog_Click(object sender, EventArgs e)
        {

        }
    }
}
