
namespace BackerUpper
{
    partial class Form1
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblBackup = new System.Windows.Forms.Label();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.txtBackupDir = new System.Windows.Forms.TextBox();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.btnBackupBrowse = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(53, 45);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(81, 20);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source File";
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(12, 87);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(122, 20);
            this.lblBackup.TabIndex = 1;
            this.lblBackup.Text = "Backup Directory";
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(141, 45);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(494, 27);
            this.txtSourceFile.TabIndex = 2;
            // 
            // txtBackupDir
            // 
            this.txtBackupDir.Location = new System.Drawing.Point(140, 87);
            this.txtBackupDir.Name = "txtBackupDir";
            this.txtBackupDir.Size = new System.Drawing.Size(494, 27);
            this.txtBackupDir.TabIndex = 3;
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(652, 45);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnSourceBrowse.TabIndex = 4;
            this.btnSourceBrowse.Text = "Browse";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // btnBackupBrowse
            // 
            this.btnBackupBrowse.Location = new System.Drawing.Point(652, 87);
            this.btnBackupBrowse.Name = "btnBackupBrowse";
            this.btnBackupBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBackupBrowse.TabIndex = 5;
            this.btnBackupBrowse.Text = "Browse";
            this.btnBackupBrowse.UseVisualStyleBackColor = true;
            this.btnBackupBrowse.Click += new System.EventHandler(this.btnBackupBrowse_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(652, 169);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(94, 29);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 262);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnBackupBrowse);
            this.Controls.Add(this.btnSourceBrowse);
            this.Controls.Add(this.txtBackupDir);
            this.Controls.Add(this.txtSourceFile);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.lblSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.TextBox txtBackupDir;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.Button btnBackupBrowse;
        private System.Windows.Forms.Button btnBackup;
    }
}

