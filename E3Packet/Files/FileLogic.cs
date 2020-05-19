using ConnectToE3;
using e3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Packet
{
    public static class FileLogic
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
        public static void RefreshForm(ref CheckedListBox listOpendFiles)
        {
            // Get dictionari of running e3 process
            Dictionary<string, e3Application> e3ProcessDictionary = new Dictionary<string, e3Application>();
            e3ProcessDictionary = AppConnect.GetE3ProcessDictionary();

            RemoveClosedFiles(e3ProcessDictionary, listOpendFiles);

            AddFilesFromProcess(e3ProcessDictionary, listOpendFiles);

            AddBrowsedFiles(listOpendFiles);
            
            listOpendFiles.Refresh();
            listOpendFiles.Size = new Size(100, 100);
        }
        /// <summary>
        /// Adding new files from browsed files to Form
        /// </summary>
        /// <param name="listOpendFiles"></param>
        private static void AddBrowsedFiles(CheckedListBox listOpendFiles)
        {
            foreach (var browsedFilePath in listFileItems)
            {
                if (!listOpendFiles.Items.Contains(browsedFilePath.fullPath))
                {
                    listOpendFiles.Items.Add(browsedFilePath.fullPath, browsedFilePath.ItemChecked ? CheckState.Checked : CheckState.Unchecked);
                }
            }
        }
        /// <summary>
        /// Adding new files from processes to Form
        /// </summary>
        /// <param name="e3ProcessDictionary"></param>
        /// <param name="listOpendFiles"></param>
        private static void AddFilesFromProcess(Dictionary<string, e3Application> e3ProcessDictionary, CheckedListBox listOpendFiles)
        { 
            foreach (var e3Process in e3ProcessDictionary)
            {
                listOpendFiles.Items.Add(e3Process.Key);
                //if (!listFileItems.Contains(new FileItem(e3Process.Key)))
                if (!listFileItems.Any(x => x.fullPath == e3Process.Key))
                {
                    listFileItems.Add(new FileItem(e3Process.Key));
                }
            }
        }
        /// <summary>
        /// Iterate through existing list of files to exclude already opened  
        /// </summary>
        /// <param name="e3ProcessDictionary"></param>
        /// <param name="listOpendFiles"></param>
        private static void RemoveClosedFiles(Dictionary<string, e3Application> e3ProcessDictionary, CheckedListBox listOpendFiles)
        {            
            string[] opendFiles = listOpendFiles.Items.Cast<string>().ToArray();
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
        }

        internal static void RunScripts(e3Application project)
        {
            foreach (ScriptFileItem script in listScriptFileItems.Where(x => x.ItemChecked))
            {
                RunScript(script, project);
            }
        }

        private static void RunScript(ScriptFileItem script, e3Application project)
        {
            project.Run(script.fullPath, "");
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
            if (fileItems != null)
            {
                foreach (var file in fileItems)
                {
                    //Thread e3Thread = new Thread(new ThreadStart(file.Process));
                    //e3Thread.Start();
                    Task e3Task = Task.Run(() =>
                    {
                        Debug.WriteLine("Task={0}, obj={1}, Thread={2}",
                              Task.CurrentId, file.fullPath,
                               Thread.CurrentThread.ManagedThreadId);
                        file.Process();
                    });
                }
            }
        }

        internal static void SetCheckedFiles(CheckedListBox listOpendFiles)
        {
            if (listFileItems != null)
            {
                foreach (var item in listFileItems)
                {
                    item.ItemChecked = false;
                }
                if (listOpendFiles != null)
                {
                    string[] checkedFiles = listOpendFiles.CheckedItems.Cast<string>().ToArray();
                    foreach (var item in checkedFiles)
                    {
                        SetCheckedItem(ref listFileItems, item.ToString());
                    }
                }
            }
        }

        internal static void SetCheckedScripts(CheckedListBox listAvailableScripts)
        {
            if (listScriptFileItems != null)
            {
                foreach (var item in listScriptFileItems)
                {
                    item.ItemChecked = false;
                }
                if (listAvailableScripts != null)
                {
                    foreach (var item in listAvailableScripts.CheckedItems)
                    {
                        SetCheckedItem(ref listScriptFileItems, item.ToString());
                    }
                }
            }
        }

        private static void SetCheckedItem<T>(ref List<T> fileItems, string selectedItem) where T : FolderItem
        {
            foreach (var item in fileItems)
            {
                if (item.fullPath == selectedItem)
                {
                    item.ItemChecked = true;
                }
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
                // if (!listFileItems.Contains(new ScriptFileItem(s, dirName)))
                if (!listFileItems.Any(x => x.fullPath == s) && !listScriptFileItems.Any(x => x.fullPath == s))
                {
                    filePaths.Add(new ScriptFileItem(s, dirName));
                }
            }
            return filePaths;
        }

    }
}
