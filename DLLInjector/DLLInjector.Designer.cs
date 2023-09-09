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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            ReloadBtn.TabIndex = 1;
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
            DllPathTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
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
            BrowseBtn.TabIndex = 4;
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
            pictureBox1.Image = Properties.Resources.TitleImage;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
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
            CloseBtn.TabIndex = 7;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
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
            ProcessesLV.TabIndex = 8;
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
            // DLLInjector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(CloseBtn);
            Controls.Add(ProcessesLV);
            Controls.Add(pictureBox1);
            Controls.Add(InjectBtn);
            Controls.Add(BrowseBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DllPathTB);
            Controls.Add(ReloadBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DLLInjector";
            Text = "Nazi Injector";
            Load += Form1_Load;
            MouseDown += DLLInjector_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}