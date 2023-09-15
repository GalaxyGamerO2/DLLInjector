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
            label1 = new Label();
            BrowseBtn = new Button();
            InjectBtn = new Button();
            OpenDLLDialog = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            CloseBtn = new Button();
            label2 = new Label();
            ProcessesLV = new ListView();
            NameCH = new ColumnHeader();
            PIDCH = new ColumnHeader();
            ThemesBtn = new Button();
            ThemesFLP = new FlowLayoutPanel();
            ThemeDefaultBtn = new Button();
            ThemeBlackRedBtn = new Button();
            ThemeBlueRedBtn = new Button();
            ThemeNaziCordBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ThemesFLP.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "DLL:";
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.Image = Properties.Resources.TitleImage;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "Theme_Title";
            pictureBox1.MouseDown += DLLInjector_MouseDown;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(520, 419);
            label2.Name = "label2";
            label2.Size = new Size(187, 15);
            label2.TabIndex = 3;
            label2.Text = "Made by discord@galaxygamero2";
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
            ThemesFLP.Controls.Add(ThemeDefaultBtn);
            ThemesFLP.Controls.Add(ThemeBlackRedBtn);
            ThemesFLP.Controls.Add(ThemeBlueRedBtn);
            ThemesFLP.Controls.Add(ThemeNaziCordBtn);
            ThemesFLP.Enabled = false;
            ThemesFLP.Location = new Point(174, 415);
            ThemesFLP.Margin = new Padding(0);
            ThemesFLP.Name = "ThemesFLP";
            ThemesFLP.Size = new Size(340, 23);
            ThemesFLP.TabIndex = 9;
            ThemesFLP.Visible = false;
            // 
            // ThemeDefaultBtn
            // 
            ThemeDefaultBtn.BackColor = Color.FromArgb(32, 32, 32);
            ThemeDefaultBtn.FlatAppearance.BorderSize = 0;
            ThemeDefaultBtn.FlatStyle = FlatStyle.Flat;
            ThemeDefaultBtn.ForeColor = Color.White;
            ThemeDefaultBtn.Location = new Point(0, 0);
            ThemeDefaultBtn.Margin = new Padding(0);
            ThemeDefaultBtn.Name = "ThemeDefaultBtn";
            ThemeDefaultBtn.Size = new Size(75, 23);
            ThemeDefaultBtn.TabIndex = 1;
            ThemeDefaultBtn.Tag = "Theme_Button";
            ThemeDefaultBtn.Text = "Default";
            ThemeDefaultBtn.UseVisualStyleBackColor = false;
            ThemeDefaultBtn.Click += ThemeDefaultBtn_Click;
            // 
            // ThemeBlackRedBtn
            // 
            ThemeBlackRedBtn.BackColor = Color.FromArgb(32, 32, 32);
            ThemeBlackRedBtn.FlatAppearance.BorderSize = 0;
            ThemeBlackRedBtn.FlatStyle = FlatStyle.Flat;
            ThemeBlackRedBtn.ForeColor = Color.White;
            ThemeBlackRedBtn.Location = new Point(75, 0);
            ThemeBlackRedBtn.Margin = new Padding(0);
            ThemeBlackRedBtn.Name = "ThemeBlackRedBtn";
            ThemeBlackRedBtn.Size = new Size(75, 23);
            ThemeBlackRedBtn.TabIndex = 2;
            ThemeBlackRedBtn.Tag = "Theme_Button";
            ThemeBlackRedBtn.Text = "Black Red";
            ThemeBlackRedBtn.UseVisualStyleBackColor = false;
            ThemeBlackRedBtn.Click += ThemeBlackRedBtn_Click;
            // 
            // ThemeBlueRedBtn
            // 
            ThemeBlueRedBtn.BackColor = Color.FromArgb(32, 32, 32);
            ThemeBlueRedBtn.FlatAppearance.BorderSize = 0;
            ThemeBlueRedBtn.FlatStyle = FlatStyle.Flat;
            ThemeBlueRedBtn.ForeColor = Color.White;
            ThemeBlueRedBtn.Location = new Point(150, 0);
            ThemeBlueRedBtn.Margin = new Padding(0);
            ThemeBlueRedBtn.Name = "ThemeBlueRedBtn";
            ThemeBlueRedBtn.Size = new Size(75, 23);
            ThemeBlueRedBtn.TabIndex = 3;
            ThemeBlueRedBtn.Tag = "Theme_Button";
            ThemeBlueRedBtn.Text = "Blue Red";
            ThemeBlueRedBtn.UseVisualStyleBackColor = false;
            ThemeBlueRedBtn.Click += ThemeBlueRedBtn_Click;
            // 
            // ThemeNaziCordBtn
            // 
            ThemeNaziCordBtn.BackColor = Color.FromArgb(32, 32, 32);
            ThemeNaziCordBtn.FlatAppearance.BorderSize = 0;
            ThemeNaziCordBtn.FlatStyle = FlatStyle.Flat;
            ThemeNaziCordBtn.ForeColor = Color.White;
            ThemeNaziCordBtn.Location = new Point(225, 0);
            ThemeNaziCordBtn.Margin = new Padding(0);
            ThemeNaziCordBtn.Name = "ThemeNaziCordBtn";
            ThemeNaziCordBtn.Size = new Size(75, 23);
            ThemeNaziCordBtn.TabIndex = 4;
            ThemeNaziCordBtn.Tag = "Theme_Button";
            ThemeNaziCordBtn.Text = "Nazicord";
            ThemeNaziCordBtn.UseVisualStyleBackColor = false;
            ThemeNaziCordBtn.Click += ThemeNaziCordBtn_Click;
            // 
            // DLLInjector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(ThemesFLP);
            Controls.Add(CloseBtn);
            Controls.Add(ProcessesLV);
            Controls.Add(pictureBox1);
            Controls.Add(InjectBtn);
            Controls.Add(BrowseBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DllPathTB);
            Controls.Add(ThemesBtn);
            Controls.Add(ReloadBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DLLInjector";
            Text = "Nazi Injector";
            Load += Form1_Load;
            MouseDown += DLLInjector_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ThemesFLP.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ReloadBtn;
        private TextBox DllPathTB;
        private Label label1;
        private Button BrowseBtn;
        private Button InjectBtn;
        private OpenFileDialog OpenDLLDialog;
        private PictureBox pictureBox1;
        private Button CloseBtn;
        private Label label2;
        private ListView ProcessesLV;
        private ColumnHeader NameCH;
        private ColumnHeader PIDCH;
        private Button ThemesBtn;
        private FlowLayoutPanel ThemesFLP;
        private Button ThemeDefaultBtn;
        private Button ThemeBlackRedBtn;
        private Button ThemeBlueRedBtn;
        private Button ThemeNaziCordBtn;
    }
}