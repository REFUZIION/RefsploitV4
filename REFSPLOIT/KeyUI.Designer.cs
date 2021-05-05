
namespace REFSPLOIT
{
    partial class KeyUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyUI));
            this.Header = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.CloseBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.titleUI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscordBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.SubmitBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.GetKeyBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.KeyTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Header.Controls.Add(this.MinimizeBtn);
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Controls.Add(this.titleUI);
            this.Header.Location = new System.Drawing.Point(-2, -1);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(405, 30);
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
            this.MinimizeBtn.Location = new System.Drawing.Point(348, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinimizeBtn.PressedDepth = 0;
            this.MinimizeBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinimizeBtn.ShadowDecoration.Depth = 0;
            this.MinimizeBtn.ShadowDecoration.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Size = new System.Drawing.Size(28, 28);
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
            this.CloseBtn.Location = new System.Drawing.Point(375, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.PressedDepth = 0;
            this.CloseBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.ShadowDecoration.Depth = 0;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(29, 28);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "x";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // titleUI
            // 
            this.titleUI.AutoSize = true;
            this.titleUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleUI.ForeColor = System.Drawing.Color.White;
            this.titleUI.Location = new System.Drawing.Point(10, 8);
            this.titleUI.Name = "titleUI";
            this.titleUI.Size = new System.Drawing.Size(186, 13);
            this.titleUI.TabIndex = 3;
            this.titleUI.Text = "REFSPLOIT v4.0 | Free Version";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Niagara Engraved", 15.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 21.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "REFSPLOIT v4.0!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiscordBtn
            // 
            this.DiscordBtn.CheckedState.Parent = this.DiscordBtn;
            this.DiscordBtn.CustomImages.Parent = this.DiscordBtn;
            this.DiscordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DiscordBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DiscordBtn.ForeColor = System.Drawing.Color.White;
            this.DiscordBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.DiscordBtn.HoveredState.Parent = this.DiscordBtn;
            this.DiscordBtn.Location = new System.Drawing.Point(89, 211);
            this.DiscordBtn.Name = "DiscordBtn";
            this.DiscordBtn.ShadowDecoration.Parent = this.DiscordBtn;
            this.DiscordBtn.Size = new System.Drawing.Size(225, 28);
            this.DiscordBtn.TabIndex = 4;
            this.DiscordBtn.Text = "Join discord";
            this.DiscordBtn.Click += new System.EventHandler(this.DiscordBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.CheckedState.Parent = this.SubmitBtn;
            this.SubmitBtn.CustomImages.Parent = this.SubmitBtn;
            this.SubmitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.SubmitBtn.HoveredState.Parent = this.SubmitBtn;
            this.SubmitBtn.Location = new System.Drawing.Point(89, 177);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.ShadowDecoration.Parent = this.SubmitBtn;
            this.SubmitBtn.Size = new System.Drawing.Size(108, 28);
            this.SubmitBtn.TabIndex = 6;
            this.SubmitBtn.Text = "Login";
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // GetKeyBtn
            // 
            this.GetKeyBtn.CheckedState.Parent = this.GetKeyBtn;
            this.GetKeyBtn.CustomImages.Parent = this.GetKeyBtn;
            this.GetKeyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GetKeyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GetKeyBtn.ForeColor = System.Drawing.Color.White;
            this.GetKeyBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.GetKeyBtn.HoveredState.Parent = this.GetKeyBtn;
            this.GetKeyBtn.Location = new System.Drawing.Point(206, 177);
            this.GetKeyBtn.Name = "GetKeyBtn";
            this.GetKeyBtn.ShadowDecoration.Parent = this.GetKeyBtn;
            this.GetKeyBtn.Size = new System.Drawing.Size(108, 28);
            this.GetKeyBtn.TabIndex = 7;
            this.GetKeyBtn.Text = "Get key";
            this.GetKeyBtn.Click += new System.EventHandler(this.GetKeyBtn_Click);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.BorderThickness = 0;
            this.KeyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyTextBox.DefaultText = "";
            this.KeyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KeyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KeyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyTextBox.DisabledState.Parent = this.KeyTextBox;
            this.KeyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.KeyTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyTextBox.FocusedState.Parent = this.KeyTextBox;
            this.KeyTextBox.ForeColor = System.Drawing.Color.White;
            this.KeyTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyTextBox.HoveredState.Parent = this.KeyTextBox;
            this.KeyTextBox.Location = new System.Drawing.Point(89, 149);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.PasswordChar = '•';
            this.KeyTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.KeyTextBox.PlaceholderText = "";
            this.KeyTextBox.SelectedText = "";
            this.KeyTextBox.ShadowDecoration.Parent = this.KeyTextBox;
            this.KeyTextBox.Size = new System.Drawing.Size(225, 22);
            this.KeyTextBox.TabIndex = 8;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.Header;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.titleUI;
            // 
            // KeyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(401, 265);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.GetKeyBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.DiscordBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeyUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REFSPLOIT V4.1 | Free Version";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private Siticone.UI.WinForms.SiticoneButton MinimizeBtn;
        private Siticone.UI.WinForms.SiticoneButton CloseBtn;
        private System.Windows.Forms.Label titleUI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton DiscordBtn;
        private Siticone.UI.WinForms.SiticoneButton SubmitBtn;
        private Siticone.UI.WinForms.SiticoneButton GetKeyBtn;
        private Siticone.UI.WinForms.SiticoneTextBox KeyTextBox;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
    }
}