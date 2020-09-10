using System;
using System.Collections.Generic;
using System.Text;
using CopyLibrary;
using CopyDomain;
using System.IO;
using CopyDirectory.View;
using System.Runtime.CompilerServices;

namespace CopyDirectory.Presenter
{
    public class MainPresenter
    {
        private ICopyRepository copyRepository;
        private View.IMainView mainFormView;

        public MainPresenter(ICopyRepository copyRepository, View.IMainView mainView)
        {
            mainView.Presenter = this;
            this.copyRepository = copyRepository;
            mainFormView = mainView;
        }

        /// <summary>
        /// Handles copy files
        /// </summary>
        public void CopyFilesAction(FileDirectory sourceDir, FileDirectory targetDir)
        {
            DirectoryInfo sourceDirInfo = new DirectoryInfo(sourceDir.Path);
            DirectoryInfo targetDirInfo = new DirectoryInfo(targetDir.Path);

            CopyFiles(sourceDirInfo, targetDirInfo);
        }

        public void CopyFiles(DirectoryInfo sourceDir, DirectoryInfo targetDir)
        {
            if (!Directory.Exists(targetDir.FullName))
            {
                Directory.CreateDirectory(targetDir.FullName);
            }

            ICopyRepository copyRepository = new FileCopyRepository();
            
            foreach (FileInfo file in sourceDir.GetFiles())
            {
                mainFormView.CopyFileNameText = file.Name;
                mainFormView.CopyFilePathText = file.FullName;
                mainFormView.PreviewHandlerHst.Open(file.FullName);
                copyRepository.CopySingleFile(file, targetDir);
                mainFormView.PreviewHandlerHst.UnloadPreviewHandler();
            }

            foreach (DirectoryInfo sourceFileSubDir in sourceDir.GetDirectories())
            {
                DirectoryInfo targetFileSubDir =
                    targetDir.CreateSubdirectory(sourceFileSubDir.Name);
                CopyFiles(sourceFileSubDir, targetFileSubDir);
            }
        }
    }
}
