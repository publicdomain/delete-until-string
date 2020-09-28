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
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;
    using PublicDomain;

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
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"Computer keys icon by gustavofer74 - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/computer-keys-pc-delete-me-644457/{Environment.NewLine}{Environment.NewLine}" +
                $"Patreon icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.patreon.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version 
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: nkormanik{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #271, Week #39 @ September 27, 2020",
                licenseText,
                this.Icon.ToBitmap())
            {

                // Set about form icon
                Icon = this.associatedIcon
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Clear text string
            this.textStringTextBox.Clear();

            // Reset counters
            this.matchedfileCountToolStripStatusLabel.Text = "0";
            this.processedFileCountToolStripStatusLabel.Text = "0";

            // Reset search pattern
            this.searchPatternTextBox.Text = "*.txt";

            // Reset check boxes
            this.backupCheckBox.Checked = true;
            this.subdirectoriesCheckBox.Checked = true;

            // Focus text string field
            this.textStringTextBox.Focus();
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
            // Show open file dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Collect file path list
                    List<string> filePathList = Directory.GetFiles(this.folderBrowserDialog.SelectedPath, this.searchPatternTextBox.Text, this.subdirectoriesCheckBox.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).ToList();

                    // Process files
                    this.ProcessFiles(filePathList, this.textStringTextBox.Text);
                }
                catch (Exception exception)
                {
                    // Inform user
                    MessageBox.Show($"Error when processing file{(this.openFileDialog.FileNames.Length > 1 ? "s" : string.Empty)}.{Environment.NewLine}Message: {exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Processes the files.
        /// </summary>
        /// <param name="filePathList">File path list.</param>
        /// <param name="textString">Text string.</param>
        private void ProcessFiles(List<string> filePathList, string textString)
        {
            // TODO Some checks can be done before collecting file path list, yet it would be per separate button

            // Check there is a text string
            if (textString.Length == 0)
            {
                // Advise user
                MessageBox.Show("A text string is required!", "Input", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Halt flow
                return;
            }

            // Declare processed file count
            int processedFileCount = 0;

            // Iterate files
            foreach (var filePath in filePathList)
            {
                // Read file to string
                string fileContents = File.ReadAllText(filePath);

                // Set text string position
                int textStringPosition = fileContents.IndexOf(textString, StringComparison.InvariantCulture);

                // Check there is something to work with
                if (textStringPosition > -1)
                {
                    // Delete until string
                    fileContents = fileContents.Substring(textStringPosition);

                    // Check if must backup
                    if (this.backupCheckBox.Checked)
                    {
                        // Create backup file
                        File.Copy(filePath, Path.Combine(Path.GetDirectoryName(filePath), $"{Path.GetFileNameWithoutExtension(filePath)}-backup{Path.GetExtension(filePath)}"));
                    }

                    // Write new contents to disk
                    File.WriteAllText(filePath, fileContents);

                    // Increase processed file count
                    processedFileCount++;
                }
            }

            // Set labels
            this.matchedfileCountToolStripStatusLabel.Text = filePathList.Count.ToString();
            this.processedFileCountToolStripStatusLabel.Text = processedFileCount.ToString();

            // Inform user
            MessageBox.Show($"Matched files: {filePathList.Count}{Environment.NewLine}{Environment.NewLine}Processed files: {processedFileCount}", "Results");
        }
    }
}
