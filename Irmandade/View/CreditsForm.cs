using System;
using System.Deployment.Application;
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
            //versionLabel.Text = Irmandade.Util.Versioning.AssemblyVersion.Major.ToString() + "." +
            //                    Irmandade.Util.Versioning.AssemblyVersion.Minor.ToString();
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                versionLabel.Text = Irmandade.Util.Versioning.AssemblyVersion.ToString(2);
            }
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

        private void versionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
