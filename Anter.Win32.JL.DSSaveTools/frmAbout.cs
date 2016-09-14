using System;
using System.Windows.Forms;

namespace Anter.Win32.JL.DSSaveTools
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.Text += " " + Application.ProductVersion;
        }
    }
}
