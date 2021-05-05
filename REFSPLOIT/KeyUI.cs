using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REFSPLOIT
{
    public partial class KeyUI : Form
    {
        public KeyUI()
        {
            InitializeComponent();
        }

        private void GetKeyBtn_Click(object sender, EventArgs e)
        {
            Functions.GetKey();
        }

        private void DiscordBtn_Click(object sender, EventArgs e)
        {
            Functions.DiscordInvite();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            WebClient keycheck = new WebClient();
            if (!KeyTextBox.Text.Contains(keycheck.DownloadString("http://u533473.gluweb.nl/141/122/ver/dir/rs/key/keyCheck.txt")))
            {
                // false
                MessageBox.Show("You have entered an invalid access key.", "REFSPLOIT | ERROR");
            }
            else
            {
                MessageBox.Show("Enjoy your 24 hour access to REFSPLOIT v4!", "REFSPLOIT | INFO");
                this.Hide();
                LoaderUI loaderui = new LoaderUI();
                loaderui.Show();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
