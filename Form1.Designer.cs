namespace TestMenu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            Menulabel = new Label();
            MenupictureBox = new PictureBox();
            sidebar = new FlowLayoutPanel();
            Dashboardpanel = new Panel();
            button1 = new Button();
            MenuContainer = new FlowLayoutPanel();
            Menupanel = new Panel();
            Menubutton = new Button();
            panel8 = new Panel();
            SubMenubutton2 = new Button();
            panel7 = new Panel();
            SubMenubutton1 = new Button();
            Aboutpanel = new Panel();
            Aboutbutton = new Button();
            Settingpanel = new Panel();
            Settingbutton = new Button();
            Logoutpanel = new Panel();
            Logoutbutton = new Button();
            MenuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenupictureBox).BeginInit();
            sidebar.SuspendLayout();
            Dashboardpanel.SuspendLayout();
            MenuContainer.SuspendLayout();
            Menupanel.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            Aboutpanel.SuspendLayout();
            Settingpanel.SuspendLayout();
            Logoutpanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(Menulabel);
            panel1.Controls.Add(MenupictureBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 59);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1285, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
            // 
            // Menulabel
            // 
            Menulabel.AutoSize = true;
            Menulabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Menulabel.Location = new Point(77, 20);
            Menulabel.Name = "Menulabel";
            Menulabel.Size = new Size(59, 23);
            Menulabel.TabIndex = 1;
            Menulabel.Text = "MENU";
            // 
            // MenupictureBox
            // 
            MenupictureBox.Image = (Image)resources.GetObject("MenupictureBox.Image");
            MenupictureBox.Location = new Point(0, 0);
            MenupictureBox.Name = "MenupictureBox";
            MenupictureBox.Size = new Size(71, 59);
            MenupictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            MenupictureBox.TabIndex = 0;
            MenupictureBox.TabStop = false;
            MenupictureBox.Click += MenupictureBox_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(Dashboardpanel);
            sidebar.Controls.Add(MenuContainer);
            sidebar.Controls.Add(Aboutpanel);
            sidebar.Controls.Add(Settingpanel);
            sidebar.Controls.Add(Logoutpanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 59);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(250, 631);
            sidebar.TabIndex = 1;
            sidebar.Paint += sidebar_Paint;
            // 
            // Dashboardpanel
            // 
            Dashboardpanel.Controls.Add(button1);
            Dashboardpanel.Location = new Point(3, 3);
            Dashboardpanel.Name = "Dashboardpanel";
            Dashboardpanel.Size = new Size(247, 57);
            Dashboardpanel.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(-12, -8);
            button1.Name = "button1";
            button1.Size = new Size(268, 76);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MenuContainer
            // 
            MenuContainer.BackColor = Color.Black;
            MenuContainer.Controls.Add(Menupanel);
            MenuContainer.Controls.Add(panel8);
            MenuContainer.Controls.Add(panel7);
            MenuContainer.Location = new Point(3, 66);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Size = new Size(247, 76);
            MenuContainer.TabIndex = 7;
            MenuContainer.Paint += flowLayoutPanel2_Paint;
            // 
            // Menupanel
            // 
            Menupanel.Controls.Add(Menubutton);
            Menupanel.Location = new Point(3, 3);
            Menupanel.Name = "Menupanel";
            Menupanel.Size = new Size(241, 79);
            Menupanel.TabIndex = 8;
            // 
            // Menubutton
            // 
            Menubutton.BackColor = Color.Black;
            Menubutton.ForeColor = Color.White;
            Menubutton.Location = new Point(-11, -6);
            Menubutton.Name = "Menubutton";
            Menubutton.Size = new Size(264, 93);
            Menubutton.TabIndex = 2;
            Menubutton.Text = "Menu";
            Menubutton.UseVisualStyleBackColor = false;
            Menubutton.Click += Menubutton_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(SubMenubutton2);
            panel8.Location = new Point(3, 88);
            panel8.Name = "panel8";
            panel8.Size = new Size(247, 57);
            panel8.TabIndex = 9;
            // 
            // SubMenubutton2
            // 
            SubMenubutton2.BackColor = Color.Black;
            SubMenubutton2.ForeColor = Color.White;
            SubMenubutton2.Location = new Point(-8, -9);
            SubMenubutton2.Name = "SubMenubutton2";
            SubMenubutton2.Size = new Size(262, 75);
            SubMenubutton2.TabIndex = 2;
            SubMenubutton2.Text = "Sub Menu";
            SubMenubutton2.UseVisualStyleBackColor = false;
            SubMenubutton2.Click += SubMenubutton2_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(SubMenubutton1);
            panel7.Location = new Point(3, 151);
            panel7.Name = "panel7";
            panel7.Size = new Size(247, 57);
            panel7.TabIndex = 8;
            // 
            // SubMenubutton1
            // 
            SubMenubutton1.BackColor = Color.Black;
            SubMenubutton1.ForeColor = Color.White;
            SubMenubutton1.Location = new Point(-4, -9);
            SubMenubutton1.Name = "SubMenubutton1";
            SubMenubutton1.Size = new Size(256, 73);
            SubMenubutton1.TabIndex = 2;
            SubMenubutton1.Text = "Sub Menu";
            SubMenubutton1.UseVisualStyleBackColor = false;
            SubMenubutton1.Click += SubMenubutton1_Click;
            // 
            // Aboutpanel
            // 
            Aboutpanel.Controls.Add(Aboutbutton);
            Aboutpanel.Location = new Point(3, 148);
            Aboutpanel.Name = "Aboutpanel";
            Aboutpanel.Size = new Size(247, 57);
            Aboutpanel.TabIndex = 5;
            // 
            // Aboutbutton
            // 
            Aboutbutton.BackColor = Color.Black;
            Aboutbutton.ForeColor = Color.White;
            Aboutbutton.Location = new Point(-12, -6);
            Aboutbutton.Name = "Aboutbutton";
            Aboutbutton.Size = new Size(263, 76);
            Aboutbutton.TabIndex = 2;
            Aboutbutton.Text = "About";
            Aboutbutton.UseVisualStyleBackColor = false;
            Aboutbutton.Click += Aboutbutton_Click;
            // 
            // Settingpanel
            // 
            Settingpanel.Controls.Add(Settingbutton);
            Settingpanel.Location = new Point(3, 211);
            Settingpanel.Name = "Settingpanel";
            Settingpanel.Size = new Size(247, 49);
            Settingpanel.TabIndex = 4;
            // 
            // Settingbutton
            // 
            Settingbutton.BackColor = Color.Black;
            Settingbutton.ForeColor = Color.White;
            Settingbutton.Location = new Point(-8, -12);
            Settingbutton.Name = "Settingbutton";
            Settingbutton.Size = new Size(263, 76);
            Settingbutton.TabIndex = 2;
            Settingbutton.Text = "Settings";
            Settingbutton.UseVisualStyleBackColor = false;
            Settingbutton.Click += Settingbutton_Click;
            // 
            // Logoutpanel
            // 
            Logoutpanel.Controls.Add(Logoutbutton);
            Logoutpanel.Location = new Point(3, 266);
            Logoutpanel.Name = "Logoutpanel";
            Logoutpanel.Size = new Size(247, 57);
            Logoutpanel.TabIndex = 6;
            // 
            // Logoutbutton
            // 
            Logoutbutton.BackColor = Color.Black;
            Logoutbutton.ForeColor = Color.White;
            Logoutbutton.Location = new Point(-7, -9);
            Logoutbutton.Name = "Logoutbutton";
            Logoutbutton.Size = new Size(265, 76);
            Logoutbutton.TabIndex = 2;
            Logoutbutton.Text = "Logout";
            Logoutbutton.UseVisualStyleBackColor = false;
            // 
            // MenuTransition
            // 
            MenuTransition.Interval = 10;
            MenuTransition.Tick += MenuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 690);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "x";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenupictureBox).EndInit();
            sidebar.ResumeLayout(false);
            Dashboardpanel.ResumeLayout(false);
            MenuContainer.ResumeLayout(false);
            Menupanel.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            Aboutpanel.ResumeLayout(false);
            Settingpanel.ResumeLayout(false);
            Logoutpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Menulabel;
        private PictureBox MenupictureBox;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel sidebar;
        private Button Dashboardbutton;
        private Panel Settingpanel;
        private Button Settingbutton;
        private Panel Aboutpanel;
        private Button Aboutbutton;
        private Panel Logoutpanel;
        private Button Logoutbutton;
        private FlowLayoutPanel MenuContainer;
        private Panel Menupanel;
        private Button Menubutton;
        private Panel panel7;
        private Button SubMenubutton1;
        private Panel panel8;
        private Button SubMenubutton2;
        private Panel Dashboardpanel;
        private Button button1;
        private System.Windows.Forms.Timer MenuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}