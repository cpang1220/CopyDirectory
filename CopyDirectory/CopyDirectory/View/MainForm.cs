using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CopyDirectory.Presenter;
using CopyLibrary;
using CopyDomain;

namespace CopyDirectory.View
{
    public partial class MainForm : Form, View.IMainView
    {
        public MainForm()
        {
            InitializeComponent();
            ICopyRepository copyRepo = new FileCopyRepository();
            Presenter.MainPresenter mainPresenter = new Presenter.MainPresenter(copyRepo, this);
            this.Presenter = mainPresenter;

            PreviewHandlerHost previewHandler = new PreviewHandlerHost();
            this.PreviewHandlerHst = previewHandler;
            this.PreviewHandlerHst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewHandlerHst.Location = new System.Drawing.Point(22, 276);
            this.PreviewHandlerHst.Name = "previewHandlerHost";
            this.PreviewHandlerHst.Size = new System.Drawing.Size(766, 292);
            this.PreviewHandlerHst.TabIndex = 13;
            this.PreviewHandlerHst.Text = "previewHandlerHost1";
            this.copyFilePreviewPanel.Controls.Add(this.PreviewHandlerHst);
        }


        private void sourceDirBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.sourceDirTxtBox.Text = this.folderBrowserDialog.SelectedPath;
                
            }
        }

        private void targetDirBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.targetDirTxtBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        public string CopyFileNameText
        {
            get { return copyFileNameTxtBox.Text; }
            set { copyFileNameTxtBox.Text = value; }
        }

        public string CopyFilePathText
        {
            get { return copyFilePathTxtBox.Text; }
            set { copyFilePathTxtBox.Text = value; }
        }

        public MainPresenter Presenter { get; set; }

        public PreviewHandlerHost PreviewHandlerHst { get; set; }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            FileDirectory sourceDir = new FileDirectory();
            sourceDir.Name = new DirectoryInfo(this.sourceDirTxtBox.Text).Name;
            sourceDir.Path = this.sourceDirTxtBox.Text;

            FileDirectory targetDir = new FileDirectory();
            targetDir.Name = new DirectoryInfo(this.targetDirTxtBox.Text).Name;
            targetDir.Path = this.targetDirTxtBox.Text;

            if(this.sourceDirTxtBox.Text != this.targetDirTxtBox.Text)
            {
                Presenter.CopyFilesAction(sourceDir, targetDir);

                MessageBox.Show("Copy files completed");

                this.sourceDirTxtBox.Text = "";
                this.targetDirTxtBox.Text = "";
                this.copyFileNameTxtBox.Text = "";
                this.copyFilePathTxtBox.Text = "";
                PreviewHandlerHst.UnloadPreviewHandler();
            }
            else
            {
                MessageBox.Show("Source Directory File Path cannot be the same as Target Directory File Path");
            }
        }
    }
}
