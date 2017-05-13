namespace TextureDecompressor
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.m_hExtensionTextBox = new System.Windows.Forms.TextBox();
            this.m_hExtensionLabel = new System.Windows.Forms.Label();
            this.m_hFolderLabel = new System.Windows.Forms.Label();
            this.m_hFolderTextBox = new System.Windows.Forms.TextBox();
            this.m_hListBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // m_hExtensionTextBox
            // 
            this.m_hExtensionTextBox.Location = new System.Drawing.Point(157, 24);
            this.m_hExtensionTextBox.Name = "m_hExtensionTextBox";
            this.m_hExtensionTextBox.Size = new System.Drawing.Size(121, 22);
            this.m_hExtensionTextBox.TabIndex = 1;
            // 
            // m_hExtensionLabel
            // 
            this.m_hExtensionLabel.AutoSize = true;
            this.m_hExtensionLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_hExtensionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_hExtensionLabel.Location = new System.Drawing.Point(13, 27);
            this.m_hExtensionLabel.Name = "m_hExtensionLabel";
            this.m_hExtensionLabel.Size = new System.Drawing.Size(113, 17);
            this.m_hExtensionLabel.TabIndex = 2;
            this.m_hExtensionLabel.Text = "New Extension";
            // 
            // m_hFolderLabel
            // 
            this.m_hFolderLabel.AutoSize = true;
            this.m_hFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_hFolderLabel.Location = new System.Drawing.Point(13, 69);
            this.m_hFolderLabel.Name = "m_hFolderLabel";
            this.m_hFolderLabel.Size = new System.Drawing.Size(135, 17);
            this.m_hFolderLabel.TabIndex = 3;
            this.m_hFolderLabel.Text = "New Folder Name";
            // 
            // m_hFolderTextBox
            // 
            this.m_hFolderTextBox.Location = new System.Drawing.Point(157, 64);
            this.m_hFolderTextBox.Name = "m_hFolderTextBox";
            this.m_hFolderTextBox.Size = new System.Drawing.Size(121, 22);
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
            this.m_hListBox.SelectedIndexChanged += new System.EventHandler(this.m_hListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(664, 260);
            this.Controls.Add(this.m_hListBox);
            this.Controls.Add(this.m_hFolderTextBox);
            this.Controls.Add(this.m_hFolderLabel);
            this.Controls.Add(this.m_hExtensionLabel);
            this.Controls.Add(this.m_hExtensionTextBox);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox m_hExtensionTextBox;
        private System.Windows.Forms.Label m_hExtensionLabel;
        private System.Windows.Forms.Label m_hFolderLabel;
        private System.Windows.Forms.TextBox m_hFolderTextBox;
        private System.Windows.Forms.ListView m_hListBox;
    }
}

