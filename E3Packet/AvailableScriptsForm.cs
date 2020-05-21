using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Packet
{
    public partial class AvailableScriptsForm : Form
    {
        PacketForm callingForm;
        public AvailableScriptsForm(PacketForm caller)
        {
            InitializeComponent();

            callingForm = caller;

            scriptFoldersListBox.AutoSize = true;
            scriptsListBox.AutoSize = true;

            scriptFoldersListBox.Sorted = true;
            scriptsListBox.Sorted = true;

            scriptsListBox.DisplayMember = "ShortScriptName";

            scriptsListBox.ValueMember = "fullPath";

            FileLogic.LoadScriptFolder(ref scriptFoldersListBox, ref scriptsListBox);
            FileLogic.SetSelectedScripts(scriptsListBox);
        }

        private void selectAvailableScriptsButton_Click(object sender, EventArgs e)
        {            
            callingForm.AddAvailableScripts();
            this.Close();
        }

        private void scriptsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileLogic.ignoreSelectedIndexChanged == false)
            {
                FileLogic.SetSelectedScripts(scriptsListBox);
            }
        }

        private void scriptFoldersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileLogic.FillScriptsFromSelectedFolders(scriptFoldersListBox, scriptsListBox);
           
            scriptsListBox.Refresh();
            scriptsListBox.Size = new Size(100, 100);
        }
    }
}
