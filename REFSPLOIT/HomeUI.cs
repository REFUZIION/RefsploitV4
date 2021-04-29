using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REFSPLOIT
{
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DiscordBtn_Click(object sender, EventArgs e)
        {
            Functions.DiscordInvite();
        }

        private void LaunchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaderUI loaderui = new LoaderUI();
            loaderui.Show();
        }
    }
}
