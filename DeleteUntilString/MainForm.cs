// <copyright file="MainForm.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace DeleteUntilString
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The associated icon.
        /// </summary>
        private Icon associatedIcon;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DeleteUntilString.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set public domain daily tool strip menu item image
            this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Image = this.associatedIcon.ToBitmap();
        }

        /// <summary>
        /// Handles the daily releases public domain dailycom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDailyReleasesPublicDomainDailycomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open current website
            Process.Start("https://publicdomaindaily.com");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread @ DonationCoder
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=47179.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub
            Process.Start("https://github.com/publicdomain");
        }

        /// <summary>
        /// Handles the about tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close application
            this.Close();
        }

        /// <summary>
        /// Handles the file button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFileButtonClick(object sender, EventArgs e)
        {
            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Process files
                    this.ProcessFiles(this.openFileDialog.FileNames.ToList(), this.textStringTextBox.Text);
                }
                catch (Exception exception)
                {
                    // Inform user
                    MessageBox.Show($"Error when processing file{(this.openFileDialog.FileNames.Length > 1 ? "s" : string.Empty)}.{Environment.NewLine}Message: {exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handles the directory button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDirectoryButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Processes the files.
        /// </summary>
        /// <param name="filePathList">File path list.</param>
        /// <param name="textString">Text string.</param>
        private void ProcessFiles(List<string> filePathList, string textString)
        {
            // TODO Add code
        }
    }
}
