
namespace REFSPLOIT
{
    partial class MainUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.titleMainUI = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.CloseBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.HeaderDragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.TitleDragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.LuaExec = new System.Windows.Forms.TabPage();
            this.ClearBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.LoadBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.ImportScriptHub = new Siticone.UI.WinForms.SiticoneButton();
            this.ScriptHubBG = new System.Windows.Forms.Panel();
            this.ScriptHubList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshScriptHub = new Siticone.UI.WinForms.SiticoneButton();
            this.ScriptHubTitle = new System.Windows.Forms.Label();
            this.Console = new System.Windows.Forms.TextBox();
            this.CodeBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.AttachBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.ExecuteBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.LuaCExec = new System.Windows.Forms.TabPage();
            this.Console1 = new System.Windows.Forms.TextBox();
            this.LoadFileLuaC = new Siticone.UI.WinForms.SiticoneButton();
            this.ClearLuaC = new Siticone.UI.WinForms.SiticoneButton();
            this.LuacCodeBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ExecuteLuaC = new Siticone.UI.WinForms.SiticoneButton();
            this.ConsoleExec = new System.Windows.Forms.TabPage();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.siticoneOSToggleSwith2 = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.siticoneOSToggleSwith1 = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.siticoneSeparator2 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.siticoneSeparator1 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.LuaExec.SuspendLayout();
            this.ScriptHubBG.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeBox)).BeginInit();
            this.LuaCExec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuacCodeBox)).BeginInit();
            this.ConsoleExec.SuspendLayout();
            this.Settings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleMainUI
            // 
            this.titleMainUI.AutoSize = true;
            this.titleMainUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMainUI.Location = new System.Drawing.Point(6, 9);
            this.titleMainUI.Name = "titleMainUI";
            this.titleMainUI.Size = new System.Drawing.Size(115, 13);
            this.titleMainUI.TabIndex = 3;
            this.titleMainUI.Text = "REFSPLOIT v4.1.1";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Header.Controls.Add(this.MinimizeBtn);
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Controls.Add(this.titleMainUI);
            this.Header.Location = new System.Drawing.Point(-1, -1);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(689, 28);
            this.Header.TabIndex = 3;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.CheckedState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.CustomImages.Parent = this.MinimizeBtn;
            this.MinimizeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinimizeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.MinimizeBtn.HoveredState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Location = new System.Drawing.Point(637, 1);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinimizeBtn.PressedDepth = 0;
            this.MinimizeBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinimizeBtn.ShadowDecoration.Depth = 0;
            this.MinimizeBtn.ShadowDecoration.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Size = new System.Drawing.Size(23, 25);
            this.MinimizeBtn.TabIndex = 3;
            this.MinimizeBtn.Text = "_";
            this.MinimizeBtn.TextOffset = new System.Drawing.Point(0, -5);
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.CheckedState.Parent = this.CloseBtn;
            this.CloseBtn.CustomImages.Parent = this.CloseBtn;
            this.CloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.CloseBtn.HoveredState.Parent = this.CloseBtn;
            this.CloseBtn.Location = new System.Drawing.Point(659, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.PressedDepth = 0;
            this.CloseBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.ShadowDecoration.Depth = 0;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(23, 25);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "x";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HeaderDragControl
            // 
            this.HeaderDragControl.TargetControl = this.Header;
            // 
            // TitleDragControl
            // 
            this.TitleDragControl.TargetControl = this.titleMainUI;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "lua";
            this.saveFileDialog.Filter = "Lua files | .lua";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.LuaExec);
            this.TabControl.Controls.Add(this.LuaCExec);
            this.TabControl.Controls.Add(this.ConsoleExec);
            this.TabControl.Controls.Add(this.Settings);
            this.TabControl.Location = new System.Drawing.Point(-4, 23);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.RightToLeftLayout = true;
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(696, 409);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 11;
            //this.TabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl_DrawItem);
            // 
            // LuaExec
            // 
            this.LuaExec.AccessibleDescription = "";
            this.LuaExec.AccessibleName = "";
            this.LuaExec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LuaExec.Controls.Add(this.ClearBtn);
            this.LuaExec.Controls.Add(this.LoadBtn);
            this.LuaExec.Controls.Add(this.ImportScriptHub);
            this.LuaExec.Controls.Add(this.ScriptHubBG);
            this.LuaExec.Controls.Add(this.Console);
            this.LuaExec.Controls.Add(this.CodeBox);
            this.LuaExec.Controls.Add(this.AttachBtn);
            this.LuaExec.Controls.Add(this.ExecuteBtn);
            this.LuaExec.Location = new System.Drawing.Point(4, 22);
            this.LuaExec.Margin = new System.Windows.Forms.Padding(2);
            this.LuaExec.Name = "LuaExec";
            this.LuaExec.Padding = new System.Windows.Forms.Padding(2);
            this.LuaExec.Size = new System.Drawing.Size(688, 383);
            this.LuaExec.TabIndex = 0;
            this.LuaExec.Text = "Lua Executor";
            // 
            // ClearBtn
            // 
            this.ClearBtn.CheckedState.Parent = this.ClearBtn;
            this.ClearBtn.CustomImages.Parent = this.ClearBtn;
            this.ClearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.ClearBtn.HoveredState.Parent = this.ClearBtn;
            this.ClearBtn.Location = new System.Drawing.Point(314, 332);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.ShadowDecoration.Parent = this.ClearBtn;
            this.ClearBtn.Size = new System.Drawing.Size(75, 30);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.CheckedState.Parent = this.LoadBtn;
            this.LoadBtn.CustomImages.Parent = this.LoadBtn;
            this.LoadBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LoadBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoadBtn.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.LoadBtn.HoveredState.Parent = this.LoadBtn;
            this.LoadBtn.Location = new System.Drawing.Point(394, 332);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.ShadowDecoration.Parent = this.LoadBtn;
            this.LoadBtn.Size = new System.Drawing.Size(75, 30);
            this.LoadBtn.TabIndex = 13;
            this.LoadBtn.Text = "Load file";
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ImportScriptHub
            // 
            this.ImportScriptHub.CheckedState.Parent = this.ImportScriptHub;
            this.ImportScriptHub.CustomImages.Parent = this.ImportScriptHub;
            this.ImportScriptHub.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ImportScriptHub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ImportScriptHub.ForeColor = System.Drawing.Color.White;
            this.ImportScriptHub.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.ImportScriptHub.HoveredState.Parent = this.ImportScriptHub;
            this.ImportScriptHub.Location = new System.Drawing.Point(487, 332);
            this.ImportScriptHub.Name = "ImportScriptHub";
            this.ImportScriptHub.ShadowDecoration.Parent = this.ImportScriptHub;
            this.ImportScriptHub.Size = new System.Drawing.Size(182, 30);
            this.ImportScriptHub.TabIndex = 12;
            this.ImportScriptHub.Text = "Import to editor";
            this.ImportScriptHub.Click += new System.EventHandler(this.ImportScriptHub_Click);
            // 
            // ScriptHubBG
            // 
            this.ScriptHubBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ScriptHubBG.Controls.Add(this.ScriptHubList);
            this.ScriptHubBG.Controls.Add(this.panel1);
            this.ScriptHubBG.Location = new System.Drawing.Point(487, 83);
            this.ScriptHubBG.Name = "ScriptHubBG";
            this.ScriptHubBG.Size = new System.Drawing.Size(182, 243);
            this.ScriptHubBG.TabIndex = 17;
            // 
            // ScriptHubList
            // 
            this.ScriptHubList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ScriptHubList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptHubList.ForeColor = System.Drawing.Color.White;
            this.ScriptHubList.FormattingEnabled = true;
            this.ScriptHubList.Location = new System.Drawing.Point(3, 26);
            this.ScriptHubList.Name = "ScriptHubList";
            this.ScriptHubList.Size = new System.Drawing.Size(176, 221);
            this.ScriptHubList.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.RefreshScriptHub);
            this.panel1.Controls.Add(this.ScriptHubTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 25);
            this.panel1.TabIndex = 0;
            // 
            // RefreshScriptHub
            // 
            this.RefreshScriptHub.CheckedState.Parent = this.RefreshScriptHub;
            this.RefreshScriptHub.CustomImages.Parent = this.RefreshScriptHub;
            this.RefreshScriptHub.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RefreshScriptHub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshScriptHub.ForeColor = System.Drawing.Color.White;
            this.RefreshScriptHub.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.RefreshScriptHub.HoveredState.Parent = this.RefreshScriptHub;
            this.RefreshScriptHub.Location = new System.Drawing.Point(157, 0);
            this.RefreshScriptHub.Name = "RefreshScriptHub";
            this.RefreshScriptHub.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RefreshScriptHub.PressedDepth = 0;
            this.RefreshScriptHub.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RefreshScriptHub.ShadowDecoration.Depth = 0;
            this.RefreshScriptHub.ShadowDecoration.Parent = this.RefreshScriptHub;
            this.RefreshScriptHub.Size = new System.Drawing.Size(25, 25);
            this.RefreshScriptHub.TabIndex = 3;
            this.RefreshScriptHub.Text = "⟳";
            this.RefreshScriptHub.Click += new System.EventHandler(this.RefreshScriptHub_Click);
            // 
            // ScriptHubTitle
            // 
            this.ScriptHubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptHubTitle.Location = new System.Drawing.Point(3, 0);
            this.ScriptHubTitle.Name = "ScriptHubTitle";
            this.ScriptHubTitle.Size = new System.Drawing.Size(179, 23);
            this.ScriptHubTitle.TabIndex = 4;
            this.ScriptHubTitle.Text = "ScriptHub";
            this.ScriptHubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Console.ForeColor = System.Drawing.Color.Lime;
            this.Console.Location = new System.Drawing.Point(487, 6);
            this.Console.Margin = new System.Windows.Forms.Padding(2);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Console.Size = new System.Drawing.Size(182, 72);
            this.Console.TabIndex = 19;
            this.Console.Text = "RS | initialized";
            this.Console.TextChanged += new System.EventHandler(this.Console_TextChanged);
            // 
            // CodeBox
            // 
            this.CodeBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.CodeBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.CodeBox.AutoScrollMinSize = new System.Drawing.Size(267, 14);
            this.CodeBox.BackBrush = null;
            this.CodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CodeBox.BookmarkColor = System.Drawing.Color.LightCoral;
            this.CodeBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.CodeBox.CharHeight = 14;
            this.CodeBox.CharWidth = 8;
            this.CodeBox.CommentPrefix = "--";
            this.CodeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CodeBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CodeBox.IsReplaceMode = false;
            this.CodeBox.Language = FastColoredTextBoxNS.Language.Lua;
            this.CodeBox.LeftBracket = '(';
            this.CodeBox.LeftBracket2 = '{';
            this.CodeBox.LineNumberColor = System.Drawing.Color.LightCoral;
            this.CodeBox.Location = new System.Drawing.Point(5, 24);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.CodeBox.RightBracket = ')';
            this.CodeBox.RightBracket2 = '}';
            this.CodeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CodeBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("CodeBox.ServiceColors")));
            this.CodeBox.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.CodeBox.Size = new System.Drawing.Size(464, 301);
            this.CodeBox.TabIndex = 18;
            this.CodeBox.Text = "// Paste your lua script here.";
            this.CodeBox.Zoom = 100;
            // 
            // AttachBtn
            // 
            this.AttachBtn.CheckedState.Parent = this.AttachBtn;
            this.AttachBtn.CustomImages.Parent = this.AttachBtn;
            this.AttachBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AttachBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AttachBtn.ForeColor = System.Drawing.Color.White;
            this.AttachBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.AttachBtn.HoveredState.Parent = this.AttachBtn;
            this.AttachBtn.Location = new System.Drawing.Point(5, 332);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.ShadowDecoration.Parent = this.AttachBtn;
            this.AttachBtn.Size = new System.Drawing.Size(75, 30);
            this.AttachBtn.TabIndex = 15;
            this.AttachBtn.Text = "Attach";
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.CheckedState.Parent = this.ExecuteBtn;
            this.ExecuteBtn.CustomImages.Parent = this.ExecuteBtn;
            this.ExecuteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ExecuteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExecuteBtn.ForeColor = System.Drawing.Color.White;
            this.ExecuteBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.ExecuteBtn.HoveredState.Parent = this.ExecuteBtn;
            this.ExecuteBtn.Location = new System.Drawing.Point(86, 332);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.ShadowDecoration.Parent = this.ExecuteBtn;
            this.ExecuteBtn.Size = new System.Drawing.Size(75, 30);
            this.ExecuteBtn.TabIndex = 16;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // LuaCExec
            // 
            this.LuaCExec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LuaCExec.Controls.Add(this.Console1);
            this.LuaCExec.Controls.Add(this.LoadFileLuaC);
            this.LuaCExec.Controls.Add(this.ClearLuaC);
            this.LuaCExec.Controls.Add(this.LuacCodeBox);
            this.LuaCExec.Controls.Add(this.ExecuteLuaC);
            this.LuaCExec.ForeColor = System.Drawing.Color.White;
            this.LuaCExec.Location = new System.Drawing.Point(4, 22);
            this.LuaCExec.Margin = new System.Windows.Forms.Padding(2);
            this.LuaCExec.Name = "LuaCExec";
            this.LuaCExec.Size = new System.Drawing.Size(688, 383);
            this.LuaCExec.TabIndex = 3;
            this.LuaCExec.Text = "LUA-C Executor";
            // 
            // Console1
            // 
            this.Console1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Console1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Console1.ForeColor = System.Drawing.Color.Lime;
            this.Console1.Location = new System.Drawing.Point(494, 22);
            this.Console1.Margin = new System.Windows.Forms.Padding(2);
            this.Console1.Multiline = true;
            this.Console1.Name = "Console1";
            this.Console1.ReadOnly = true;
            this.Console1.Size = new System.Drawing.Size(168, 301);
            this.Console1.TabIndex = 20;
            this.Console1.TextChanged += new System.EventHandler(this.Console1_TextChanged);
            // 
            // LoadFileLuaC
            // 
            this.LoadFileLuaC.CheckedState.Parent = this.LoadFileLuaC;
            this.LoadFileLuaC.CustomImages.Parent = this.LoadFileLuaC;
            this.LoadFileLuaC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LoadFileLuaC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoadFileLuaC.ForeColor = System.Drawing.Color.White;
            this.LoadFileLuaC.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.LoadFileLuaC.HoveredState.Parent = this.LoadFileLuaC;
            this.LoadFileLuaC.Location = new System.Drawing.Point(381, 330);
            this.LoadFileLuaC.Name = "LoadFileLuaC";
            this.LoadFileLuaC.ShadowDecoration.Parent = this.LoadFileLuaC;
            this.LoadFileLuaC.Size = new System.Drawing.Size(92, 43);
            this.LoadFileLuaC.TabIndex = 17;
            this.LoadFileLuaC.Text = "Load file";
            this.LoadFileLuaC.Click += new System.EventHandler(this.LoadFileLuaC_Click);
            // 
            // ClearLuaC
            // 
            this.ClearLuaC.CheckedState.Parent = this.ClearLuaC;
            this.ClearLuaC.CustomImages.Parent = this.ClearLuaC;
            this.ClearLuaC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClearLuaC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearLuaC.ForeColor = System.Drawing.Color.White;
            this.ClearLuaC.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.ClearLuaC.HoveredState.Parent = this.ClearLuaC;
            this.ClearLuaC.Location = new System.Drawing.Point(272, 330);
            this.ClearLuaC.Name = "ClearLuaC";
            this.ClearLuaC.ShadowDecoration.Parent = this.ClearLuaC;
            this.ClearLuaC.Size = new System.Drawing.Size(94, 43);
            this.ClearLuaC.TabIndex = 18;
            this.ClearLuaC.Text = "Clear";
            this.ClearLuaC.Click += new System.EventHandler(this.ClearLuaC_Click);
            // 
            // LuacCodeBox
            // 
            this.LuacCodeBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.LuacCodeBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.LuacCodeBox.AutoScrollMinSize = new System.Drawing.Size(258, 14);
            this.LuacCodeBox.BackBrush = null;
            this.LuacCodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LuacCodeBox.BookmarkColor = System.Drawing.Color.LightCoral;
            this.LuacCodeBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.LuacCodeBox.CharHeight = 14;
            this.LuacCodeBox.CharWidth = 8;
            this.LuacCodeBox.CommentPrefix = "--";
            this.LuacCodeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LuacCodeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LuacCodeBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.LuacCodeBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LuacCodeBox.IsReplaceMode = false;
            this.LuacCodeBox.Language = FastColoredTextBoxNS.Language.Lua;
            this.LuacCodeBox.LeftBracket = '(';
            this.LuacCodeBox.LeftBracket2 = '{';
            this.LuacCodeBox.LineNumberColor = System.Drawing.Color.LightCoral;
            this.LuacCodeBox.Location = new System.Drawing.Point(8, 22);
            this.LuacCodeBox.Name = "LuacCodeBox";
            this.LuacCodeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.LuacCodeBox.RightBracket = ')';
            this.LuacCodeBox.RightBracket2 = '}';
            this.LuacCodeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LuacCodeBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("LuacCodeBox.ServiceColors")));
            this.LuacCodeBox.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.LuacCodeBox.Size = new System.Drawing.Size(465, 301);
            this.LuacCodeBox.TabIndex = 19;
            this.LuacCodeBox.Text = "// Paste your lua-c script here.";
            this.LuacCodeBox.Zoom = 100;
            // 
            // ExecuteLuaC
            // 
            this.ExecuteLuaC.CheckedState.Parent = this.ExecuteLuaC;
            this.ExecuteLuaC.CustomImages.Parent = this.ExecuteLuaC;
            this.ExecuteLuaC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ExecuteLuaC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExecuteLuaC.ForeColor = System.Drawing.Color.White;
            this.ExecuteLuaC.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.ExecuteLuaC.HoveredState.Parent = this.ExecuteLuaC;
            this.ExecuteLuaC.Location = new System.Drawing.Point(10, 330);
            this.ExecuteLuaC.Name = "ExecuteLuaC";
            this.ExecuteLuaC.ShadowDecoration.Parent = this.ExecuteLuaC;
            this.ExecuteLuaC.Size = new System.Drawing.Size(108, 43);
            this.ExecuteLuaC.TabIndex = 19;
            this.ExecuteLuaC.Text = "Execute";
            this.ExecuteLuaC.Click += new System.EventHandler(this.ExecuteLuaC_Click);
            // 
            // ConsoleExec
            // 
            this.ConsoleExec.AccessibleDescription = "";
            this.ConsoleExec.AccessibleName = "";
            this.ConsoleExec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ConsoleExec.Controls.Add(this.Input);
            this.ConsoleExec.Controls.Add(this.Output);
            this.ConsoleExec.Location = new System.Drawing.Point(4, 22);
            this.ConsoleExec.Margin = new System.Windows.Forms.Padding(2);
            this.ConsoleExec.Name = "ConsoleExec";
            this.ConsoleExec.Padding = new System.Windows.Forms.Padding(2);
            this.ConsoleExec.Size = new System.Drawing.Size(688, 383);
            this.ConsoleExec.TabIndex = 1;
            this.ConsoleExec.Text = "Console Executor";
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.Black;
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Input.ForeColor = System.Drawing.Color.White;
            this.Input.Location = new System.Drawing.Point(4, 346);
            this.Input.Margin = new System.Windows.Forms.Padding(2);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(677, 30);
            this.Input.TabIndex = 0;
            this.Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.Black;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(4, 5);
            this.Output.Margin = new System.Windows.Forms.Padding(2);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(677, 336);
            this.Output.TabIndex = 0;
            this.Output.Text = "Welcome to REFSPLOIT Console Execution. \r\n\r\nType \'cmds\' to see all available comm" +
    "ands!\r\n\r\nDISCLAIMED: DOES NOT WORK YET, WILL BE FULLY OPERATIONAL IN THE NEXT VE" +
    "RSION.";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Settings.Controls.Add(this.siticoneOSToggleSwith2);
            this.Settings.Controls.Add(this.siticoneOSToggleSwith1);
            this.Settings.Controls.Add(this.siticoneSeparator2);
            this.Settings.Controls.Add(this.siticoneSeparator1);
            this.Settings.Controls.Add(this.label3);
            this.Settings.Controls.Add(this.label4);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.textBox1);
            this.Settings.Controls.Add(this.panel2);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Settings.Name = "Settings";
            this.Settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Settings.Size = new System.Drawing.Size(688, 383);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            // 
            // siticoneOSToggleSwith2
            // 
            this.siticoneOSToggleSwith2.Location = new System.Drawing.Point(21, 100);
            this.siticoneOSToggleSwith2.Name = "siticoneOSToggleSwith2";
            this.siticoneOSToggleSwith2.Size = new System.Drawing.Size(38, 22);
            this.siticoneOSToggleSwith2.TabIndex = 5;
            this.siticoneOSToggleSwith2.Text = "siticoneOSToggleSwith1";
            // 
            // siticoneOSToggleSwith1
            // 
            this.siticoneOSToggleSwith1.Location = new System.Drawing.Point(21, 72);
            this.siticoneOSToggleSwith1.Name = "siticoneOSToggleSwith1";
            this.siticoneOSToggleSwith1.Size = new System.Drawing.Size(38, 22);
            this.siticoneOSToggleSwith1.TabIndex = 5;
            this.siticoneOSToggleSwith1.Text = "siticoneOSToggleSwith1";
            // 
            // siticoneSeparator2
            // 
            this.siticoneSeparator2.Location = new System.Drawing.Point(188, 56);
            this.siticoneSeparator2.Name = "siticoneSeparator2";
            this.siticoneSeparator2.Size = new System.Drawing.Size(125, 10);
            this.siticoneSeparator2.TabIndex = 4;
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Location = new System.Drawing.Point(21, 56);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(137, 10);
            this.siticoneSeparator1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "     Misc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "FPS Unlocker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "     General";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(409, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 236);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(409, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 25);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Changelog";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(681, 428);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.TabControl);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.LuaExec.ResumeLayout(false);
            this.LuaExec.PerformLayout();
            this.ScriptHubBG.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeBox)).EndInit();
            this.LuaCExec.ResumeLayout(false);
            this.LuaCExec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuacCodeBox)).EndInit();
            this.ConsoleExec.ResumeLayout(false);
            this.ConsoleExec.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleMainUI;
        private System.Windows.Forms.Panel Header;
        private Siticone.UI.WinForms.SiticoneButton MinimizeBtn;
        private Siticone.UI.WinForms.SiticoneButton CloseBtn;
        private Siticone.UI.WinForms.SiticoneDragControl HeaderDragControl;
        private Siticone.UI.WinForms.SiticoneDragControl TitleDragControl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage LuaExec;
        private System.Windows.Forms.TextBox Console;
        private FastColoredTextBoxNS.FastColoredTextBox CodeBox;
        private System.Windows.Forms.TabPage ConsoleExec;
        private System.Windows.Forms.Panel ScriptHubBG;
        private System.Windows.Forms.ListBox ScriptHubList;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneButton RefreshScriptHub;
        private System.Windows.Forms.Label ScriptHubTitle;
        private Siticone.UI.WinForms.SiticoneButton ImportScriptHub;
        private Siticone.UI.WinForms.SiticoneButton LoadBtn;
        private Siticone.UI.WinForms.SiticoneButton ClearBtn;
        private Siticone.UI.WinForms.SiticoneButton AttachBtn;
        private Siticone.UI.WinForms.SiticoneButton ExecuteBtn;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TabPage LuaCExec;
        private Siticone.UI.WinForms.SiticoneButton LoadFileLuaC;
        private Siticone.UI.WinForms.SiticoneButton ClearLuaC;
        private FastColoredTextBoxNS.FastColoredTextBox LuacCodeBox;
        private Siticone.UI.WinForms.SiticoneButton ExecuteLuaC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith siticoneOSToggleSwith2;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith siticoneOSToggleSwith1;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Console1;
    }
}