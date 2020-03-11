using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ffpeg_to_mp4
{
    public partial class Form1 : Form
    {
        private string pathFolder = "";
        private string pathFolderSave = "";
        private List<string> files;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var open = new FolderBrowserDialog())
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    tFolderFile.Text = open.SelectedPath;
                    pathFolder = open.SelectedPath;
                    files = new List<string>(Directory.GetFiles(open.SelectedPath, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".webm")).ToList());
                    tFiles.Text = $"Files: {files.Count}";
                    tProgress.Maximum = files.Count;
                    AddFiles();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (var open = new FolderBrowserDialog())
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    tFolderSave.Text = open.SelectedPath;
                    pathFolderSave = open.SelectedPath;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (tFolderFile.Text != String.Empty)
            {
                if (tFolderSave.Text != String.Empty)
                {
                    if (files != null)
                    {
                        Thread th = new Thread(Convert);
                        th.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Select folder save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select folder file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Convert()
        {
            int succes = 0;
            foreach (var file in files)
            {
                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "ffmpeg.exe",
                    Arguments = $"-i {file} {pathFolderSave}\\{Path.GetFileName(file).Replace("webm", "mp4")}",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                });
                process.WaitForExit();
                
                Invoke((Action) (() =>
                {
                    listView1.Items[succes].SubItems[2].Text = "Success";
                    listView1.Items[succes].ForeColor = Color.SeaGreen;
                }));
                succes++;
                Invoke((Action)(() =>
                {
                    tSuccess.Text = $"Success: {succes}";
                    tProgress.Value++;
                    tLeft.Text = $"Left: {(files.Count - succes)}";
                }));
            }

            MessageBox.Show("Done :)");
        }

        private void AddFiles()
        {
            if (files != null)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem((i + 1).ToString());
                    lvi.SubItems.Add(files[i]);
                    lvi.SubItems.Add("Waiting...");
                    lvi.ForeColor = Color.Black;
                    listView1.Items.Add(lvi);
                }
            }
        }
    }
}
