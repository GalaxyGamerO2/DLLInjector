using DLLInjector.Layouts;
using DLLInjector.Themes;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;

namespace DLLInjector
{
    public partial class DLLInjector : Form
    {

        List<Process> Processes;
        Theme ActiveTheme;
        readonly ThemeManager ThemeManager;

        public DLLInjector()
        {
            InitializeComponent();
            Processes = new();
            ThemeManager = new();
            LoadThemeButtons();
            ReloadProcesses();
            ActiveTheme = new();
            SetTheme(ActiveTheme);
        }

        public void SetTheme(Theme theme)
        {
            ActiveTheme = theme;
            BackColor = Color.FromArgb((int)theme.PrimaryColor);
            BackgroundImage = theme.Background;
            TitlePB.Image = theme.TitleImage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ForeColor = Color.FromArgb((int)theme.ForeColor);

            ApplyThemeRecursive(Controls, theme);
        }

        void LoadThemeButtons()
        {
            ThemesFLP.Controls.Clear();

            for (int i = 0; i < ThemeManager.Themes.Count; i++)
            {
                AddThemeButton(ThemeManager.Themes[i]);
            }
        }

        void AddThemeButton(Theme theme)
        {
            Button themeBtn = new()
            {
                BackColor = Color.FromArgb((int)theme.ButtonColor),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb((int)theme.ForeColor),
                Margin = new Padding(0),
                Name = "ThemeBtn",
                Size = new Size(theme.Name.Length * 10, 23),
                TabIndex = ThemesFLP.Controls.Count,
                Tag = "Theme_Button",
                Text = theme.Name,
                UseVisualStyleBackColor = false
            };

            themeBtn.FlatAppearance.BorderSize = 0;
            themeBtn.Click += (s, e) =>
            {
                SetTheme(theme);
            };
            ThemesFLP.Controls.Add(themeBtn);
        }

        void ApplyThemeRecursive(Control.ControlCollection controls, Theme theme)
        {
            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i].Name == "ThemeBtn") continue;

                LayoutData? layout = theme.LayoutData.First((ld) => { return ld.Name == controls[i].Name; });

                if (layout is not null)
                {
                    controls[i].Location = new(layout.X, layout.Y);
                    controls[i].Size = new(layout.Width, layout.Height);
                }

                switch ((string)controls[i].Tag)
                {
                    case "Theme_SecondaryColor":
                        controls[i].BackColor = Color.FromArgb((int)theme.SecondaryColor);
                        break;
                    case "Theme_Button":
                        controls[i].BackColor = Color.FromArgb((int)theme.ButtonColor);
                        break;
                }

                controls[i].ForeColor = Color.FromArgb((int)theme.ForeColor);
                ApplyThemeRecursive(controls[i].Controls, theme);
            }
        }

        public void ReloadProcesses()
        {
            Processes = Process.GetProcesses().OrderBy(o => o.ProcessName).ToList();
            ProcessesLV.Items.Clear();
            for (int i = 0; i < Processes.Count; i++)
            {
                ProcessesLV.Items.Add(new ListViewItem(new string[] { Processes[i].ProcessName, Processes[i].Id.ToString() }));
            }
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            ReloadProcesses();
        }

        private void InjectBtn_Click(object sender, EventArgs e)
        {
            Audio audio = new();
            if (ProcessesLV.SelectedIndices.Count < 1)
            {
                MessageBox.Show("Select a process first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(DllPathTB.Text))
            {
                MessageBox.Show("The provided DLL does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            (bool, string) injectResult = BasicInject.Inject(Processes[ProcessesLV.SelectedIndices[0]], DllPathTB.Text);

            if (injectResult.Item1)
            {
                audio.Play(ActiveTheme.InjectionSuccessSound, Microsoft.VisualBasic.AudioPlayMode.Background);
                MessageBox.Show(injectResult.Item2, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(injectResult.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            if (OpenDLLDialog.ShowDialog() != DialogResult.OK) return;
            DllPathTB.Text = OpenDLLDialog.FileName;
        }

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool ReleaseCapture();

        private void DLLInjector_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThemesBtn_Click(object sender, EventArgs e)
        {
            ThemesFLP.Visible = !ThemesFLP.Visible;
            ProcessesLV.Visible = !ThemesFLP.Visible;
            ThemesFLP.Enabled = ThemesFLP.Visible;
            ProcessesLV.Enabled = !ThemesFLP.Visible;
        }
    }
}