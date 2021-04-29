
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
            this.ExecuteBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.ClearBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.LoadBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.ScriptHubBG = new System.Windows.Forms.Panel();
            this.ScriptHubList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshScriptHub = new Siticone.UI.WinForms.SiticoneButton();
            this.ScriptHubTitle = new System.Windows.Forms.Label();
            this.AttachBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.ImportScriptHub = new Siticone.UI.WinForms.SiticoneButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.CodeBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.Header.SuspendLayout();
            this.ScriptHubBG.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleMainUI
            // 
            this.titleMainUI.AutoSize = true;
            this.titleMainUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMainUI.Location = new System.Drawing.Point(6, 9);
            this.titleMainUI.Name = "titleMainUI";
            this.titleMainUI.Size = new System.Drawing.Size(104, 13);
            this.titleMainUI.TabIndex = 3;
            this.titleMainUI.Text = "REFSPLOIT v4.0";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Header.Controls.Add(this.MinimizeBtn);
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Controls.Add(this.titleMainUI);
            this.Header.Location = new System.Drawing.Point(-1, -1);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(589, 28);
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
            this.MinimizeBtn.Location = new System.Drawing.Point(542, 2);
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
            this.CloseBtn.Location = new System.Drawing.Point(564, 2);
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
            // ExecuteBtn
            // 
            this.ExecuteBtn.CheckedState.Parent = this.ExecuteBtn;
            this.ExecuteBtn.CustomImages.Parent = this.ExecuteBtn;
            this.ExecuteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ExecuteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExecuteBtn.ForeColor = System.Drawing.Color.White;
            this.ExecuteBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.ExecuteBtn.HoveredState.Parent = this.ExecuteBtn;
            this.ExecuteBtn.Location = new System.Drawing.Point(91, 298);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.ShadowDecoration.Parent = this.ExecuteBtn;
            this.ExecuteBtn.Size = new System.Drawing.Size(75, 30);
            this.ExecuteBtn.TabIndex = 5;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
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
            this.ClearBtn.Location = new System.Drawing.Point(221, 298);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.ShadowDecoration.Parent = this.ClearBtn;
            this.ClearBtn.Size = new System.Drawing.Size(75, 30);
            this.ClearBtn.TabIndex = 5;
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
            this.LoadBtn.Location = new System.Drawing.Point(302, 298);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.ShadowDecoration.Parent = this.LoadBtn;
            this.LoadBtn.Size = new System.Drawing.Size(75, 30);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Load file";
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ScriptHubBG
            // 
            this.ScriptHubBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ScriptHubBG.Controls.Add(this.ScriptHubList);
            this.ScriptHubBG.Controls.Add(this.panel1);
            this.ScriptHubBG.Location = new System.Drawing.Point(407, 45);
            this.ScriptHubBG.Name = "ScriptHubBG";
            this.ScriptHubBG.Size = new System.Drawing.Size(147, 243);
            this.ScriptHubBG.TabIndex = 6;
            // 
            // ScriptHubList
            // 
            this.ScriptHubList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ScriptHubList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptHubList.ForeColor = System.Drawing.Color.White;
            this.ScriptHubList.FormattingEnabled = true;
            this.ScriptHubList.Location = new System.Drawing.Point(0, 26);
            this.ScriptHubList.Name = "ScriptHubList";
            this.ScriptHubList.Size = new System.Drawing.Size(147, 221);
            this.ScriptHubList.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.RefreshScriptHub);
            this.panel1.Controls.Add(this.ScriptHubTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 25);
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
            this.RefreshScriptHub.Location = new System.Drawing.Point(121, -1);
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
            this.ScriptHubTitle.Location = new System.Drawing.Point(3, 6);
            this.ScriptHubTitle.Name = "ScriptHubTitle";
            this.ScriptHubTitle.Size = new System.Drawing.Size(141, 13);
            this.ScriptHubTitle.TabIndex = 4;
            this.ScriptHubTitle.Text = "ScriptHub";
            this.ScriptHubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.AttachBtn.Location = new System.Drawing.Point(10, 298);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.ShadowDecoration.Parent = this.AttachBtn;
            this.AttachBtn.Size = new System.Drawing.Size(75, 30);
            this.AttachBtn.TabIndex = 5;
            this.AttachBtn.Text = "Attach";
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
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
            this.ImportScriptHub.Location = new System.Drawing.Point(407, 298);
            this.ImportScriptHub.Name = "ImportScriptHub";
            this.ImportScriptHub.ShadowDecoration.Parent = this.ImportScriptHub;
            this.ImportScriptHub.Size = new System.Drawing.Size(147, 30);
            this.ImportScriptHub.TabIndex = 5;
            this.ImportScriptHub.Text = "Import to editor";
            this.ImportScriptHub.Click += new System.EventHandler(this.ImportScriptHub_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "lua";
            this.saveFileDialog.Filter = "Lua files | .lua";
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
            this.CodeBox.AutoScrollMinSize = new System.Drawing.Size(235, 14);
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
            this.CodeBox.Location = new System.Drawing.Point(10, 45);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.CodeBox.RightBracket = ')';
            this.CodeBox.RightBracket2 = '}';
            this.CodeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CodeBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("CodeBox.ServiceColors")));
            this.CodeBox.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.CodeBox.Size = new System.Drawing.Size(367, 243);
            this.CodeBox.TabIndex = 9;
            this.CodeBox.Text = "// Paste your script here.";
            this.CodeBox.Zoom = 100;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(585, 340);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.ScriptHubBG);
            this.Controls.Add(this.ImportScriptHub);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AttachBtn);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.Header);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ScriptHubBG.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleMainUI;
        private System.Windows.Forms.Panel Header;
        private Siticone.UI.WinForms.SiticoneButton MinimizeBtn;
        private Siticone.UI.WinForms.SiticoneButton CloseBtn;
        private Siticone.UI.WinForms.SiticoneDragControl HeaderDragControl;
        private Siticone.UI.WinForms.SiticoneDragControl TitleDragControl;
        private Siticone.UI.WinForms.SiticoneButton ExecuteBtn;
        private Siticone.UI.WinForms.SiticoneButton ClearBtn;
        private Siticone.UI.WinForms.SiticoneButton LoadBtn;
        private System.Windows.Forms.Panel ScriptHubBG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ScriptHubTitle;
        private Siticone.UI.WinForms.SiticoneButton AttachBtn;
        private System.Windows.Forms.ListBox ScriptHubList;
        private Siticone.UI.WinForms.SiticoneButton ImportScriptHub;
        private Siticone.UI.WinForms.SiticoneButton RefreshScriptHub;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private FastColoredTextBoxNS.FastColoredTextBox CodeBox;
    }
}