using DLLInjector.Properties;

namespace DLLInjector
{
    partial class DLLInjector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLLInjector));
            ReloadBtn = new Button();
            DllPathTB = new TextBox();
            DllLabel = new Label();
            BrowseBtn = new Button();
            InjectBtn = new Button();
            OpenDLLDialog = new OpenFileDialog();
            TitlePB = new PictureBox();
            CloseBtn = new Button();
            CreditsLabel = new Label();
            ProcessesLV = new ListView();
            NameCH = new ColumnHeader();
            PIDCH = new ColumnHeader();
            ThemesBtn = new Button();
            ThemesFLP = new FlowLayoutPanel();
            CreateShortcutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)TitlePB).BeginInit();
            SuspendLayout();
            // 
            // ReloadBtn
            // 
            ReloadBtn.BackColor = Color.FromArgb(32, 32, 32);
            ReloadBtn.FlatAppearance.BorderSize = 0;
            ReloadBtn.FlatStyle = FlatStyle.Flat;
            ReloadBtn.ForeColor = Color.White;
            ReloadBtn.Location = new Point(12, 415);
            ReloadBtn.Name = "ReloadBtn";
            ReloadBtn.Size = new Size(75, 23);
            ReloadBtn.TabIndex = 3;
            ReloadBtn.Tag = "Theme_Button";
            ReloadBtn.Text = "Reload";
            ReloadBtn.UseVisualStyleBackColor = false;
            ReloadBtn.Click += ReloadBtn_Click;
            // 
            // DllPathTB
            // 
            DllPathTB.BackColor = Color.FromArgb(32, 32, 32);
            DllPathTB.BorderStyle = BorderStyle.None;
            DllPathTB.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            DllPathTB.ForeColor = Color.White;
            DllPathTB.Location = new Point(48, 118);
            DllPathTB.Name = "DllPathTB";
            DllPathTB.Size = new Size(659, 23);
            DllPathTB.TabIndex = 0;
            DllPathTB.Tag = "Theme_SecondaryColor";
            // 
            // DllLabel
            // 
            DllLabel.AutoSize = true;
            DllLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            DllLabel.ForeColor = Color.White;
            DllLabel.Location = new Point(12, 122);
            DllLabel.Name = "DllLabel";
            DllLabel.Size = new Size(30, 15);
            DllLabel.TabIndex = 3;
            DllLabel.Text = "DLL:";
            // 
            // BrowseBtn
            // 
            BrowseBtn.BackColor = Color.FromArgb(32, 32, 32);
            BrowseBtn.FlatAppearance.BorderSize = 0;
            BrowseBtn.FlatStyle = FlatStyle.Flat;
            BrowseBtn.ForeColor = Color.White;
            BrowseBtn.Location = new Point(713, 118);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(75, 23);
            BrowseBtn.TabIndex = 1;
            BrowseBtn.Tag = "Theme_Button";
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = false;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // InjectBtn
            // 
            InjectBtn.BackColor = Color.FromArgb(32, 32, 32);
            InjectBtn.FlatAppearance.BorderSize = 0;
            InjectBtn.FlatStyle = FlatStyle.Flat;
            InjectBtn.ForeColor = Color.White;
            InjectBtn.Location = new Point(713, 415);
            InjectBtn.Name = "InjectBtn";
            InjectBtn.Size = new Size(75, 23);
            InjectBtn.TabIndex = 5;
            InjectBtn.Tag = "Theme_Button";
            InjectBtn.Text = "Inject";
            InjectBtn.UseVisualStyleBackColor = false;
            InjectBtn.Click += InjectBtn_Click;
            // 
            // OpenDLLDialog
            // 
            OpenDLLDialog.Filter = "DLL Files|*.dll|All Files|*.*";
            OpenDLLDialog.SupportMultiDottedExtensions = true;
            // 
            // TitlePB
            // 
            TitlePB.BackColor = Color.FromArgb(0, 0, 0, 0);
            TitlePB.Image = Resources.TitleImage;
            TitlePB.Location = new Point(12, 12);
            TitlePB.Name = "TitlePB";
            TitlePB.Size = new Size(776, 100);
            TitlePB.SizeMode = PictureBoxSizeMode.Zoom;
            TitlePB.TabIndex = 6;
            TitlePB.TabStop = false;
            TitlePB.Tag = "Theme_Title";
            TitlePB.MouseDown += DLLInjector_MouseDown;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.FromArgb(32, 32, 32);
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.ForeColor = Color.White;
            CloseBtn.Location = new Point(753, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(35, 33);
            CloseBtn.TabIndex = 6;
            CloseBtn.Tag = "Theme_Button";
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // CreditsLabel
            // 
            CreditsLabel.AutoSize = true;
            CreditsLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            CreditsLabel.ForeColor = Color.White;
            CreditsLabel.Location = new Point(520, 419);
            CreditsLabel.Name = "CreditsLabel";
            CreditsLabel.Size = new Size(187, 15);
            CreditsLabel.TabIndex = 3;
            CreditsLabel.Text = "Made by discord@galaxygamero2";
            // 
            // ProcessesLV
            // 
            ProcessesLV.BackColor = Color.FromArgb(32, 32, 32);
            ProcessesLV.BorderStyle = BorderStyle.None;
            ProcessesLV.Columns.AddRange(new ColumnHeader[] { NameCH, PIDCH });
            ProcessesLV.ForeColor = Color.White;
            ProcessesLV.FullRowSelect = true;
            ProcessesLV.Location = new Point(12, 147);
            ProcessesLV.MultiSelect = false;
            ProcessesLV.Name = "ProcessesLV";
            ProcessesLV.ShowGroups = false;
            ProcessesLV.Size = new Size(776, 262);
            ProcessesLV.TabIndex = 2;
            ProcessesLV.Tag = "Theme_SecondaryColor";
            ProcessesLV.UseCompatibleStateImageBehavior = false;
            ProcessesLV.View = View.Details;
            // 
            // NameCH
            // 
            NameCH.Text = "Name";
            NameCH.Width = 150;
            // 
            // PIDCH
            // 
            PIDCH.Text = "PID";
            // 
            // ThemesBtn
            // 
            ThemesBtn.BackColor = Color.FromArgb(32, 32, 32);
            ThemesBtn.FlatAppearance.BorderSize = 0;
            ThemesBtn.FlatStyle = FlatStyle.Flat;
            ThemesBtn.ForeColor = Color.White;
            ThemesBtn.Location = new Point(93, 415);
            ThemesBtn.Name = "ThemesBtn";
            ThemesBtn.Size = new Size(75, 23);
            ThemesBtn.TabIndex = 4;
            ThemesBtn.Tag = "Theme_Button";
            ThemesBtn.Text = "Themes";
            ThemesBtn.UseVisualStyleBackColor = false;
            ThemesBtn.Click += ThemesBtn_Click;
            // 
            // ThemesFLP
            // 
            ThemesFLP.AutoScroll = true;
            ThemesFLP.Enabled = false;
            ThemesFLP.Location = new Point(12, 147);
            ThemesFLP.Margin = new Padding(0);
            ThemesFLP.Name = "ThemesFLP";
            ThemesFLP.Size = new Size(776, 262);
            ThemesFLP.TabIndex = 9;
            ThemesFLP.Tag = "Theme_SecondaryColor";
            ThemesFLP.Visible = false;
            // 
            // CreateShortcutBtn
            // 
            CreateShortcutBtn.BackColor = Color.FromArgb(32, 32, 32);
            CreateShortcutBtn.FlatAppearance.BorderSize = 0;
            CreateShortcutBtn.FlatStyle = FlatStyle.Flat;
            CreateShortcutBtn.ForeColor = Color.White;
            CreateShortcutBtn.Location = new Point(174, 415);
            CreateShortcutBtn.Name = "CreateShortcutBtn";
            CreateShortcutBtn.Size = new Size(120, 23);
            CreateShortcutBtn.TabIndex = 5;
            CreateShortcutBtn.Tag = "Theme_Button";
            CreateShortcutBtn.Text = "Create Shortcut";
            CreateShortcutBtn.UseVisualStyleBackColor = false;
            CreateShortcutBtn.Click += CreateShortcutBtn_Click;
            // 
            // DLLInjector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(CloseBtn);
            Controls.Add(ProcessesLV);
            Controls.Add(TitlePB);
            Controls.Add(CreateShortcutBtn);
            Controls.Add(InjectBtn);
            Controls.Add(BrowseBtn);
            Controls.Add(CreditsLabel);
            Controls.Add(DllLabel);
            Controls.Add(DllPathTB);
            Controls.Add(ThemesBtn);
            Controls.Add(ReloadBtn);
            Controls.Add(ThemesFLP);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DLLInjector";
            Text = "Nazi Injector";
            MouseDown += DLLInjector_MouseDown;
            ((System.ComponentModel.ISupportInitialize)TitlePB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ReloadBtn;
        private TextBox DllPathTB;
        private Label DllLabel;
        private Button BrowseBtn;
        private Button InjectBtn;
        private OpenFileDialog OpenDLLDialog;
        private PictureBox TitlePB;
        private Button CloseBtn;
        private Label CreditsLabel;
        private ListView ProcessesLV;
        private ColumnHeader NameCH;
        private ColumnHeader PIDCH;
        private Button ThemesBtn;
        private FlowLayoutPanel ThemesFLP;
        private Button CreateShortcutBtn;
    }
}