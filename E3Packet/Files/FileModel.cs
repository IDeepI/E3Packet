using ConnectToE3;
using e3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Packet
{
    public class FolderItem
    {
        /// <summary>
        /// Path to Item
        /// </summary>
        private string fullPath;
        public string FullPath { 
            get 
            {
                return fullPath;
            }
        }
        /// <summary>
        /// Name of upper dirrectory
        /// </summary>
        private string directoryName;
        public string DirectoryName {
            get
            {
                return directoryName;
            }
        }
        /// <summary>
        /// True if item selected
        /// </summary>
        public bool ItemSelected { get; set; }

        public FolderItem() : this("Неизвестно")
        {
        }
        public FolderItem(string path) 
        {
            this.fullPath = path;
            if (Path.HasExtension(path)) {
                this.directoryName = Path.GetFileName(Path.GetDirectoryName(path));
            }
            else
            {
                this.directoryName = Path.GetFileName(path);
            }  
        }
    }
    public class FileItem : FolderItem
    {
        /// <summary>
        /// Name to use in List
        /// </summary>
        private string shortFileName;
        public string ShortFileName
        {
            get
            {
                return shortFileName;
            }
        }       
        /// <summary>
        /// File data.
        /// </summary>
        /// <param name="path">Full path</param>
        /// <param name="scriptsDirName">Exclude it from shortFileName</param>
        public FileItem(string path) : base(path)
        {
            this.shortFileName = Path.GetFileName(path);
        }       
    }
    public class ScriptFileItem : FileItem
    {
        /// <summary>
        /// Name to use in List
        /// </summary>
        private string shortScriptName;
        public string ShortScriptName
        {
            get
            {
                return shortScriptName;
            }
        }
        /// <summary>
        /// Script File Data
        /// </summary>
        /// <param name="path">Full path</param>
        /// <param name="scriptsDirName">Exclude it from shortFileName</param>
        public ScriptFileItem(string path) : base(path)
        {
            this.shortScriptName = Path.GetFileNameWithoutExtension(path);
        }
    }
}
