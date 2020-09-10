using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CopyDomain;

namespace CopyLibrary
{
    public interface ICopyRepository
    {
        /// <summary>
        /// Copy multiple files
        /// </summary>
        /// <param name="sourceDir">The source file directory</param>
        /// <param name="targetDir">The target file directory</param>
        void Copy(FileDirectory sourceDir, FileDirectory targetDir);

        /// <summary>
        /// Copy single file
        /// </summary>
        /// <param name="sourceDir">The source file directory</param>
        /// <param name="targetDir">The target file directory</param>
        void CopySingleFile(FileInfo file, DirectoryInfo targetDir);
    }
}
