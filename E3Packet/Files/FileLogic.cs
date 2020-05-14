using ConnectToE3;
using e3;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Packet
{
    public static class  FileLogic
    {        
        //public static Dictionary<string, string> scriptsDictionary = new Dictionary<string, string>();
        /// <summary>
        /// List of loaded scripts
        /// </summary>
        public static List<ScriptFileItem> listScriptFileItems = new List<ScriptFileItem>();
        /// <summary>
        /// List of loaded files
        /// </summary>
        public static List<FileItem> listFileItems = new List<FileItem>();


        /// <summary>
        /// Refresh opend files table in Form
        /// </summary>
        /// <param name="listOpendFiles"> Opend files table </param>
        public static void RefreshForm(CheckedListBox listOpendFiles)
        {
            // Get dictionari of running e3 process
            Dictionary<string, e3Application> e3ProcessDictionary = new Dictionary<string, e3Application>();
            e3ProcessDictionary = AppConnect.GetE3ProcessDictionary();
            // Iterate through existing list of files to exclude already opened  
            CheckedListBox.ObjectCollection opendFiles = listOpendFiles.Items;
            foreach (var opendFile in opendFiles)
            {
                if (e3ProcessDictionary.ContainsKey(opendFile.ToString()))
                {
                    e3ProcessDictionary.Remove(opendFile.ToString());
                }
                else if (listFileItems.Select(x => x.shortFileName).Contains(opendFile.ToString()))
                {

                }
                else
                {
                    listOpendFiles.Items.Remove(opendFile);
                }
            }

            // Adding new files from processes to Form
            foreach (var e3Process in e3ProcessDictionary)
            {
                listOpendFiles.Items.Add(e3Process.Key);
                listFileItems.Add(new FileItem(e3Process.Key));
            }

            // Adding new files from browsed files to Form
            foreach (var browsedFilePath in listFileItems)
            {
                if (!listOpendFiles.Items.Contains(browsedFilePath))
                {
                    listOpendFiles.Items.Add(browsedFilePath);
                }
            }
            listOpendFiles.Refresh();
            listOpendFiles.Size = new Size(100, 100);

            AddSelectedScriptsToFiles();
        }
        /// <summary>
        /// Adding selected in form scripts to selected file objects
        /// </summary>
        public static void AddSelectedScriptsToFiles()
        {
            Изучить Linq https://metanit.com/sharp/tutorial/15.1.php потом применять
            foreach listFileItems.Where(x => x.ItemChecked).ScriptsToExecute = listScriptFileItems.Where(x => x.ItemChecked);
        }

        internal static void RunScripts(e3Application project, List<ScriptFileItem> scriptsToExecute)
        {
            throw new NotImplementedException();
        }

       
        /// <summary>
        /// Load choosed scripts in form 
        /// </summary>
        /// <param name="scriptNames"> Scripts to load </param>
        /// <param name="availableScripts"> List of scripts in Form </param>
        public static void LoadScripts(string[] scriptNames, ref CheckedListBox availableScripts)
        {
            foreach (string file in scriptNames)
            {
                if (!(listScriptFileItems.Any(s => s.fullPath == file)))
                {
                    listScriptFileItems.Add(new ScriptFileItem(file, GlobalConfig.scriptsDirName));
                    availableScripts.Items.Add(listScriptFileItems.LastOrDefault().shortScriptName);
                }
            }
        }

        /// <summary>
        /// Loads files in form
        /// </summary>
        /// <param name="folderName"> Folder from which to load </param>
        public static void LoadFiles(string folderName)
        {
            string extention = "*.e3s";
            listFileItems.AddRange(GetFiles(folderName, extention));
        }

        /// <summary>
        /// Starting Thread to open files and run scripts
        /// </summary>
        /// <param name="fileItems"> Files to open </param>
        public static void RunFile(List<FileItem> fileItems)
        {
            foreach (var file in fileItems)
            {
                Thread e3Thread = new Thread(new ThreadStart(file.Process));
                e3Thread.Start();
            }
        }


       private static List<ScriptFileItem> GetFiles(string dirName, string extention)
        {
            List<ScriptFileItem> filePaths = new List<ScriptFileItem>();
            if (Directory.Exists(dirName))
            {
                filePaths.AddRange(GetSubFiles(dirName, extention));

                Debug.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string dir in dirs)
                {
                    Debug.WriteLine(dir);
                   // listFolderItems.Add(new FolderItem(dir));
                    //listFolderItems.Last().ItemChecked = true;
                    // Do not include this directories
                    // if (listAvailableFolders.CheckedItems.Contains(Path.GetFileName(dir)))
                    if (true)
                    {
                        filePaths.AddRange(GetSubFiles(dir, extention));
                    }
                }
            }
            return filePaths;

        }
        private static List<ScriptFileItem> GetSubFiles(string dirName, string extention)
        {
            List<ScriptFileItem> filePaths = new List<ScriptFileItem>();
            Debug.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(dirName, extention);
            foreach (string s in files)
            {
                Debug.WriteLine(s);
                filePaths.Add(new ScriptFileItem(s, dirName));
            }
            return filePaths;
        }

    }
}
