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
        Random rnd = new Random();
        public MainUI()
        {
            InitializeComponent();
        }

        // draw tabcontrol
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            TabControl.Invalidate();
        }
        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.DrawBackground();
            using (Brush br = new SolidBrush(TabColors[TabControl.TabPages[e.Index]]))
            {
                e.Graphics.FillRectangle(br, e.Bounds);
                SizeF sz = e.Graphics.MeasureString(TabControl.TabPages[e.Index].Text, e.Font);
                e.Graphics.DrawString(TabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

                Rectangle rect = e.Bounds;
                rect.Offset(0, 1);
                rect.Inflate(0, -1);
                e.Graphics.DrawRectangle(Pens.DarkGray, rect);
                e.DrawFocusRectangle();
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

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CodeBox.Text = "";
            int rndid = rnd.Next(100, 999);
            Console.Text += Environment.NewLine + "RS | cleared lua editor [" + rndid + "]";
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
                    int rndid = rnd.Next(100, 999);
                    Console.Text += Environment.NewLine + "RS | Imported script [" + rndid + "]";
            }
            catch (Exception)
            {
                int rndid = rnd.Next(100, 999);
                Console.Text += Environment.NewLine + "RS | Failed to import file [" + rndid + "]";
                int num = (int)MessageBox.Show("An unexpected error has occured", "REFSPLOIT | ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private async void AttachBtn_Click(object sender, EventArgs e)
        {
            int rndid1 = rnd.Next(100, 999);
            int rndid2 = rnd.Next(100, 999);
            int rndid3 = rnd.Next(100, 999);
            if (!api.isAPIAttached())
            {
                Console.Text += Environment.NewLine + "RS | Attaching DLL";
                api.LaunchExploit(); // refsploit api
                await Task.Delay(250);
                Console.Text += ".";
                await Task.Delay(250);
                Console.Text += ".";
                await Task.Delay(250);
                Console.Text += ".";
                await Task.Delay(1000);
                if (!api.isAPIAttached())
                {
                    Console.Text += Environment.NewLine + "RS | Attaching failed [" + rndid1 + "]";
                }
                else
                {
                    Console.Text += Environment.NewLine + "RS | Attached successfully [" + rndid2 + "]";
                }
                   
            }
            else
            {
                Console.Text += Environment.NewLine + "RS | Already injected [" + rndid3 + "]";
            }
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            int rndid = rnd.Next(100, 999);
            Console.Text += Environment.NewLine + "RS | executing lua [" + rndid + "]";
            string script = CodeBox.Text;
            api.SendLuaScript(script); // refsploit api
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            ScriptHubList.Items.Clear();
            Functions.PopulateListBox(ScriptHubList, "./ScriptHub", "*.txt");
            Functions.PopulateListBox(ScriptHubList, "./ScriptHub", "*.lua");
            Console.Text += Environment.NewLine + "RS | ScriptHub Loaded";
        }

        private void ImportScriptHub_Click(object sender, EventArgs e)
        {
            int rndid = rnd.Next(100, 999);
            if (ScriptHubList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item from the ScriptHub first!");
                Console.Text += Environment.NewLine + "RS | No script selected [" + rndid + "]";

            }
            else
            {
                string t = File.ReadAllText($"./ScriptHub/{ScriptHubList.SelectedItem}");
                if (t == CodeBox.Text)
                {
                    int rndid1 = rnd.Next(100, 999);
                    Console.Text += Environment.NewLine + "RS | Already imported [" + rndid1 + "]";
                }
                else
                {
                    CodeBox.Text = File.ReadAllText($"./ScriptHub/{ScriptHubList.SelectedItem}");
                    Console.Text += Environment.NewLine + "RS | Script imported [" + rndid + "]";
                }
            }

        }

        private void RefreshScriptHub_Click(object sender, EventArgs e)
        {
            ScriptHubList.Items.Clear();
            Functions.PopulateListBox(ScriptHubList, "./ScriptHub", "*.txt");
            Functions.PopulateListBox(ScriptHubList, "./ScriptHub", "*.lua");
            MessageBox.Show("Successfully refreshed the ScriptHub.", "REFSPLOIT | ScriptHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int rndid = rnd.Next(100, 999);
            Console.Text += Environment.NewLine + "RS | Refreshed ScriptHub [" + rndid + "]";
        }

        // Console Executor
        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Input.Text == "cmds")
            {
                Input.Clear();
                Output.Text += Environment.NewLine + "\nff \nfire me \nbtools me \nwalkspeed [value] \njumppower [value]";
                Input.Clear();
            }
            else if (Input.Text == "ff")
            {
                Input.Clear();
                Output.Text += Environment.NewLine + "ff [ON]";
                Input.Clear();
            }
        }


        // LUA-C Executor
        private void ExecuteLuaC_Click(object sender, EventArgs e)
        {
            int rndid = rnd.Next(100, 999);
            Console.Text += Environment.NewLine + "RS | executing lua-C [" + rndid + "]";
            string luacscript = LuacCodeBox.Text;
            api.SendLuaCScript(luacscript);
        }

        private void ClearLuaC_Click(object sender, EventArgs e)
        {
            int rndid = rnd.Next(100, 999);
            LuacCodeBox.Text = "";
            Console.Text += Environment.NewLine + "RS | cleared lua-c editor [" + rndid + "]";
        }

        private void LoadFileLuaC_Click(object sender, EventArgs e)
        {
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
                        this.LuacCodeBox.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
                    int rndid = rnd.Next(100, 999);
                    Console.Text += Environment.NewLine + "RS | Imported file [" + rndid + "]";
                }
                catch (Exception)
                {
                    int num = (int)MessageBox.Show("An unexpected error has occured", "REFSPLOIT | ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int rndid = rnd.Next(100, 999);
                    Console.Text += Environment.NewLine + "RS | Failed to import file [" + rndid + "]";
                }
            }
        }

        private void Console_TextChanged(object sender, EventArgs e)
        {
            Console1.Text = Console.Text;
            Console.SelectionStart = Console.Text.Length;
            Console.ScrollToCaret();
            Console.Refresh();
        }

        private void Console1_TextChanged(object sender, EventArgs e)
        {
            Console1.SelectionStart = Console1.Text.Length;
            Console1.ScrollToCaret();
            Console1.Refresh();
        }
    }
}