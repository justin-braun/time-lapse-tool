// Copyright © 2015-2016 Armchair Coder Software (http://armchaircoder.com).
// This program is distributed under the terms of the GNU General Public License.

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArmchairCoder.TimeLapseTool.Helpers;

namespace ArmchairCoder.TimeLapseTool
{
    public partial class TimelapseForm : Form
    {
        public TimelapseForm()
        {
            InitializeComponent();
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "JPG image (*.jpg)|*.jpg";
            ofDialog.Multiselect = true;
            ofDialog.ShowDialog();

            if (ofDialog.FileNames.Length > 0)
            {
                foreach (string file in ofDialog.FileNames)
                {
                    imageList.Items.Add(file.ToString());
                }

                clearImageButton.Enabled = true;
            }

            UpdateImageCount();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {

            try
            {
                string[] imageItems = new string[imageList.Items.Count];
                imageList.Items.CopyTo(imageItems, 0);

                SaveFileDialog sfDialog = new SaveFileDialog();
                sfDialog.Filter = "AVI file (*.avi)|*.avi";
                sfDialog.ShowDialog();

                if (sfDialog.FileName == "")
                    return;

                this.Cursor = Cursors.WaitCursor;
                await Task.Run(() => VideoHelper.CreateTimeLapse(sfDialog.FileName, 640, 480, int.Parse(frameRate.Text), false,
                    imageItems));

                this.Cursor = Cursors.Default;
                //LogHelper.WriteLogEntry("Time Lapse created successfully.", LogHelper.LogEntryType.Information);
                MessageBox.Show("Time lapse created successfully.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("An error occurred generating the time lapse. " + ex.Message + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }


        }

        private void removeImageButton_Click(object sender, EventArgs e)
        {
            imageList.Items.Remove(imageList.SelectedItem);

            if (imageList.Items.Count > 0)
                imageList.SelectedIndex = imageList.Items.Count - 1;

            UpdateImageCount();
        }

        private void clearImageButton_Click(object sender, EventArgs e)
        {
            // Clear image list
            imageList.Items.Clear();
            UpdateImageCount();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close
            this.Close();
        }

        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateImageCount();

        }

        private void UpdateImageCount()
        {
            int _updateInt = 0;

            // Update count label
            if (imageList.Items.Count == 0)
            {
                // no images in the list
                imageCountLabel.Text = "No images selected";
                removeImageButton.Enabled = false;
                clearImageButton.Enabled = false;
                //startButton.Enabled = false;
            }
            else
            {
                // there are images in the list
                imageCountLabel.Text = imageList.Items.Count + " image(s) selected";
                removeImageButton.Enabled = true;
                clearImageButton.Enabled = true;
                //startButton.Enabled = true;
            }

            if (string.IsNullOrEmpty(frameRate.Text)  || (int.TryParse(frameRate.Text, out _updateInt) == false))
            {
                startButton.Enabled = false;
                return;
            }

            if (imageList.Items.Count == 0)
            {
                startButton.Enabled = false;
                return;
            }

            startButton.Enabled = true;
        }

        private void frameRate_TextChanged(object sender, EventArgs e)
        {
            UpdateImageCount();
        }
    }
}
