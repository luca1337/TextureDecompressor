namespace TextureDecompressor
{
    partial class TextureDecompressor
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextureDecompressor));
            this.button1 = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.m_hExtensionTextBox = new System.Windows.Forms.TextBox();
            this.m_hExtensionLabel = new System.Windows.Forms.Label();
            this.m_hFolderLabel = new System.Windows.Forms.Label();
            this.m_hFolderTextBox = new System.Windows.Forms.TextBox();
            this.m_hListBox = new System.Windows.Forms.ListView();
            this.m_hLabelCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_hProgressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(166, 107);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(106, 46);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.Browse_Click);
            // 
            // m_hExtensionTextBox
            // 
            this.m_hExtensionTextBox.Location = new System.Drawing.Point(157, 24);
            this.m_hExtensionTextBox.Name = "m_hExtensionTextBox";
            this.m_hExtensionTextBox.Size = new System.Drawing.Size(121, 19);
            this.m_hExtensionTextBox.TabIndex = 1;
            // 
            // m_hExtensionLabel
            // 
            this.m_hExtensionLabel.AutoSize = true;
            this.m_hExtensionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.m_hExtensionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_hExtensionLabel.Location = new System.Drawing.Point(13, 27);
            this.m_hExtensionLabel.Name = "m_hExtensionLabel";
            this.m_hExtensionLabel.Size = new System.Drawing.Size(91, 13);
            this.m_hExtensionLabel.TabIndex = 2;
            this.m_hExtensionLabel.Text = "New Extension";
            // 
            // m_hFolderLabel
            // 
            this.m_hFolderLabel.AutoSize = true;
            this.m_hFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_hFolderLabel.Location = new System.Drawing.Point(13, 69);
            this.m_hFolderLabel.Name = "m_hFolderLabel";
            this.m_hFolderLabel.Size = new System.Drawing.Size(107, 13);
            this.m_hFolderLabel.TabIndex = 3;
            this.m_hFolderLabel.Text = "New Folder Name";
            // 
            // m_hFolderTextBox
            // 
            this.m_hFolderTextBox.Location = new System.Drawing.Point(157, 64);
            this.m_hFolderTextBox.Name = "m_hFolderTextBox";
            this.m_hFolderTextBox.Size = new System.Drawing.Size(121, 19);
            this.m_hFolderTextBox.TabIndex = 4;
            // 
            // m_hListBox
            // 
            this.m_hListBox.Location = new System.Drawing.Point(307, 24);
            this.m_hListBox.Name = "m_hListBox";
            this.m_hListBox.Size = new System.Drawing.Size(344, 224);
            this.m_hListBox.TabIndex = 5;
            this.m_hListBox.UseCompatibleStateImageBehavior = false;
            this.m_hListBox.View = System.Windows.Forms.View.List;
            // 
            // m_hLabelCount
            // 
            this.m_hLabelCount.AutoSize = true;
            this.m_hLabelCount.Location = new System.Drawing.Point(122, 125);
            this.m_hLabelCount.Name = "m_hLabelCount";
            this.m_hLabelCount.Size = new System.Drawing.Size(0, 13);
            this.m_hLabelCount.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Files Count:";
            // 
            // m_hProgressBar
            // 
            this.m_hProgressBar.Location = new System.Drawing.Point(19, 216);
            this.m_hProgressBar.Name = "m_hProgressBar";
            this.m_hProgressBar.Size = new System.Drawing.Size(253, 23);
            this.m_hProgressBar.Step = 1;
            this.m_hProgressBar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Progress";
            // 
            // TextureDecompressor
            // 
            this.ClientSize = new System.Drawing.Size(664, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_hProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_hLabelCount);
            this.Controls.Add(this.m_hListBox);
            this.Controls.Add(this.m_hFolderTextBox);
            this.Controls.Add(this.m_hFolderLabel);
            this.Controls.Add(this.m_hExtensionLabel);
            this.Controls.Add(this.m_hExtensionTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 299);
            this.Name = "TextureDecompressor";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox m_hExtensionTextBox;
        private System.Windows.Forms.Label m_hExtensionLabel;
        private System.Windows.Forms.Label m_hFolderLabel;
        private System.Windows.Forms.TextBox m_hFolderTextBox;
        private System.Windows.Forms.ListView m_hListBox;
        private System.Windows.Forms.Label m_hLabelCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar m_hProgressBar;
        private System.Windows.Forms.Label label2;
    }
}

