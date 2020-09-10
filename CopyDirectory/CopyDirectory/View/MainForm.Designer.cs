
namespace CopyDirectory.View
{
    partial class MainForm
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
            this.sourceDirLabel = new System.Windows.Forms.Label();
            this.targetDirLabel = new System.Windows.Forms.Label();
            this.sourceDirTxtBox = new System.Windows.Forms.TextBox();
            this.targetDirTxtBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.sourceDirBtn = new System.Windows.Forms.Button();
            this.targetDirBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.copyFilePreviewPanel = new System.Windows.Forms.Panel();
            this.copyFilePathLabel = new System.Windows.Forms.Label();
            this.copyFileNameLabel = new System.Windows.Forms.Label();
            this.copyFilePathTxtBox = new System.Windows.Forms.TextBox();
            this.copyFileNameTxtBox = new System.Windows.Forms.TextBox();
            this.copyFilePreviewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceDirLabel
            // 
            this.sourceDirLabel.AutoSize = true;
            this.sourceDirLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sourceDirLabel.Location = new System.Drawing.Point(22, 38);
            this.sourceDirLabel.Name = "sourceDirLabel";
            this.sourceDirLabel.Size = new System.Drawing.Size(195, 23);
            this.sourceDirLabel.TabIndex = 0;
            this.sourceDirLabel.Text = "Source File Directory";
            // 
            // targetDirLabel
            // 
            this.targetDirLabel.AutoSize = true;
            this.targetDirLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.targetDirLabel.Location = new System.Drawing.Point(22, 89);
            this.targetDirLabel.Name = "targetDirLabel";
            this.targetDirLabel.Size = new System.Drawing.Size(189, 23);
            this.targetDirLabel.TabIndex = 1;
            this.targetDirLabel.Text = "Target File Directory";
            // 
            // sourceDirTxtBox
            // 
            this.sourceDirTxtBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sourceDirTxtBox.Location = new System.Drawing.Point(223, 38);
            this.sourceDirTxtBox.Name = "sourceDirTxtBox";
            this.sourceDirTxtBox.ReadOnly = true;
            this.sourceDirTxtBox.Size = new System.Drawing.Size(451, 25);
            this.sourceDirTxtBox.TabIndex = 2;
            // 
            // targetDirTxtBox
            // 
            this.targetDirTxtBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.targetDirTxtBox.Location = new System.Drawing.Point(223, 89);
            this.targetDirTxtBox.Name = "targetDirTxtBox";
            this.targetDirTxtBox.ReadOnly = true;
            this.targetDirTxtBox.Size = new System.Drawing.Size(451, 25);
            this.targetDirTxtBox.TabIndex = 3;
            // 
            // sourceDirBtn
            // 
            this.sourceDirBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sourceDirBtn.Location = new System.Drawing.Point(680, 36);
            this.sourceDirBtn.Name = "sourceDirBtn";
            this.sourceDirBtn.Size = new System.Drawing.Size(88, 30);
            this.sourceDirBtn.TabIndex = 4;
            this.sourceDirBtn.Text = "Browse";
            this.sourceDirBtn.UseVisualStyleBackColor = true;
            this.sourceDirBtn.Click += new System.EventHandler(this.sourceDirBtn_Click);
            // 
            // targetDirBtn
            // 
            this.targetDirBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.targetDirBtn.Location = new System.Drawing.Point(680, 85);
            this.targetDirBtn.Name = "targetDirBtn";
            this.targetDirBtn.Size = new System.Drawing.Size(88, 30);
            this.targetDirBtn.TabIndex = 5;
            this.targetDirBtn.Text = "Browse";
            this.targetDirBtn.UseVisualStyleBackColor = true;
            this.targetDirBtn.Click += new System.EventHandler(this.targetDirBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyBtn.Location = new System.Drawing.Point(22, 127);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(118, 39);
            this.copyBtn.TabIndex = 6;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // copyFilePreviewPanel
            // 
            this.copyFilePreviewPanel.Location = new System.Drawing.Point(22, 276);
            this.copyFilePreviewPanel.Name = "copyFilePreviewPanel";
            this.copyFilePreviewPanel.Size = new System.Drawing.Size(766, 292);
            this.copyFilePreviewPanel.TabIndex = 7;
            // 
            // copyFilePathLabel
            // 
            this.copyFilePathLabel.AutoSize = true;
            this.copyFilePathLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyFilePathLabel.Location = new System.Drawing.Point(22, 197);
            this.copyFilePathLabel.Name = "copyFilePathLabel";
            this.copyFilePathLabel.Size = new System.Drawing.Size(103, 17);
            this.copyFilePathLabel.TabIndex = 8;
            this.copyFilePathLabel.Text = "Copy File Path";
            // 
            // copyFileNameLabel
            // 
            this.copyFileNameLabel.AutoSize = true;
            this.copyFileNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyFileNameLabel.Location = new System.Drawing.Point(22, 229);
            this.copyFileNameLabel.Name = "copyFileNameLabel";
            this.copyFileNameLabel.Size = new System.Drawing.Size(112, 17);
            this.copyFileNameLabel.TabIndex = 9;
            this.copyFileNameLabel.Text = "Copy File Name";
            // 
            // copyFilePathTxtBox
            // 
            this.copyFilePathTxtBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyFilePathTxtBox.Location = new System.Drawing.Point(151, 192);
            this.copyFilePathTxtBox.Name = "copyFilePathTxtBox";
            this.copyFilePathTxtBox.ReadOnly = true;
            this.copyFilePathTxtBox.Size = new System.Drawing.Size(617, 25);
            this.copyFilePathTxtBox.TabIndex = 10;
            // 
            // copyFileNameTxtBox
            // 
            this.copyFileNameTxtBox.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyFileNameTxtBox.Location = new System.Drawing.Point(151, 223);
            this.copyFileNameTxtBox.Name = "copyFileNameTxtBox";
            this.copyFileNameTxtBox.ReadOnly = true;
            this.copyFileNameTxtBox.Size = new System.Drawing.Size(617, 25);
            this.copyFileNameTxtBox.TabIndex = 11;
            // 
            // copyFilePreviewLabel
            // 
            this.copyFilePreviewLabel.AutoSize = true;
            this.copyFilePreviewLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyFilePreviewLabel.Location = new System.Drawing.Point(22, 256);
            this.copyFilePreviewLabel.Name = "copyFilePreviewLabel";
            this.copyFilePreviewLabel.Size = new System.Drawing.Size(125, 17);
            this.copyFilePreviewLabel.TabIndex = 12;
            this.copyFilePreviewLabel.Text = "Copy File Preview";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.copyFilePreviewLabel);
            this.Controls.Add(this.copyFileNameTxtBox);
            this.Controls.Add(this.copyFilePathTxtBox);
            this.Controls.Add(this.copyFileNameLabel);
            this.Controls.Add(this.copyFilePathLabel);
            this.Controls.Add(this.copyFilePreviewPanel);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.targetDirBtn);
            this.Controls.Add(this.sourceDirBtn);
            this.Controls.Add(this.targetDirTxtBox);
            this.Controls.Add(this.sourceDirTxtBox);
            this.Controls.Add(this.targetDirLabel);
            this.Controls.Add(this.sourceDirLabel);
            this.Name = "MainForm";
            this.Text = "CopyDirectory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourceDirLabel;
        private System.Windows.Forms.Label targetDirLabel;
        private System.Windows.Forms.TextBox sourceDirTxtBox;
        private System.Windows.Forms.TextBox targetDirTxtBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button sourceDirBtn;
        private System.Windows.Forms.Button targetDirBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Panel copyFilePreviewPanel;
        private System.Windows.Forms.Label copyFilePathLabel;
        private System.Windows.Forms.Label copyFileNameLabel;
        private System.Windows.Forms.TextBox copyFilePathTxtBox;
        private System.Windows.Forms.TextBox copyFileNameTxtBox;
        private System.Windows.Forms.Label copyFilePreviewLabel;
        private PreviewHandlerHost previewHandlerHost;
    }
}