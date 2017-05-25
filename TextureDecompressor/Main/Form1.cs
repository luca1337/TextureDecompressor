using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Aiv.Fast2D;

namespace TextureDecompressor.Main
{
    public partial class TextureDecompressor : Form
    {
        private string[]    entryFiles;
        private int         count;
        private const int   progress = 100;
        private const int   step = 1;
        private int         max; 

        public TextureDecompressor()
        {
            InitializeComponent();
            m_hExtensionTextBox.Text    += ".txt";
            m_hFolderTextBox.Text       += "OutputDecompressed";
            WindowRenderer.Init();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog browser = new FolderBrowserDialog())
            {
                DialogResult eRes = browser.ShowDialog();

                if (string.IsNullOrEmpty(m_hFolderTextBox.Text))
                {
                    MessageBox.Show("Folder Name can't be null or empty", 
                        "Invalid Folder Name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(m_hExtensionTextBox.Text))
                {
                    MessageBox.Show("Extension Name can't be null or empty",
                        "Invalid Extension Name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
                                                            "Or CANCEL to abort.", "Path Found!", MessageBoxButtons.OKCancel, 
                                                            MessageBoxIcon.Question);
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
                }
                try
                {
                    foreach (var file in entryFiles)
                    {
                        m_hProgressBar.Step = 1;
                        m_hProgressBar.Maximum = entryFiles.Count();
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
                        File.WriteAllBytes(dirInfo.Name + "/" + singleFileName + "." + m_hExtensionTextBox.Text,
                            texture.Bitmap);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    m_hProgressBar.Value = 0;
                    count = 0;
                }
            }
        }
    }
}
