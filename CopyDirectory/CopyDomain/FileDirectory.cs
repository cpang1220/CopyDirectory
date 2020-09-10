using System;
using System.Collections.Generic;
using System.Text;

namespace CopyDomain
{
    public class FileDirectory
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public FileDirectory(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public FileDirectory() { }

        public override string ToString()
        {
            return Name;
        }
    }
}
