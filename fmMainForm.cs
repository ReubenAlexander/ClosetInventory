using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileMerge
{
    public partial class fmMainForm : Form
    {
        private List<string> fileNameList;        

        public fmMainForm()
        {
            InitializeComponent();
        }

        private void fmGetFiles_Click(object sender, EventArgs e)
        {
            DialogResult dr = fmFileDialog.ShowDialog();
            fileNameList = new List<string>();

            try
            {
                if (dr == DialogResult.OK)
                {
                    foreach(string file in fmFileDialog.FileNames)
                    {
                        fileNameList.Add(file);
                    }

                    listFiles(fileNameList);
                    MessageBox.Show("Files added successfully", "Files added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occurred:\n" + ex.Message, "Error loading files", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fmResetBoxBtn_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void fmExecBtn_Click(object sender, EventArgs e)
        {
            if (fmListBox.Items.Count <= 1)
            {
                MessageBox.Show("Please select two or more files to merge \nbefore clicking \"Execute\".", "No files to merge",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    const int chunkSize = 2 * 1024;

                    DialogResult ds = fmSaveDialog.ShowDialog();

                    if (ds == DialogResult.OK)
                    {
                        using (var outputFile = File.Create(fmSaveDialog.FileName))
                        {
                            foreach (string file in fileNameList)
                            {
                                using (var input = File.OpenRead(file))
                                {
                                    var buff = new byte[chunkSize];
                                    int bytesRead;

                                    while ((bytesRead = input.Read(buff, 0, buff.Length)) > 0)
                                    {
                                        outputFile.Write(buff, 0, bytesRead);
                                    }
                                }
                            }
                        }

                        MessageBox.Show("Files merged successfully.", "Merge Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid output directory for the merged file.",
                            "Select valid output path", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occurred: " + ex.Message, "Error whilst merging files",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void fmExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listFiles(List<string> fileNames)
        {
            for(int i = 0; i < fileNames.Count - 1; i++)
            {
                fmListBox.Items.Add(fileNames[i]);
            }            
        }

        private void resetAll()
        {
            fmListBox.Items.Clear();

            if(fmFileDialog.FileNames.Length > 0)
            {
                fmFileDialog = new OpenFileDialog();
            }
        }
        
    }
}
