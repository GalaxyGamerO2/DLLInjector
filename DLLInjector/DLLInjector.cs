using DLLInjector.Properties;
using DLLInjector.Themes;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;

namespace DLLInjector
{
    public partial class DLLInjector : Form
    {

        readonly List<Theme> Themes = new()
        {
            new(),
            new BlackRed(),
            new BlueRed(),
            new NaziCord(),
        };

        List<Process> Processes;

        public DLLInjector()
        {
            InitializeComponent();
            Processes = new();
            ReloadProcesses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetTheme(new());
        }

        public void SetTheme(Theme theme)
        {
            BackColor = theme.PrimaryColor;
            BackgroundImage = theme.Background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ForeColor = theme.ForeColor;

            ApplyThemeRecursive(Controls, theme);
        }

        void ApplyThemeRecursive(Control.ControlCollection controls, Theme theme)
        {
            for (int i = 0; i < controls.Count; i++)
            {
                switch ((string)controls[i].Tag)
                {
                    case "Theme_SecondaryColor":
                        controls[i].BackColor = theme.SecondaryColor;
                        break;
                    case "Theme_Button":
                        controls[i].BackColor = theme.ButtonColor;
                        break;
                }

                controls[i].ForeColor = theme.ForeColor;
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

            if(!File.Exists(DllPathTB.Text))
            {
                MessageBox.Show("The provided DLL does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            (bool, string) injectResult = BasicInject.Inject(Processes[ProcessesLV.SelectedIndices[0]], DllPathTB.Text);

            if (injectResult.Item1)
            {
                audio.Play(Resources.AufDerHeide, Microsoft.VisualBasic.AudioPlayMode.Background);
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
            ThemesFLP.Enabled = ThemesFLP.Visible;
        }

        private void ThemeDefaultBtn_Click(object sender, EventArgs e)
        {
            SetTheme(new());
        }

        private void ThemeBlackRedBtn_Click(object sender, EventArgs e)
        {
            SetTheme(new BlackRed());
        }

        private void ThemeBlueRedBtn_Click(object sender, EventArgs e)
        {
            SetTheme(new BlueRed());
        }

        private void ThemeNaziCordBtn_Click(object sender, EventArgs e)
        {
            SetTheme(new NaziCord());
        }
    }
}