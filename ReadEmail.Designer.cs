namespace EmailReader
{
    partial class ReadEmail
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtReadEmail = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.listEmails = new System.Windows.Forms.ListBox();
            this.btnLoadInbox = new System.Windows.Forms.Button();
            this.listAttachments = new System.Windows.Forms.ListBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtReadEmail
            // 
            this.txtReadEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtReadEmail.Location = new System.Drawing.Point(395, 123);
            this.txtReadEmail.Multiline = true;
            this.txtReadEmail.Name = "txtReadEmail";
            this.txtReadEmail.ReadOnly = true;
            this.txtReadEmail.Size = new System.Drawing.Size(368, 129);
            this.txtReadEmail.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSubject.Location = new System.Drawing.Point(397, 93);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PlaceholderText = "Subject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(366, 23);
            this.txtSubject.TabIndex = 3;
            // 
            // txtSender
            // 
            this.txtSender.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSender.Location = new System.Drawing.Point(397, 64);
            this.txtSender.Name = "txtSender";
            this.txtSender.PlaceholderText = "Sender";
            this.txtSender.ReadOnly = true;
            this.txtSender.Size = new System.Drawing.Size(366, 23);
            this.txtSender.TabIndex = 4;
            // 
            // listEmails
            // 
            this.listEmails.FormattingEnabled = true;
            this.listEmails.ItemHeight = 15;
            this.listEmails.Location = new System.Drawing.Point(35, 93);
            this.listEmails.Name = "listEmails";
            this.listEmails.Size = new System.Drawing.Size(199, 274);
            this.listEmails.TabIndex = 5;
            this.listEmails.SelectedIndexChanged += new System.EventHandler(this.listEmails_SelectedIndexChanged);
            // 
            // btnLoadInbox
            // 
            this.btnLoadInbox.Location = new System.Drawing.Point(36, 55);
            this.btnLoadInbox.Name = "btnLoadInbox";
            this.btnLoadInbox.Size = new System.Drawing.Size(75, 23);
            this.btnLoadInbox.TabIndex = 6;
            this.btnLoadInbox.Text = "Load inbox";
            this.btnLoadInbox.UseVisualStyleBackColor = true;
            this.btnLoadInbox.Click += new System.EventHandler(this.btnLoadInbox_Click);
            // 
            // listAttachments
            // 
            this.listAttachments.FormattingEnabled = true;
            this.listAttachments.ItemHeight = 15;
            this.listAttachments.Location = new System.Drawing.Point(397, 273);
            this.listAttachments.Name = "listAttachments";
            this.listAttachments.Size = new System.Drawing.Size(213, 94);
            this.listAttachments.TabIndex = 7;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(627, 307);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.Text = "Save File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // ReadEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.listAttachments);
            this.Controls.Add(this.btnLoadInbox);
            this.Controls.Add(this.listEmails);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtReadEmail);
            this.Controls.Add(this.btnBack);
            this.Name = "ReadEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private TextBox txtReadEmail;
        private TextBox txtSubject;
        private TextBox txtSender;
        private ListBox listEmails;
        private Button btnLoadInbox;
        private ListBox listAttachments;
        private Button btnOpenFile;
    }
}