namespace ArmchairCoder.TimeLapseTool
{
    partial class TimelapseForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ListBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.removeImageButton = new System.Windows.Forms.Button();
            this.clearImageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frameRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(421, 297);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "&Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // imageList
            // 
            this.imageList.FormattingEnabled = true;
            this.imageList.HorizontalScrollbar = true;
            this.imageList.Location = new System.Drawing.Point(13, 43);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(298, 212);
            this.imageList.TabIndex = 2;
            this.imageList.SelectedIndexChanged += new System.EventHandler(this.imageList_SelectedIndexChanged);
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(13, 261);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(75, 23);
            this.addImageButton.TabIndex = 3;
            this.addImageButton.Text = "&Add";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // removeImageButton
            // 
            this.removeImageButton.Enabled = false;
            this.removeImageButton.Location = new System.Drawing.Point(95, 261);
            this.removeImageButton.Name = "removeImageButton";
            this.removeImageButton.Size = new System.Drawing.Size(75, 23);
            this.removeImageButton.TabIndex = 4;
            this.removeImageButton.Text = "&Remove Image";
            this.removeImageButton.UseVisualStyleBackColor = true;
            this.removeImageButton.Click += new System.EventHandler(this.removeImageButton_Click);
            // 
            // clearImageButton
            // 
            this.clearImageButton.Enabled = false;
            this.clearImageButton.Location = new System.Drawing.Point(236, 261);
            this.clearImageButton.Name = "clearImageButton";
            this.clearImageButton.Size = new System.Drawing.Size(75, 23);
            this.clearImageButton.TabIndex = 5;
            this.clearImageButton.Text = "&C&lear";
            this.clearImageButton.UseVisualStyleBackColor = true;
            this.clearImageButton.Click += new System.EventHandler(this.clearImageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected Images";
            // 
            // imageCountLabel
            // 
            this.imageCountLabel.AutoSize = true;
            this.imageCountLabel.Location = new System.Drawing.Point(16, 303);
            this.imageCountLabel.Name = "imageCountLabel";
            this.imageCountLabel.Size = new System.Drawing.Size(99, 13);
            this.imageCountLabel.TabIndex = 7;
            this.imageCountLabel.Text = "No images selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Frame rate";
            // 
            // frameRate
            // 
            this.frameRate.Location = new System.Drawing.Point(331, 60);
            this.frameRate.Name = "frameRate";
            this.frameRate.Size = new System.Drawing.Size(39, 21);
            this.frameRate.TabIndex = 9;
            this.frameRate.Text = "15";
            this.frameRate.TextChanged += new System.EventHandler(this.frameRate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "(1 - 60)";
            // 
            // TimelapseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frameRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearImageButton);
            this.Controls.Add(this.removeImageButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.startButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimelapseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Lapse Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox imageList;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Button removeImageButton;
        private System.Windows.Forms.Button clearImageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label imageCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frameRate;
        private System.Windows.Forms.Label label3;
    }
}