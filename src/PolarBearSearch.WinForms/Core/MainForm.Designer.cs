namespace Core
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UploadButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(12, 487);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(397, 69);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(974, 452);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(589, 487);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(373, 69);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 568);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.UploadButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button UploadButton;
        private PictureBox PictureBox;
        private Button Save;
    }
}