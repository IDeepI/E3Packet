using ConnectToE3;
using e3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Packet
{
    public static class FileLogic
    {
        public static bool ignoreSelectedIndexChanged = false;
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
        /// Load all Scripts to list and Show Folders
        /// </summary>
        /// <param name="scriptFoldersListBox"></param>
        /// <param name="scriptsListBox"></param>
        internal static void LoadScriptFolder(ref ListBox scriptFoldersListBox, ref ListBox scriptsListBox)
        {
            // Parse all scripts
            LoadScripts(GlobalConfig.scriptsDirName);

            var folderGroups = listScriptFileItems.GroupBy(f => f.DirectoryName).Select(g => g.Key).ToList();

            // Get the current selection mode
            SelectionMode selectionMode = scriptFoldersListBox.SelectionMode;

            // Set the selection mode to none
            scriptFoldersListBox.SelectionMode = SelectionMode.None;

            // Set a new DataSource
            scriptFoldersListBox.DataSource = folderGroups;

            // Set back the original selection mode
            scriptFoldersListBox.SelectionMode = selectionMode; 

            //foreach (var ScriptFile in listScriptFileItems)
            //{
            //    // Add all folders to scriptFoldersListBox
            //    if (!(scriptFoldersListBox.Items.Contains(ScriptFile))) //x => x.fullPath == ScriptFile.fullPath
            //    {
            //       // scriptFoldersListBox.Items.Add((FolderItem)ScriptFile, CheckState.Unchecked);

            //        scriptFoldersListBox.DisplayMember = "directoryName";

            //    }
            //}

            // Add only Scripts with Selected folder
            FillScriptsFromSelectedFolders(scriptFoldersListBox, scriptsListBox);
        }

        /// <summary>
        /// Refresh opend files table in Form
        /// </summary>
        /// <param name="listOpendFiles"> Opend files table </param>
        public static void RefreshForm(ref ListBox listOpendFiles)
        {
            // Get dictionari of running e3 process
            Dictionary<string, e3Application> e3ProcessDictionary = new Dictionary<string, e3Application>();
            e3ProcessDictionary = AppConnect.GetE3ProcessDictionary();

            //RemoveClosedFiles(e3ProcessDictionary, listOpendFiles);

            AddFilesFromProcess(e3ProcessDictionary);

            AddBrowsedFiles(ref listOpendFiles);

            listOpendFiles.Refresh();
            listOpendFiles.Size = new Size(100, 100);
        }

        /// <summary>
        /// Adding new files from browsed files to Form
        /// </summary>
        /// <param name="listOpendFiles"></param>
        public static void AddBrowsedFiles(ref ListBox listOpendFiles)
        {
            // Set a new DataSource
            BindingSource bs = new BindingSource();
            bs.DataSource = listFileItems;
            listOpendFiles.DataSource = bs;
            bs.ResetBindings(false);
        }
        /// <summary>
        /// Adding new files from processes to Form
        /// </summary>
        /// <param name="e3ProcessDictionary"></param>
        /// <param name="listOpendFiles"></param>
        private static void AddFilesFromProcess(Dictionary<string, e3Application> e3ProcessDictionary)
        {
            foreach (var e3Process in e3ProcessDictionary)
            {
                if (!listFileItems.Any(x => x.FullPath == e3Process.Key))
                {
                    listFileItems.Add(new ScriptFileItem(e3Process.Key));
                }
            }
        }

        internal static void FillAvailableScripts(ListBox scriptsToSelectFromListBox)
        {
            // Make DataSource for listbox with Scripts
            var scriptFiles = listScriptFileItems.Where(s => s.ItemSelected).ToList();
            // Set a new DataSource
            scriptsToSelectFromListBox.DataSource = scriptFiles;
        }

        /// <summary>
        /// Iterate through existing list of files to exclude already opened  
        /// </summary>
        /// <param name="e3ProcessDictionary"></param>
        /// <param name="listOpendFiles"></param>
        //private static void RemoveClosedFiles(Dictionary<string, e3Application> e3ProcessDictionary, ListBox listOpendFiles)
        //{
        //    for (int i = 0; i < listOpendFiles.Items.Count; i++)
        //    {
        //        if (e3ProcessDictionary.ContainsKey(listOpendFiles.Items[i].ToString()))
        //        {
        //            e3ProcessDictionary.Remove(listOpendFiles.Items[i].ToString());
        //        }
        //        else if (listFileItems.Select(x => x.fullPath).Contains(listOpendFiles.Items[i].ToString()))
        //        {

        //        }
        //        else
        //        {
        //            //listFileItems.RemoveAt(i);
        //        }
        //    }
        //}

        internal static void FillScriptsFromSelectedFolders(ListBox scriptFoldersListBox, ListBox scriptsListBox)
        {
            if (listScriptFileItems != null)
            {
                // Make DataSource for listbox with Scripts
                var scriptFiles = listScriptFileItems.Where(s => scriptFoldersListBox.SelectedItems.Contains(s.DirectoryName)).ToList();

                ignoreSelectedIndexChanged = true;

                // Set a new DataSource
                scriptsListBox.DataSource = scriptFiles;

                scriptsListBox.SelectedIndex = -1; // This optional line keeps the first item from being selected.                

                if (scriptsListBox.Items.Count > 0)
                {
                    for (int i = 0; i < scriptsListBox.Items.Count; i++)
                    {
                        string selectedItemFullPath = ((ScriptFileItem)scriptsListBox.Items[i]).FullPath;

                        bool selected = (from ScriptFile in listScriptFileItems
                                         where ScriptFile.FullPath == selectedItemFullPath
                                         select ScriptFile.ItemSelected).First();

                        scriptsListBox.SetSelected(i, selected);
                    }
                }

                ignoreSelectedIndexChanged = false;
            }
        }

        internal static void RunScripts(e3Application project, List<string> scriptsListBoxSelectedItems)
        {
            foreach (string script in scriptsListBoxSelectedItems)
            {
                RunScript(script, project);
            }
        }

        private static void RunScript(string script, e3Application project)
        {
            project.Run(script, "");
        }



        /// <summary>
        /// Loads files in form
        /// </summary>
        /// <param name="folderName"> Folder from which to load </param>
        public static void LoadFiles(string folderName, string extention = "*.e3s")
        {
            listFileItems.AddRange(GetFiles(folderName, extention));
        }

        /// <summary>
        /// Loads files in form
        /// </summary>
        /// <param name="folderName"> Folder from which to load </param>
        public static void LoadScripts(string folderName, string extention = "*.vbs")
        {
            listScriptFileItems.AddRange(GetFiles(folderName, extention));
        }

        /// <summary>
        /// Starting Thread to open files and run scripts
        /// </summary>
        /// <param name="SelectedFiles"> Files to open </param>
        public static void RunFile(ListBox selectedFiles, ListBox selectedScripts)
        {
            if (selectedFiles.SelectedItems != null)
            {
                foreach (var file in selectedFiles.SelectedItems)
                {
                    //Thread e3Thread = new Thread(new ThreadStart(file.Process));
                    //e3Thread.Start();

                    string filePath = ((FileItem)file).FullPath;

                    List<string> scriptsToExecute = new List<string>();
                    foreach (ScriptFileItem selectedScript in selectedScripts.SelectedItems)
                    {
                        scriptsToExecute.Add(selectedScript.FullPath);
                    }
                   
                    Task e3Task = Task.Run(() =>
                    {                        
                        Debug.WriteLine("Task={0}, obj={1}, Thread={2}",
                              Task.CurrentId, filePath,
                               Thread.CurrentThread.ManagedThreadId);
                        Process(filePath.ToString(), scriptsToExecute);
                    });
                }
            }
        }

        /// <summary>
        /// Open files and run scripts
        /// </summary>
        private static void Process(string file, List<string> scriptsListBoxSelectedItems)
        {
            // Open File
            e3Application e3App = AppConnect.ToE3(file, out bool quitThenDone);

            if (scriptsListBoxSelectedItems.Count > 0)
            {
                FileLogic.RunScripts(e3App, scriptsListBoxSelectedItems);
            }

            if (quitThenDone)
            {
                e3Job e3Prj = (e3Job)e3App.CreateJobObject();
                e3Prj.Save();
                e3Prj.Close();
                e3App.Quit();
            }
        }

        internal static void SetSelectedFiles(ListBox listOpendFiles)
        {
            if (listFileItems != null)
            {
                foreach (var item in listOpendFiles.Items)
                {
                    SetUnSelectedItem(ref listFileItems, item.ToString());
                }

                if (listOpendFiles != null)
                {
                    var selectedFiles = listOpendFiles.SelectedItems;
                    foreach (var item in selectedFiles)
                    {
                        SetSelectedItem(ref listFileItems, item.ToString());
                    }
                }
            }
        }

        internal static void SetSelectedScripts(ListBox listAvailableScripts)
        {
            if (listScriptFileItems != null && listAvailableScripts != null)
            {                
                // Loop through all items the ListBox.
                for (int x = 0; x < listAvailableScripts.Items.Count; x++)
                {
                    string itemPath = ((ScriptFileItem)listAvailableScripts.Items[x]).FullPath;
                    // Determine if the item is selected.
                    if (listAvailableScripts.GetSelected(x) == true)                        
                        SetSelectedItem(ref listScriptFileItems, itemPath);
                    else
                        SetUnSelectedItem(ref listScriptFileItems, itemPath);
                }

            }
        }

        private static void SetSelectedItem<T>(ref List<T> fileItems, string SelectedItem) where T : FolderItem
        {
            foreach (var item in fileItems)
            {
                if (item.FullPath == SelectedItem)
                {
                    item.ItemSelected = true;
                }
            }
        }
        private static void SetUnSelectedItem<T>(ref List<T> fileItems, string unSelectedItem) where T : FolderItem
        {
            foreach (var item in fileItems)
            {
                if (item.FullPath == unSelectedItem)
                {
                    item.ItemSelected = false;
                }
            }
        }

        private static List<ScriptFileItem> GetFiles(string dirName, string extention)
        {
            List<ScriptFileItem> filePaths = new List<ScriptFileItem>();
            if (Directory.Exists(dirName))
            {
                filePaths.AddRange(GetSubFiles(dirName, extention));

                //Debug.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string dir in dirs)
                {
                   // Debug.WriteLine(dir);

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
            // Debug.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(dirName, extention);
            foreach (string s in files)
            {
               // Debug.WriteLine(s);

                if (!listFileItems.Any(x => x.FullPath == s) 
                    && !listScriptFileItems.Any(x => x.FullPath == s)
                    && s.Substring(0, 1) != "~")
                {
                    filePaths.Add(new ScriptFileItem(s));
                }
            }
            return filePaths;
        }

    }
}
