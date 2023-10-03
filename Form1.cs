using System.Security.Cryptography;

namespace TestMenu
{
    public partial class Form1 : Form
    {
        FormDashboard dashboard;
        FormAbout about;
        FormLogout logout;
        FormSettings settings;
        FormSub1 sub1;
        FormSub2 sub2;
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        bool menuExpand = false;
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                MenuContainer.Height += 10;
                if (MenuContainer.Height >= 193)
                {
                    MenuTransition.Stop();
                    menuExpand = true;

                }
            }
            else
            {
                MenuContainer.Height -= 10;
                if (MenuContainer.Height <= 76)
                {
                    MenuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Menubutton_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }

        private void Settingbutton_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 71)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    Dashboardpanel.Width = sidebar.Width;
                    Aboutpanel.Width = sidebar.Width;
                    Settingpanel.Width = sidebar.Width;
                    MenuContainer.Width = sidebar.Width;
                    Logoutpanel.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 250)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    Dashboardpanel.Width = sidebar.Width;
                    Aboutpanel.Width = sidebar.Width;
                    Settingpanel.Width = sidebar.Width;
                    MenuContainer.Width = sidebar.Width;
                    Logoutpanel.Width = sidebar.Width;
                }
            }
        }

        private void MenupictureBox_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Aboutbutton_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new FormDashboard();
                dashboard.FormClosed += DashBoard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();

            }
            else
            {
                dashboard.Activate();
            }
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void SubMenubutton2_Click(object sender, EventArgs e)
        {
            if (sub2 == null)
            {
                sub2 = new FormSub2();
                sub2.FormClosed += Sub2_FormClosed;
                sub2.MdiParent = this;
                sub2.Dock = DockStyle.Fill;
                sub2.Show();
            }
            else
            {
                sub2.Activate();
            }
        }

        private void Sub2_FormClosed(object? sender, FormClosedEventArgs e)
        {
            sub2 = null;
        }

        private void SubMenubutton1_Click(object sender, EventArgs e)
        {
            if (sub1 == null)
            {
                sub1 = new FormSub1();
                sub1.FormClosed += Sub1_FormClosed;
                sub1.MdiParent = this;
                sub1.Dock = DockStyle.Fill;
                sub1.Show();
            }
            else
            {
                sub1.Activate();
            }
        }

        private void Sub1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            sub1 = null;
        }
    }
}