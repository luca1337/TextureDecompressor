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

namespace TextureDecompressor
{
    public partial class Form1 : Form
    {
        private string[] entryFiles;

        public Form1()
        {
            InitializeComponent();
            m_hExtensionTextBox.Text += ".txt";
            m_hFolderTextBox.Text += "OutputDecompressed";
            WindowRenderer.Init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog browser = new FolderBrowserDialog())
            {
                DialogResult eRes = browser.ShowDialog();

                if (eRes == DialogResult.OK && !string.IsNullOrWhiteSpace(browser.SelectedPath))
                {
                    entryFiles = Directory.GetFiles(browser.SelectedPath);
                    DirectoryInfo dirInfo = Directory.CreateDirectory(m_hFolderTextBox.Text);

                    foreach (var path in entryFiles)
                    {
                        string files = Path.GetFileName(path);
                        m_hListBox.Items.Add(files);
                    }


                    //try
                    //{
                    //    foreach (var file in entryFiles)
                    //    {
                    //        Texture texture = new Texture(file);
                    //        string singleFileName = Path.GetFileNameWithoutExtension(file);
                    //        File.WriteAllBytes(dirInfo.Name + "/" + singleFileName + "." + m_hExtensionTextBox.Text, texture.Bitmap);
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}
                }
            }
        }

        private void m_hListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
