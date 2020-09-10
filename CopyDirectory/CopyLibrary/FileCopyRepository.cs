using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CopyDomain;

namespace CopyLibrary
{
    public class FileCopyRepository : ICopyRepository
    {
        public FileCopyRepository()
        {
        }

        public void Copy(FileDirectory sourceDir, FileDirectory targetDir)
        {
            DirectoryInfo sourceDirInfo = new DirectoryInfo(sourceDir.Path);
            DirectoryInfo targetDirInfo = new DirectoryInfo(targetDir.Path);

            CopyFiles(sourceDirInfo, targetDirInfo);
        }

        public static void CopyFiles(DirectoryInfo sourceDir, DirectoryInfo targetDir)
        {
            if (!Directory.Exists(targetDir.FullName))
            {
                Directory.CreateDirectory(targetDir.FullName);
            }
                
            foreach (FileInfo file in sourceDir.GetFiles())
            {             
                file.CopyTo(Path.Combine(targetDir.FullName, file.Name), true);
            }

            foreach (DirectoryInfo sourceFileSubDir in sourceDir.GetDirectories())
            {
                DirectoryInfo targetFileSubDir =
                    targetDir.CreateSubdirectory(sourceFileSubDir.Name);
                CopyFiles(sourceFileSubDir, targetFileSubDir);
            }
        }

        public void CopySingleFile(FileInfo file, DirectoryInfo targetDir)
        {

            file.CopyTo(Path.Combine(targetDir.FullName, file.Name), true);
        }
    }
}
