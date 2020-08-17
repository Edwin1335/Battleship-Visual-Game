namespace GameApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topLayerPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.gameButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.menuLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.homeControl1 = new GameApplication.HomeControl();
            this.aboutControl1 = new GameApplication.AboutControl();
            this.gameControl1 = new GameApplication.GameControl();
            this.menuSideLabel = new System.Windows.Forms.Label();
            this.topLayerPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topLayerPanel
            // 
            this.topLayerPanel.BackColor = System.Drawing.Color.Black;
            this.topLayerPanel.Controls.Add(this.button1);
            this.topLayerPanel.Controls.Add(this.panel2);
            this.topLayerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayerPanel.Location = new System.Drawing.Point(0, 0);
            this.topLayerPanel.Name = "topLayerPanel";
            this.topLayerPanel.Size = new System.Drawing.Size(800, 31);
            this.topLayerPanel.TabIndex = 0;
            this.topLayerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.topLayerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.topLayerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(769, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 31);
            this.panel2.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Black;
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.aboutButton);
            this.menuPanel.Controls.Add(this.gameButton);
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 31);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(113, 419);
            this.menuPanel.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(0, 347);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 72);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Close";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.Location = new System.Drawing.Point(0, 246);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(113, 78);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "About Me";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // gameButton
            // 
            this.gameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameButton.FlatAppearance.BorderSize = 0;
            this.gameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton.ForeColor = System.Drawing.Color.White;
            this.gameButton.Image = ((System.Drawing.Image)(resources.GetObject("gameButton.Image")));
            this.gameButton.Location = new System.Drawing.Point(0, 168);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(113, 78);
            this.gameButton.TabIndex = 6;
            this.gameButton.Text = "Game";
            this.gameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(0, 90);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(113, 78);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoPanel.Controls.Add(this.menuLogoPictureBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(113, 90);
            this.logoPanel.TabIndex = 3;
            // 
            // menuLogoPictureBox
            // 
            this.menuLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("menuLogoPictureBox.Image")));
            this.menuLogoPictureBox.Location = new System.Drawing.Point(0, 6);
            this.menuLogoPictureBox.Name = "menuLogoPictureBox";
            this.menuLogoPictureBox.Size = new System.Drawing.Size(113, 68);
            this.menuLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuLogoPictureBox.TabIndex = 0;
            this.menuLogoPictureBox.TabStop = false;
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.homeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeControl1.Location = new System.Drawing.Point(113, 31);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(687, 419);
            this.homeControl1.TabIndex = 7;
            this.homeControl1.MouseHover += new System.EventHandler(this.HomeMouseHover_Event);
            // 
            // aboutControl1
            // 
            this.aboutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutControl1.Location = new System.Drawing.Point(113, 31);
            this.aboutControl1.Name = "aboutControl1";
            this.aboutControl1.Size = new System.Drawing.Size(687, 419);
            this.aboutControl1.TabIndex = 6;
            // 
            // gameControl1
            // 
            this.gameControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameControl1.Location = new System.Drawing.Point(113, 31);
            this.gameControl1.Name = "gameControl1";
            this.gameControl1.Size = new System.Drawing.Size(687, 419);
            this.gameControl1.TabIndex = 5;
            // 
            // menuSideLabel
            // 
            this.menuSideLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuSideLabel.Location = new System.Drawing.Point(113, 127);
            this.menuSideLabel.Name = "menuSideLabel";
            this.menuSideLabel.Size = new System.Drawing.Size(5, 78);
            this.menuSideLabel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuSideLabel);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.aboutControl1);
            this.Controls.Add(this.gameControl1);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.topLayerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topLayerPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topLayerPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.PictureBox menuLogoPictureBox;
        private GameControl gameControl1;
        private AboutControl aboutControl1;
        private HomeControl homeControl1;
        private System.Windows.Forms.Label menuSideLabel;
    }
}

