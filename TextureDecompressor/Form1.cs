using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aiv.Fast2D;
using System.Diagnostics;

namespace TextureDecompressor
{
    public partial class Form1 : Form
    {
        private string[]    entryFiles;
        private int         count;
        private const int   progress = 100;
        private const int   step = 1;
        private int         max; 

        public Form1()
        {
            InitializeComponent();
            m_hExtensionTextBox.Text    += @".txt";
            m_hFolderTextBox.Text       += @"OutputDecompressed";
            WindowRenderer.Init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog browser = new FolderBrowserDialog())
            {
                DialogResult eRes = browser.ShowDialog();


                if (eRes != DialogResult.OK || string.IsNullOrWhiteSpace(browser.SelectedPath)) return;
                entryFiles = Directory.GetFiles(browser.SelectedPath);
                DirectoryInfo dirInfo = Directory.CreateDirectory(m_hFolderTextBox.Text);


                foreach (var path in entryFiles)
                {
                    count++;
                    if(count == entryFiles.Length)
                    {
                        count = 0;
                        DialogResult eres = MessageBox.Show("All files are now selected\n" +
                                                            "Do you want to decompress them?\n" +
                                                            "Press OK to compute decompression\n" +
                                                            "Or CANCEL to abort.", "Path Found!", 
                                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        switch (eres)
                        {
                            case DialogResult.OK:
                                continue;
                            case DialogResult.Cancel:
                                Process.GetCurrentProcess().Kill();
                                break;
                        }
                    }
                    string files = Path.GetFileName(path);
                    m_hLabelCount.Text = m_hListBox.Items.Count.ToString();
                    m_hListBox.Items.Add(files);
                    m_hLabelCount.TextChanged += M_hLabelCount_TextChanged;
                }
                try
                {
                    if (string.IsNullOrEmpty(m_hExtensionLabel.Text))
                        MessageBox.Show("Extension can't be null or empty!",
                            "Invalid Extension!", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                    if (string.IsNullOrEmpty(m_hFolderTextBox.Text))
                        MessageBox.Show("Folder name can't be null or empty",
                            "Invalid Folder Name!", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                    foreach (string file in entryFiles)
                    {
                        m_hProgressBar.Step = 1;
                        m_hProgressBar.Maximum = entryFiles.Length;
                        max = m_hProgressBar.Value++;


                        if (max + 1 == entryFiles.Length)
                        {
                            MessageBox.Show("All files have been decompressed\n" +
                                            "You can find them inside\nBin\\Debug", 
                                            "Decompression Finished!", MessageBoxButtons.OK, 
                                            MessageBoxIcon.Information);
                            max = 0;
                        }

                        Texture texture = new Texture(file);
                        string singleFileName = Path.GetFileNameWithoutExtension(file);
                        File.WriteAllBytes(dirInfo.Name + "/" + singleFileName + "." + m_hExtensionTextBox.Text, texture.Bitmap);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void M_hLabelCount_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void m_hListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
