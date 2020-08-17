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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
            mainPageLogoPictureBox.BackColor = Color.Transparent;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the HOME button");
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
