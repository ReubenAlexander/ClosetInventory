namespace FileMerge
{
    partial class fmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fmListBox = new System.Windows.Forms.ListBox();
            this.fmGetFiles = new System.Windows.Forms.Button();
            this.fmExecBtn = new System.Windows.Forms.Button();
            this.fmResetBoxBtn = new System.Windows.Forms.Button();
            this.fmExitBtn = new System.Windows.Forms.Button();
            this.fmStatusStrip = new System.Windows.Forms.StatusStrip();
            this.fmFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fmSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.fmFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // fmListBox
            // 
            this.fmListBox.FormattingEnabled = true;
            this.fmListBox.Location = new System.Drawing.Point(12, 26);
            this.fmListBox.Name = "fmListBox";
            this.fmListBox.Size = new System.Drawing.Size(366, 342);
            this.fmListBox.TabIndex = 0;
            // 
            // fmGetFiles
            // 
            this.fmGetFiles.Location = new System.Drawing.Point(385, 26);
            this.fmGetFiles.Name = "fmGetFiles";
            this.fmGetFiles.Size = new System.Drawing.Size(75, 23);
            this.fmGetFiles.TabIndex = 1;
            this.fmGetFiles.Text = "Get Files";
            this.fmGetFiles.UseVisualStyleBackColor = true;
            this.fmGetFiles.Click += new System.EventHandler(this.fmGetFiles_Click);
            // 
            // fmExecBtn
            // 
            this.fmExecBtn.Location = new System.Drawing.Point(385, 55);
            this.fmExecBtn.Name = "fmExecBtn";
            this.fmExecBtn.Size = new System.Drawing.Size(75, 23);
            this.fmExecBtn.TabIndex = 2;
            this.fmExecBtn.Text = "Execute";
            this.fmExecBtn.UseVisualStyleBackColor = true;
            this.fmExecBtn.Click += new System.EventHandler(this.fmExecBtn_Click);
            // 
            // fmResetBoxBtn
            // 
            this.fmResetBoxBtn.Location = new System.Drawing.Point(385, 84);
            this.fmResetBoxBtn.Name = "fmResetBoxBtn";
            this.fmResetBoxBtn.Size = new System.Drawing.Size(75, 23);
            this.fmResetBoxBtn.TabIndex = 3;
            this.fmResetBoxBtn.Text = "Reset";
            this.fmResetBoxBtn.UseVisualStyleBackColor = true;
            this.fmResetBoxBtn.Click += new System.EventHandler(this.fmResetBoxBtn_Click);
            // 
            // fmExitBtn
            // 
            this.fmExitBtn.Location = new System.Drawing.Point(385, 343);
            this.fmExitBtn.Name = "fmExitBtn";
            this.fmExitBtn.Size = new System.Drawing.Size(75, 23);
            this.fmExitBtn.TabIndex = 4;
            this.fmExitBtn.Text = "Exit";
            this.fmExitBtn.UseVisualStyleBackColor = true;
            this.fmExitBtn.Click += new System.EventHandler(this.fmExitBtn_Click);
            // 
            // fmStatusStrip
            // 
            this.fmStatusStrip.Location = new System.Drawing.Point(0, 369);
            this.fmStatusStrip.Name = "fmStatusStrip";
            this.fmStatusStrip.Size = new System.Drawing.Size(472, 22);
            this.fmStatusStrip.TabIndex = 5;
            this.fmStatusStrip.Text = "fmStatusStrip";
            // 
            // fmFileDialog
            // 
            this.fmFileDialog.DefaultExt = "txt";
            this.fmFileDialog.Filter = "\"Text files|*.txt|CSV files|*.csv";
            this.fmFileDialog.Multiselect = true;
            // 
            // fmSaveDialog
            // 
            this.fmSaveDialog.DefaultExt = "txt";
            this.fmSaveDialog.Filter = "Text File | *.txt";
            this.fmSaveDialog.RestoreDirectory = true;
            this.fmSaveDialog.Title = "Select files to merge";
            // 
            // fmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 391);
            this.Controls.Add(this.fmStatusStrip);
            this.Controls.Add(this.fmExitBtn);
            this.Controls.Add(this.fmResetBoxBtn);
            this.Controls.Add(this.fmExecBtn);
            this.Controls.Add(this.fmGetFiles);
            this.Controls.Add(this.fmListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Merge Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fmListBox;
        private System.Windows.Forms.Button fmGetFiles;
        private System.Windows.Forms.Button fmExecBtn;
        private System.Windows.Forms.Button fmResetBoxBtn;
        private System.Windows.Forms.Button fmExitBtn;
        private System.Windows.Forms.StatusStrip fmStatusStrip;
        private System.Windows.Forms.OpenFileDialog fmFileDialog;
        private System.Windows.Forms.SaveFileDialog fmSaveDialog;
        private System.Windows.Forms.FolderBrowserDialog fmFolderBrowserDialog;
    }
}

