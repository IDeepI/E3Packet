using ConnectToE3;
using e3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3Packet
{
    public class FolderItem
    {
        /// <summary>
        /// Path to Item
        /// </summary>
        public string fullPath;
        /// <summary>
        /// Name of upper dirrectory
        /// </summary>
        public string directoryName;
        /// <summary>
        /// True if item selected
        /// </summary>
        public bool ItemChecked { get; set; }

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
        public string shortFileName;
        public FileItem(string path) : base(path)
        {
        }
        /// <summary>
        /// File data.
        /// </summary>
        /// <param name="path">Full path</param>
        /// <param name="scriptsDirName">Exclude it from shortFileName</param>
        public FileItem(string path, string scriptsDirName) : base(path)
        {
            this.shortFileName = directoryName + Path.GetFileName(scriptsDirName);
        }

        /// <summary>
        /// Open files and run scripts
        /// </summary>
        internal void Process()
        {
            // Open File
            e3Application project = AppConnect.ToE3(fullPath, out bool quitThenDone);
            if (ScriptsToExecute != null)
            {
                FileLogic.RunScripts(project, ScriptsToExecute);
            }
           
            if (quitThenDone)
            {
                project.Quit();
            }
        }

        public List<ScriptFileItem> ScriptsToExecute { get; set; }
       
    }
    public class ScriptFileItem : FileItem
    {
        /// <summary>
        /// Name to use in List
        /// </summary>
        public string shortScriptName;

        /// <summary>
        /// Script File Data
        /// </summary>
        /// <param name="path">Full path</param>
        /// <param name="scriptsDirName">Exclude it from shortFileName</param>
        public ScriptFileItem(string path, string scriptsDirName) : base(path)
        {
            this.shortScriptName = path.Replace(scriptsDirName, "");
        }
    }
}
