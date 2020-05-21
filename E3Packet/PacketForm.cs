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

            filesListBox.AutoSize = true;
            scriptsToSelectFromListBox.AutoSize = true;
           
            filesListBox.Sorted = true;
            scriptsToSelectFromListBox.Sorted = true;
            

            filesListBox.DisplayMember = "FullPath";
            scriptsToSelectFromListBox.DisplayMember = "ShortScriptName";

            filesListBox.ValueMember = "FullPath";
            scriptsToSelectFromListBox.ValueMember = "FullPath";

            this.AutoSize = true;
        }

        private void PacketForm_Load(object sender, EventArgs e)
        {
            FileLogic.RefreshForm(ref filesListBox);            

            for (int i = 0; i < filesListBox.Items.Count; i++)
                filesListBox.SetSelected(i, true);

            FileLogic.SetSelectedFiles(filesListBox);

            SelectAvailableScripts();
        }

        private void PacketForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void BrowseForFiles_Click(object sender, EventArgs e)
        {
            string folderName;

            // choose active project path
            folderName = ((FileItem)(filesListBox.SelectedItems[0]))?.FullPath;
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

            FileLogic.RefreshForm(ref filesListBox);
        }
                
        private void RunExecution_Click(object sender, EventArgs e)
        {
            // Run selected files            
            FileLogic.RunFile(filesListBox, scriptsToSelectFromListBox);
        }

        private void CancelExecution_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void AddSeletedFileFolderButton_Click(object sender, EventArgs e)
        {
            string folderName;

            // choose active project path            
            foreach (var folderNameItem in filesListBox.SelectedItems)
            {
                folderName = Directory.GetParent(((FileItem)folderNameItem).FullPath).ToString();
                GetFiles(folderName);
            }
        }



        private void refreshFormButton_Click(object sender, EventArgs e)
        {
            FileLogic.RefreshForm(ref filesListBox);
        }

       
        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileLogic.SetSelectedFiles(filesListBox);
        }

        private void addAvailableScriptsButton_Click(object sender, EventArgs e)
        {
            SelectAvailableScripts();            
        }

        private void SelectAvailableScripts() 
        {
            Form availableScriptsForm = new AvailableScriptsForm(this);
            availableScriptsForm.ShowDialog();
        }

        public void AddAvailableScripts()
        {
            FileLogic.FillAvailableScripts(scriptsToSelectFromListBox);
        }
    }
}
