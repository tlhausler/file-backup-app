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
        // instantiate backgroundworker that will handle file operations
        BackgroundWorker worker = new BackgroundWorker();
        public Form1()
        {
            // initialize component and set its DoWork starting point to the Worker_DoWork method
            InitializeComponent();
            worker.DoWork += Worker_DoWork;
        }

        void BackupFile(string source, string destination)
        {
            // open file stream for both input and output.
            FileStream fsIn = new FileStream(source, FileMode.Open);
            FileStream fsOut = new FileStream(destination, FileMode.Create);
            byte[] b = new byte[1048756];
            int readByte;

            // instruct filestream output to write information from the input
            while ((readByte = fsIn.Read(b, 0, b.Length)) > 0)
            {
                fsOut.Write(b, 0, readByte);
            }

            // close filestream operations
            fsIn.Close();
            fsOut.Close();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // call the BackupFile method and pass it the source and destination paths
            BackupFile(txtSourceFile.Text, txtBackupDir.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSourceBrowse_Click(object sender, EventArgs e)
        {
            // instantiate a file dialog box for the browse button to choose file to backup
            OpenFileDialog o = new OpenFileDialog();
            if(o.ShowDialog() == DialogResult.OK)
            {
                txtSourceFile.Text = o.FileName;
            }
        }

        private void btnBackupBrowse_Click(object sender, EventArgs e)
        {
            // instantiate folder browser dialog box to select folder location to save selected file to
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtBackupDir.Text = Path.Combine(fbd.SelectedPath, Path.GetFileName(txtSourceFile.Text));
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            // have the backgroundworker perform the copy
            worker.RunWorkerAsync();
        }
    }
}
