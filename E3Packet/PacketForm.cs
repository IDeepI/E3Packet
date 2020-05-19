using System;
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
            FileLogic.RefreshForm(ref listFiles);
            for (int i = 0; i < listFiles.Items.Count; i++)
                listFiles.SetItemCheckState(i, CheckState.Checked);

            listFiles.AutoSize = true;
            listScripts.AutoSize = true;

            listFiles.Sorted = true;
            listScripts.Sorted = true;

            this.AutoSize = true;

            FileLogic.SetCheckedFiles(listFiles);
            FileLogic.SetCheckedScripts(listScripts);
        }


        private void PacketForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void BrowseForFiles_Click(object sender, EventArgs e)
        {
            string folderName;

            // choose active project path
            folderName = listFiles?.CheckedItems[0]?.ToString();
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
                FileLogic.LoadScripts(openScriptDialog.FileNames, ref listScripts);
                FileLogic.RefreshForm(ref listFiles);
            }
        }

        private void RunExecution_Click(object sender, EventArgs e)
        {
            // Run selected files            
            FileLogic.RunFile(FileLogic.listFileItems.Where(x => x.ItemChecked).ToList());
        }

        private void listOpendFiles_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void listAvailableScripts_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CancelExecution_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSeletedFileFolderButton_Click(object sender, EventArgs e)
        {
            string folderName;

            // choose active project path
            string[] folderNameItems = listFiles.CheckedItems.Cast<string>().ToArray();
            foreach (string folderNameItem in folderNameItems)
            {
                folderName = Directory.GetParent(folderNameItem).ToString();
                GetFiles(folderName);
            }
        }

        private void listOpendFiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(
                (MethodInvoker)
                (() => FileLogic.SetCheckedFiles(listFiles))
                );
        }

        private void listAvailableScripts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            FileLogic.SetCheckedScripts(listScripts);
        }

        private void refreshFormButton_Click(object sender, EventArgs e)
        {
            FileLogic.RefreshForm(ref listFiles);
        }

        private void listAvailableScripts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
