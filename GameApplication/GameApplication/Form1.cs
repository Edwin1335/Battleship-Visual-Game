using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace GameApplication
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point offset;



        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program 
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the program 
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            // Bring to control to the front.
            homeControl1.BringToFront();

            // Re-position the slider panel.
            menuSideLabel.Location = new Point(113, 127);
            menuSideLabel.BringToFront();

            // Change the background color of the buttons
            homeButton.BackColor = Color.FromArgb(40, 54, 68);
            gameButton.BackColor = Color.Black;
            aboutButton.BackColor = Color.Black;
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            // Bring to control to the front.
            gameControl1.BringToFront();

            // Re-position the slider panel.
            menuSideLabel.Location = new Point(113, 205);
            menuSideLabel.BringToFront();

            // Change the background color of the buttons
            gameButton.BackColor = Color.FromArgb(40, 54, 68);
            homeButton.BackColor = Color.Black;
            aboutButton.BackColor = Color.Black;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            // Bring to control to the front.
            aboutControl1.BringToFront();

            // Re-position the slider panel.
            menuSideLabel.Location = new Point(113, 293);
            menuSideLabel.BringToFront();

            // Change the background color of the buttons
            aboutButton.BackColor = Color.FromArgb(40, 54, 68);
            homeButton.BackColor = Color.Black;
            gameButton.BackColor = Color.Black;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                Point currentScreemPos = PointToScreen(e.Location);
                Location = new Point(currentScreemPos.X - offset.X, currentScreemPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void HomeMouseHover_Event(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromArgb(242, 163, 101);
        }
        
    }
}
