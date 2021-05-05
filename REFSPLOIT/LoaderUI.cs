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
    public partial class LoaderUI : Form
    {
        public LoaderUI()
        {
            InitializeComponent();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void CheckingData_Tick(object sender, EventArgs e)
        {
            CheckingData.Stop();
            await Task.Delay(1500);
            label1.Text = ("Checking for data.. OK!");
            await Task.Delay(500);
            WebClient updatecheck = new WebClient();
            label1.Text = ("Checking for update..");
            panel3.Width = 150;
            await Task.Delay(1500);
            if (!updatecheck.DownloadString("http://u533473.gluweb.nl/141/122/ver/dir/rs/update/UpdateCheck.txt").Contains("4.0"))
            {
                // false
                label1.Text = ("Checking for update.. ERROR!");
                MessageBox.Show("You do not have the correct version of REFSPLOIT installed. Would you like to join our discord server?", "REFSPLOIT | ERROR");
                Functions.DiscordInvite();
                await Task.Delay(1500);
                Application.Exit();
            }
            else
            {
                // true
                label1.Text = ("Checking for update.. OK!");
                await Task.Delay(500);
                label1.Text = ("Checking for patch..");
                panel3.Width = 260;
                await Task.Delay(1500);
                WebClient patchcheck = new WebClient();
                if (!patchcheck.DownloadString("http://u533473.gluweb.nl/141/122/ver/dir/rs/patch/PatchCheck.txt").Contains("NotPatched"))
                {
                    label1.Text = ("Checking for patch.. ERROR!");
                    MessageBox.Show("The current version of REFSPLOIT is patched. Would you like to join our discord server for more information?", "REFSPLOIT | ERROR");
                    Functions.DiscordInvite();
                    await Task.Delay(1500);
                    Application.Exit();
                }
                else
                {
                    label1.Text = ("Checking for patch.. OK!");
                    await Task.Delay(500);
                    label1.Text = ("Loading REFSPLOIT..");
                    panel3.Width = 310;
                    await Task.Delay(2000);
                    panel3.Width = 375;
                    label1.Text = ("Loading REFSPLOIT.. SUCCESS!");
                    await Task.Delay(750);
                    this.Hide();
                    MainUI mainui = new MainUI();
                    mainui.Show();
                }
            }
        }
    }
}
