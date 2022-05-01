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

namespace BackerUpper
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            worker.DoWork += Worker_DoWork;
        }

        void BackupFile(string source, string destination)
        {
            FileStream fsIn = new FileStream(source, FileMode.Open);
            FileStream fsOut = new FileStream(destination, FileMode.Create);
            byte[] b = new byte[1048756];
            int readByte;

            while ((readByte = fsIn.Read(b, 0, b.Length)) > 0)
            {
                fsOut.Write(b, 0, readByte);
            }

            fsIn.Close();
            fsOut.Close();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackupFile(txtSourceFile.Text, txtBackupDir.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSourceBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if(o.ShowDialog() == DialogResult.OK)
            {
                txtSourceFile.Text = o.FileName;
            }
        }

        private void btnBackupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtBackupDir.Text = Path.Combine(fbd.SelectedPath, Path.GetFileName(txtSourceFile.Text));
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }
    }
}
