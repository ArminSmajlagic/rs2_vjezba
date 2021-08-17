using Services.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient
{
    public partial class StartupForm : Form
    {
        private readonly AuthPrimitive _auth;
        MainClientDisplay display;

        public StartupForm(AuthPrimitive auth)
        {
            InitializeComponent();
            _auth = auth;
        }

        private void letmein_Click(object sender, EventArgs e)
        {

            try {

                display = new MainClientDisplay(_auth.ValidateCreds(tbUser.Text)); 

            }
            catch(ExceptionHandelingFilter err) {
                
                display = new MainClientDisplay(err.Message);
            }

            display.ShowDialog();
        }
    }
}
