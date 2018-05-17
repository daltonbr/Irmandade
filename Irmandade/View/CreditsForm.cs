using System;
using System.Windows.Forms;

namespace Irmandade.View
{
    public partial class CreditsForm : Form
    {
        public CreditsForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to source code URL.
            System.Diagnostics.Process.Start("http://www.github.com/daltonbr/Irmandade");
        }

         private void CreditsForm_Load(object sender, EventArgs e)
        {
            versionLabel.Text = Resources.strings.version;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://rc.unesp.br");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://igce.rc.unesp.br/#!/unidade-auxiliar/ceapla/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://igce.rc.unesp.br/");
        }
    }
}
