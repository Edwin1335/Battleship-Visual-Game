using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApplication
{
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
        }

        private void GitHubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Edwin1335");
        }

        private void LinkedInButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/edwin-campuzano-4a6889121/");
        }

        private void InstagramButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/edwinrebollar/");
        }
    }
}
