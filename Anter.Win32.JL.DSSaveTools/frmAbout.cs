using System;
using System.Windows.Forms;

namespace DSSaveTools
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.Text = "kmod " + this.Text + " " + Application.ProductVersion;
        }
    }
}
