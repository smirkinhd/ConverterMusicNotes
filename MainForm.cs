using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AudioDecoder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private static string filePath { get; set; }
        private static string folderPath { get; set; }
        private void selectAudioBtn_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                
                Filter = "(*.mp3)|*.mp3"
            };
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
        }

        private string arguments = $"-i \"{filePath}\" -o \"{folderPath}\"";

        private void PythonScript()
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = false
            };
        }

        private void downloadTracksBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Выберите папку";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folderPath = folderDialog.SelectedPath;
                }
            }

            PythonScript();
        }
    }
}
