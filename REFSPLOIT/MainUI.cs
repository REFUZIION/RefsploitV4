using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace REFSPLOIT
{
    public partial class MainUI : Form
    {
        readonly ExploitAPI api = new ExploitAPI();
        public MainUI()
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

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CodeBox.Text = "";
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                CodeBox.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.CodeBox.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "REFSPLOIT | ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
            api.LaunchExploit(); // refsploit api
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            string script = CodeBox.Text;
            api.SendLuaScript(script); // refsploit api
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            ScriptHubList.Items.Clear();
            Functions.PopulateListBox(ScriptHubList, "./ScriptHub", "*.txt");
            Functions.PopulateListBox(ScriptHubList, "./ScriptHub", "*.lua");
            // MessageBox.Show("Successfully loaded all scripts.", "REFSPLOIT | ScriptHub", MessageBoxButtons.OK, MessageBoxIcon.Information); // Debug alert
        }

        private void ImportScriptHub_Click(object sender, EventArgs e)
        {
            if (ScriptHubList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item from the ScriptHub first!");
            }
            else
            {
                CodeBox.Text = File.ReadAllText($"./ScriptHub/{ScriptHubList.SelectedItem}");
            }
            
        }

        private void RefreshScriptHub_Click(object sender, EventArgs e)
        {
            ScriptHubList.Items.Clear();
            Functions.PopulateListBox(ScriptHubList, "./ScriptHub", "*.txt");
            Functions.PopulateListBox(ScriptHubList, "./ScriptHub", "*.lua");
            MessageBox.Show("Successfully refreshed the ScriptHub.", "REFSPLOIT | ScriptHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
