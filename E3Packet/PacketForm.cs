using System;
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

            listFiles.AutoSize = true;
            listScriptFolders.AutoSize = true;
            listScripts.AutoSize = true;

            listFiles.Sorted = true;
            listScriptFolders.Sorted = true;
            listScripts.Sorted = true;

            listFiles.DisplayMember = "FullPath";
            //listScriptFolders.DisplayMember = "DirectoryName";
            listScripts.DisplayMember = "ShortScriptName";

            listFiles.ValueMember = "fullPath";
            //listScriptFolders.ValueMember = "Name";
            listScripts.ValueMember = "fullPath";

            this.AutoSize = true;
        }

        private void PacketForm_Load(object sender, EventArgs e)
        {
            FileLogic.RefreshForm(ref listFiles);
            for (int i = 0; i < listFiles.Items.Count; i++)
                listFiles.SetSelected(i, true);

            FileLogic.LoadScriptFolder(ref listScriptFolders, ref listScripts);
            FileLogic.SetSelectedFiles(listFiles);
            FileLogic.SetSelectedScripts(listScripts);
        }


        private void PacketForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void BrowseForFiles_Click(object sender, EventArgs e)
        {
            string folderName;

            // choose active project path
            folderName = listFiles?.SelectedItems[0]?.ToString();
            filesBrowserDialog.SelectedPath = Directory.GetParent(folderName ?? GlobalConfig.filesDirName).ToString();
            // Show the FolderBrowserDialog
            DialogResult result = filesBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = filesBrowserDialog.SelectedPath;

                GetFiles(folderName);
            }
        }

        public void GetFiles(string folderName)
        {
            FileLogic.LoadFiles(folderName);

            FileLogic.RefreshForm(ref listFiles);
        }

        /*  private void BrowseForScripts_Click(object sender, EventArgs e)
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
                  FileLogic.LoadScripts(openScriptDialog.FileNames, ref listScripts);
                  FileLogic.RefreshForm(ref listFiles);
              }
          }*/

        private void RunExecution_Click(object sender, EventArgs e)
        {
            // Run selected files            
            FileLogic.RunFile(listFiles.SelectedItems, listScripts.SelectedItems);
        }

        private void CancelExecution_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSeletedFileFolderButton_Click(object sender, EventArgs e)
        {
            string folderName;

            // choose active project path
            string[] folderNameItems = listFiles.SelectedItems.Cast<string>().ToArray();
            foreach (string folderNameItem in folderNameItems)
            {
                folderName = Directory.GetParent(folderNameItem).ToString();
                GetFiles(folderName);
            }
        }



        private void refreshFormButton_Click(object sender, EventArgs e)
        {
            FileLogic.RefreshForm(ref listFiles);
        }

        public void listScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileLogic.ignoreSelectedIndexChanged == false)
            {
                FileLogic.SetSelectedScripts(listScripts);
            }          
        }

        private void listScriptFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileLogic.FillScriptsFromSelectedFolders(listScriptFolders, listScripts);

            FileLogic.RefreshForm(ref listFiles);
            listScripts.Refresh();
            listScripts.Size = new Size(100, 100);
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileLogic.SetSelectedFiles(listFiles);
        }
    }
}
