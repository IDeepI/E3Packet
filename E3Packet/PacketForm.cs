using ConnectToE3;
using e3;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace E3Packet
{
    public partial class PacketForm : Form
    {                
        public PacketForm()
        {
            InitializeComponent();
        }

        private void PacketForm_Load(object sender, EventArgs e)
        {
            FileLogic.RefreshForm(listOpendFiles);
            for (int i = 0; i < listOpendFiles.Items.Count; i++)
                listOpendFiles.SetItemCheckState(i, CheckState.Checked);

            listOpendFiles.AutoSize = true;
            listAvailableScripts.AutoSize = true;

            listOpendFiles.Sorted = true;
            listAvailableScripts.Sorted = true;
            

            this.AutoSize = true;
           // GetScriptDictionary();
          //  listAvailableScripts.Items.AddRange(listScriptFileItems.Select(x => x.shortScriptName).ToArray());
            
        }
        /*private void GetScriptDictionary()
        {
            string extention = "*.vbs";
            foreach (string fileScriptName in GetFiles(scriptsDirName, extention))
            {
                listAvailableScripts.Items.Add(fileScriptName.Replace(scriptsDirName, ""));
            }
            //listAvailableScripts.Items.AddRange(GetFiles(dirName, extention));
        }*/
        private void GetScriptDictionary()
        {
          //  string extention = "*.vbs";
           // listScriptFileItems.AddRange(GetFiles(scriptsDirName, extention));
        }

        /* private string[] GetFiles(string dirName, string extention)
        {
            List<string> filePaths = new List<string>();
            if (Directory.Exists(dirName))
            {
                filePaths.AddRange(GetSubFiles(dirName, extention));

                Debug.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string dir in dirs)
                {
                    Debug.WriteLine(dir);
                    listAvailibleFolders.Items.Insert(0, dir.Replace(scriptsDirName, ""));
                    listAvailibleFolders.SetItemCheckState(0, CheckState.Checked);
                    // Do not include this directories
                    if (listAvailibleFolders.CheckedItems.Contains(Path.GetFileName(dir)))
                    {
                        filePaths.AddRange(GetSubFiles(dir, extention));
                    }
                }
                listAvailibleFolders.Sorted = true;
            }
            return filePaths.ToArray();
            
        }
        private string[] GetSubFiles(string dirName, string extention)
        {
            List<string> filePaths = new List<string>();
            Debug.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(dirName, extention);
            foreach (string s in files)
            {
                Debug.WriteLine(s);
                filePaths.Add(s);
            }
            return filePaths.ToArray();
        }*/

       
        private void PacketForm_MouseMove(object sender, MouseEventArgs e)
        {
            FileLogic.RefreshForm(listOpendFiles);
        }

        private void BrowseForFiles_Click(object sender, EventArgs e)
        {
            string folderName;           

            /////////////////////////////////////////////// Got to choose active project path!!!
            filesBrowserDialog.SelectedPath = GlobalConfig.filesDirName;
            // Show the FolderBrowserDialog
            DialogResult result = filesBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = filesBrowserDialog.SelectedPath;

                FileLogic.LoadFiles(folderName);

                FileLogic.RefreshForm(listOpendFiles);
            }
        }

        private void BrowseForScripts_Click(object sender, EventArgs e)
        {
            openScriptDialog.Filter = "Scripts (*.vbs;*.exe)|*.vbs;*.exe";
            openScriptDialog.Multiselect = true;
            openScriptDialog.InitialDirectory = GlobalConfig.scriptsDirName;
            
            openScriptDialog.FilterIndex = 2;
            openScriptDialog.RestoreDirectory = true;

            // Show the FolderBrowserDialog
            DialogResult result = openScriptDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileLogic.LoadScripts(openScriptDialog.FileNames, ref listAvailableScripts);
                FileLogic.RefreshForm(listOpendFiles);                
            }
        }

        private void RunExecution_Click(object sender, EventArgs e)
        {
            // Run selected files
            FileLogic.RunFile(FileLogic.listFileItems.Where(x => x.ItemChecked).ToList());
        }
    }
}
