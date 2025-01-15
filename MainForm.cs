using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioDecoder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string filePath { get; set; }
        private byte[] fileContent { get; set; }
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

        private void downloadTracksBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
