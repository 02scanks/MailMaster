namespace MailMaster
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.sendAllCheckBox = new System.Windows.Forms.CheckBox();
            this.messageField = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.subjectField = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.attachFileButton = new System.Windows.Forms.Button();
            this.refreshClientList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.attachedFileDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(3, 31);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(121, 21);
            this.userComboBox.TabIndex = 0;
            // 
            // sendAllCheckBox
            // 
            this.sendAllCheckBox.AutoSize = true;
            this.sendAllCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendAllCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.sendAllCheckBox.Location = new System.Drawing.Point(3, 290);
            this.sendAllCheckBox.Name = "sendAllCheckBox";
            this.sendAllCheckBox.Size = new System.Drawing.Size(128, 17);
            this.sendAllCheckBox.TabIndex = 1;
            this.sendAllCheckBox.Text = "Send To All Users";
            this.sendAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // messageField
            // 
            this.messageField.Location = new System.Drawing.Point(12, 97);
            this.messageField.Name = "messageField";
            this.messageField.Size = new System.Drawing.Size(454, 253);
            this.messageField.TabIndex = 2;
            this.messageField.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(3, 313);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(121, 44);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.removeUserToolStripMenuItem});
            this.usersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.usersToolStripMenuItem.Text = "Clients";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUserToolStripMenuItem.Text = "Add Client";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeUserToolStripMenuItem.Text = "Remove Client";
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.recipientLabel.Location = new System.Drawing.Point(3, 12);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(77, 16);
            this.recipientLabel.TabIndex = 5;
            this.recipientLabel.Text = "Recipient:";
            // 
            // subjectField
            // 
            this.subjectField.Location = new System.Drawing.Point(12, 55);
            this.subjectField.Name = "subjectField";
            this.subjectField.Size = new System.Drawing.Size(454, 20);
            this.subjectField.TabIndex = 6;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(13, 36);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(55, 16);
            this.subjectLabel.TabIndex = 7;
            this.subjectLabel.Text = "Subject:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(12, 78);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(67, 16);
            this.messageLabel.TabIndex = 8;
            this.messageLabel.Text = "Message:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.attachFileButton);
            this.panel1.Controls.Add(this.refreshClientList);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.userComboBox);
            this.panel1.Controls.Add(this.recipientLabel);
            this.panel1.Controls.Add(this.sendButton);
            this.panel1.Controls.Add(this.sendAllCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(472, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 369);
            this.panel1.TabIndex = 9;
            // 
            // attachFileButton
            // 
            this.attachFileButton.Location = new System.Drawing.Point(3, 244);
            this.attachFileButton.Name = "attachFileButton";
            this.attachFileButton.Size = new System.Drawing.Size(121, 23);
            this.attachFileButton.TabIndex = 8;
            this.attachFileButton.Text = "Attach File";
            this.attachFileButton.UseVisualStyleBackColor = true;
            this.attachFileButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // refreshClientList
            // 
            this.refreshClientList.Location = new System.Drawing.Point(3, 58);
            this.refreshClientList.Name = "refreshClientList";
            this.refreshClientList.Size = new System.Drawing.Size(121, 24);
            this.refreshClientList.TabIndex = 7;
            this.refreshClientList.Text = "Refresh Clients";
            this.refreshClientList.UseVisualStyleBackColor = true;
            this.refreshClientList.Click += new System.EventHandler(this.refreshClientList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MailMaster.Properties.Resources.email;
            this.pictureBox1.Location = new System.Drawing.Point(-38, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // attachedFileDisplay
            // 
            this.attachedFileDisplay.Enabled = false;
            this.attachedFileDisplay.Location = new System.Drawing.Point(12, 361);
            this.attachedFileDisplay.Name = "attachedFileDisplay";
            this.attachedFileDisplay.ReadOnly = true;
            this.attachedFileDisplay.Size = new System.Drawing.Size(272, 20);
            this.attachedFileDisplay.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Attached File";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(605, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attachedFileDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.subjectField);
            this.Controls.Add(this.messageField);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Text = "MailMaster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.CheckBox sendAllCheckBox;
        private System.Windows.Forms.RichTextBox messageField;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.Label recipientLabel;
        private System.Windows.Forms.TextBox subjectField;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button refreshClientList;
        private System.Windows.Forms.Button attachFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox attachedFileDisplay;
        private System.Windows.Forms.Label label1;
    }
}

