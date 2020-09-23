﻿// <copyright file="MainForm.Designer.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
// <auto-generated />

namespace DeleteUntilString
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
        	this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.matchedFileToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.matchedfileCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.textStringLabel = new System.Windows.Forms.Label();
        	this.textStringTextBox = new System.Windows.Forms.TextBox();
        	this.fileButton = new System.Windows.Forms.Button();
        	this.directoryButton = new System.Windows.Forms.Button();
        	this.searchPatternLabel = new System.Windows.Forms.Label();
        	this.searchPatternTextBox = new System.Windows.Forms.TextBox();
        	this.backupCheckBox = new System.Windows.Forms.CheckBox();
        	this.subdirectoriesCheckBox = new System.Windows.Forms.CheckBox();
        	this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
        	this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
        	this.processedFileToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.processedFileCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.mainTableLayoutPanel.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.minimizeToolStripMenuItem,
        	        	        	this.fileToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(249, 24);
        	this.mainMenuStrip.TabIndex = 21;
        	// 
        	// minimizeToolStripMenuItem
        	// 
        	this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        	this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
        	this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
        	this.minimizeToolStripMenuItem.Visible = false;
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripMenuItem,
        	        	        	this.toolStripSeparator3,
        	        	        	this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// newToolStripMenuItem
        	// 
        	this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
        	this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        	this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.newToolStripMenuItem.Text = "&New";
        	this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// toolStripSeparator3
        	// 
        	this.toolStripSeparator3.Name = "toolStripSeparator3";
        	this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem,
        	        	        	this.originalThreadDonationCodercomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// dailyReleasesPublicDomainDailycomToolStripMenuItem
        	// 
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Name = "dailyReleasesPublicDomainDailycomToolStripMenuItem";
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Text = "Daily releases @ PublicDomainDaily.com";
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Click += new System.EventHandler(this.OnDailyReleasesPublicDomainDailycomToolStripMenuItemClick);
        	// 
        	// originalThreadDonationCodercomToolStripMenuItem
        	// 
        	this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
        	this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
        	this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
        	this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
        	this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
        	// 
        	// mainStatusStrip
        	// 
        	this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.matchedFileToolStripStatusLabel,
        	        	        	this.matchedfileCountToolStripStatusLabel,
        	        	        	this.processedFileToolStripStatusLabel,
        	        	        	this.processedFileCountToolStripStatusLabel});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 153);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(249, 22);
        	this.mainStatusStrip.SizingGrip = false;
        	this.mainStatusStrip.TabIndex = 20;
        	// 
        	// matchedFileToolStripStatusLabel
        	// 
        	this.matchedFileToolStripStatusLabel.Name = "matchedFileToolStripStatusLabel";
        	this.matchedFileToolStripStatusLabel.Size = new System.Drawing.Size(81, 17);
        	this.matchedFileToolStripStatusLabel.Text = "Matched files:";
        	// 
        	// matchedfileCountToolStripStatusLabel
        	// 
        	this.matchedfileCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.matchedfileCountToolStripStatusLabel.Name = "matchedfileCountToolStripStatusLabel";
        	this.matchedfileCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
        	this.matchedfileCountToolStripStatusLabel.Text = "0";
        	// 
        	// mainTableLayoutPanel
        	// 
        	this.mainTableLayoutPanel.ColumnCount = 2;
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.mainTableLayoutPanel.Controls.Add(this.textStringLabel, 0, 0);
        	this.mainTableLayoutPanel.Controls.Add(this.textStringTextBox, 1, 0);
        	this.mainTableLayoutPanel.Controls.Add(this.fileButton, 0, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.directoryButton, 1, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.searchPatternLabel, 0, 2);
        	this.mainTableLayoutPanel.Controls.Add(this.searchPatternTextBox, 1, 2);
        	this.mainTableLayoutPanel.Controls.Add(this.backupCheckBox, 0, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.subdirectoriesCheckBox, 1, 3);
        	this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
        	this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        	this.mainTableLayoutPanel.RowCount = 4;
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.Size = new System.Drawing.Size(249, 129);
        	this.mainTableLayoutPanel.TabIndex = 22;
        	// 
        	// textStringLabel
        	// 
        	this.textStringLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.textStringLabel.Location = new System.Drawing.Point(3, 0);
        	this.textStringLabel.Name = "textStringLabel";
        	this.textStringLabel.Size = new System.Drawing.Size(118, 25);
        	this.textStringLabel.TabIndex = 0;
        	this.textStringLabel.Text = "Text string:";
        	this.textStringLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// textStringTextBox
        	// 
        	this.textStringTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.textStringTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.textStringTextBox.Location = new System.Drawing.Point(127, 3);
        	this.textStringTextBox.Name = "textStringTextBox";
        	this.textStringTextBox.Size = new System.Drawing.Size(119, 20);
        	this.textStringTextBox.TabIndex = 0;
        	// 
        	// fileButton
        	// 
        	this.fileButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.fileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.fileButton.Location = new System.Drawing.Point(3, 28);
        	this.fileButton.Name = "fileButton";
        	this.fileButton.Size = new System.Drawing.Size(118, 48);
        	this.fileButton.TabIndex = 1;
        	this.fileButton.Text = "&File(s)";
        	this.fileButton.UseVisualStyleBackColor = true;
        	this.fileButton.Click += new System.EventHandler(this.OnFileButtonClick);
        	// 
        	// directoryButton
        	// 
        	this.directoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.directoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.directoryButton.Location = new System.Drawing.Point(127, 28);
        	this.directoryButton.Name = "directoryButton";
        	this.directoryButton.Size = new System.Drawing.Size(119, 48);
        	this.directoryButton.TabIndex = 2;
        	this.directoryButton.Text = "&Directory";
        	this.directoryButton.UseVisualStyleBackColor = true;
        	this.directoryButton.Click += new System.EventHandler(this.OnDirectoryButtonClick);
        	// 
        	// searchPatternLabel
        	// 
        	this.searchPatternLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.searchPatternLabel.Location = new System.Drawing.Point(3, 79);
        	this.searchPatternLabel.Name = "searchPatternLabel";
        	this.searchPatternLabel.Size = new System.Drawing.Size(118, 25);
        	this.searchPatternLabel.TabIndex = 4;
        	this.searchPatternLabel.Text = "&Search pattern:";
        	this.searchPatternLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// searchPatternTextBox
        	// 
        	this.searchPatternTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.searchPatternTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.searchPatternTextBox.Location = new System.Drawing.Point(127, 82);
        	this.searchPatternTextBox.Name = "searchPatternTextBox";
        	this.searchPatternTextBox.Size = new System.Drawing.Size(119, 20);
        	this.searchPatternTextBox.TabIndex = 3;
        	this.searchPatternTextBox.Text = "*.txt";
        	// 
        	// backupCheckBox
        	// 
        	this.backupCheckBox.Checked = true;
        	this.backupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.backupCheckBox.Location = new System.Drawing.Point(3, 107);
        	this.backupCheckBox.Name = "backupCheckBox";
        	this.backupCheckBox.Size = new System.Drawing.Size(104, 19);
        	this.backupCheckBox.TabIndex = 4;
        	this.backupCheckBox.Text = "&Backups";
        	this.backupCheckBox.UseVisualStyleBackColor = true;
        	// 
        	// subdirectoriesCheckBox
        	// 
        	this.subdirectoriesCheckBox.Checked = true;
        	this.subdirectoriesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.subdirectoriesCheckBox.Location = new System.Drawing.Point(127, 107);
        	this.subdirectoriesCheckBox.Name = "subdirectoriesCheckBox";
        	this.subdirectoriesCheckBox.Size = new System.Drawing.Size(104, 19);
        	this.subdirectoriesCheckBox.TabIndex = 5;
        	this.subdirectoriesCheckBox.Text = "&Subdirectories";
        	this.subdirectoriesCheckBox.UseVisualStyleBackColor = true;
        	// 
        	// openFileDialog
        	// 
        	this.openFileDialog.DefaultExt = "txt";
        	this.openFileDialog.Filter = "TXT Files (*.txt)|*.txt|All files (*.*)|*.*";
        	this.openFileDialog.Multiselect = true;
        	this.openFileDialog.Title = "Open file(s)";
        	// 
        	// processedFileToolStripStatusLabel
        	// 
        	this.processedFileToolStripStatusLabel.Name = "processedFileToolStripStatusLabel";
        	this.processedFileToolStripStatusLabel.Size = new System.Drawing.Size(87, 17);
        	this.processedFileToolStripStatusLabel.Text = "Processed files:";
        	// 
        	// processedFileCountToolStripStatusLabel
        	// 
        	this.processedFileCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        	this.processedFileCountToolStripStatusLabel.Name = "processedFileCountToolStripStatusLabel";
        	this.processedFileCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
        	this.processedFileCountToolStripStatusLabel.Text = "0";
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(249, 175);
        	this.Controls.Add(this.mainTableLayoutPanel);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Delete Until String";
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.mainTableLayoutPanel.ResumeLayout(false);
        	this.mainTableLayoutPanel.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripStatusLabel processedFileCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel processedFileToolStripStatusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox subdirectoriesCheckBox;
        private System.Windows.Forms.CheckBox backupCheckBox;
        private System.Windows.Forms.TextBox searchPatternTextBox;
        private System.Windows.Forms.Label searchPatternLabel;
        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.TextBox textStringTextBox;
        private System.Windows.Forms.Label textStringLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel matchedfileCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel matchedFileToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReleasesPublicDomainDailycomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
