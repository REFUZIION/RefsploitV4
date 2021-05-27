
namespace REFSPLOIT
{
    partial class HomeUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscordBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.LaunchBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.LaunchElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.DiscordElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.CloseBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.titleLoaderUI = new System.Windows.Forms.Label();
            this.LoaderDragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.LabelDragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "REFSPLOIT v4.1.1!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.DiscordBtn.Location = new System.Drawing.Point(101, 203);
            this.DiscordBtn.Name = "DiscordBtn";
            this.DiscordBtn.ShadowDecoration.Parent = this.DiscordBtn;
            this.DiscordBtn.Size = new System.Drawing.Size(180, 24);
            this.DiscordBtn.TabIndex = 1;
            this.DiscordBtn.Text = "Join discord";
            this.DiscordBtn.Click += new System.EventHandler(this.DiscordBtn_Click);
            // 
            // LaunchBtn
            // 
            this.LaunchBtn.CheckedState.Parent = this.LaunchBtn;
            this.LaunchBtn.CustomImages.Parent = this.LaunchBtn;
            this.LaunchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LaunchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LaunchBtn.ForeColor = System.Drawing.Color.White;
            this.LaunchBtn.HoveredState.FillColor = System.Drawing.Color.LightCoral;
            this.LaunchBtn.HoveredState.Parent = this.LaunchBtn;
            this.LaunchBtn.Location = new System.Drawing.Point(101, 173);
            this.LaunchBtn.Name = "LaunchBtn";
            this.LaunchBtn.ShadowDecoration.Parent = this.LaunchBtn;
            this.LaunchBtn.Size = new System.Drawing.Size(180, 24);
            this.LaunchBtn.TabIndex = 1;
            this.LaunchBtn.Text = "Launch REFSPLOIT";
            this.LaunchBtn.Click += new System.EventHandler(this.LaunchBtn_Click);
            // 
            // LaunchElipse
            // 
            this.LaunchElipse.BorderRadius = 2;
            this.LaunchElipse.TargetControl = this.LaunchBtn;
            // 
            // DiscordElipse
            // 
            this.DiscordElipse.BorderRadius = 2;
            this.DiscordElipse.TargetControl = this.DiscordBtn;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Header.Controls.Add(this.MinimizeBtn);
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Controls.Add(this.titleLoaderUI);
            this.Header.Location = new System.Drawing.Point(-6, -2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(392, 28);
            this.Header.TabIndex = 2;
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
            this.MinimizeBtn.Location = new System.Drawing.Point(346, 2);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinimizeBtn.PressedDepth = 0;
            this.MinimizeBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinimizeBtn.ShadowDecoration.Depth = 0;
            this.MinimizeBtn.ShadowDecoration.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Size = new System.Drawing.Size(22, 24);
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
            this.CloseBtn.Location = new System.Drawing.Point(367, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.PressedDepth = 0;
            this.CloseBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.ShadowDecoration.Depth = 0;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(22, 24);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "x";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // titleLoaderUI
            // 
            this.titleLoaderUI.AutoSize = true;
            this.titleLoaderUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLoaderUI.Location = new System.Drawing.Point(10, 8);
            this.titleLoaderUI.Name = "titleLoaderUI";
            this.titleLoaderUI.Size = new System.Drawing.Size(115, 13);
            this.titleLoaderUI.TabIndex = 3;
            this.titleLoaderUI.Text = "REFSPLOIT v4.1.1";
            // 
            // LoaderDragControl
            // 
            this.LoaderDragControl.TargetControl = this.Header;
            // 
            // LabelDragControl
            // 
            this.LabelDragControl.TargetControl = this.Header;
            // 
            // HomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(383, 287);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.LaunchBtn);
            this.Controls.Add(this.DiscordBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REFSPLOIT";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneButton DiscordBtn;
        private Siticone.UI.WinForms.SiticoneButton LaunchBtn;
        private Siticone.UI.WinForms.SiticoneElipse LaunchElipse;
        private Siticone.UI.WinForms.SiticoneElipse DiscordElipse;
        private System.Windows.Forms.Panel Header;
        private Siticone.UI.WinForms.SiticoneButton CloseBtn;
        private System.Windows.Forms.Label titleLoaderUI;
        private Siticone.UI.WinForms.SiticoneButton MinimizeBtn;
        private Siticone.UI.WinForms.SiticoneDragControl LoaderDragControl;
        private Siticone.UI.WinForms.SiticoneDragControl LabelDragControl;
    }
}

