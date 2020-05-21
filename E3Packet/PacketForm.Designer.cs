namespace E3Packet
{
    partial class PacketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacketForm));
            this.fileLable = new System.Windows.Forms.Label();
            this.scriptFoldersLable = new System.Windows.Forms.Label();
            this.RunExecution = new System.Windows.Forms.Button();
            this.CancelExecution = new System.Windows.Forms.Button();
            this.BrowseForFiles = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listScripts = new System.Windows.Forms.ListBox();
            this.listScriptFolders = new System.Windows.Forms.ListBox();
            this.scriptsLable = new System.Windows.Forms.Label();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.refreshFormButton = new System.Windows.Forms.Button();
            this.AddSeletedFileFolderButton = new System.Windows.Forms.Button();
            this.filesBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileLable
            // 
            this.fileLable.AutoSize = true;
            this.fileLable.Location = new System.Drawing.Point(3, 0);
            this.fileLable.Name = "fileLable";
            this.fileLable.Size = new System.Drawing.Size(28, 13);
            this.fileLable.TabIndex = 5;
            this.fileLable.Text = "Files";
            // 
            // scriptFoldersLable
            // 
            this.scriptFoldersLable.AutoSize = true;
            this.scriptFoldersLable.Location = new System.Drawing.Point(265, 0);
            this.scriptFoldersLable.Name = "scriptFoldersLable";
            this.scriptFoldersLable.Size = new System.Drawing.Size(70, 13);
            this.scriptFoldersLable.TabIndex = 6;
            this.scriptFoldersLable.Text = "Script folders";
            // 
            // RunExecution
            // 
            this.RunExecution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunExecution.Location = new System.Drawing.Point(527, 128);
            this.RunExecution.Name = "RunExecution";
            this.RunExecution.Size = new System.Drawing.Size(256, 34);
            this.RunExecution.TabIndex = 8;
            this.RunExecution.Text = "Run";
            this.RunExecution.UseVisualStyleBackColor = true;
            this.RunExecution.Click += new System.EventHandler(this.RunExecution_Click);
            // 
            // CancelExecution
            // 
            this.CancelExecution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelExecution.Location = new System.Drawing.Point(527, 168);
            this.CancelExecution.Name = "CancelExecution";
            this.CancelExecution.Size = new System.Drawing.Size(256, 34);
            this.CancelExecution.TabIndex = 9;
            this.CancelExecution.Text = "Cancel";
            this.CancelExecution.UseVisualStyleBackColor = true;
            this.CancelExecution.Click += new System.EventHandler(this.CancelExecution_Click);
            // 
            // BrowseForFiles
            // 
            this.BrowseForFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseForFiles.Location = new System.Drawing.Point(3, 128);
            this.BrowseForFiles.Name = "BrowseForFiles";
            this.BrowseForFiles.Size = new System.Drawing.Size(256, 34);
            this.BrowseForFiles.TabIndex = 12;
            this.BrowseForFiles.Text = "Browse for files";
            this.BrowseForFiles.UseVisualStyleBackColor = true;
            this.BrowseForFiles.Click += new System.EventHandler(this.BrowseForFiles_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listScripts, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listScriptFolders, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.scriptsLable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listFiles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.refreshFormButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.AddSeletedFileFolderButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fileLable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.scriptFoldersLable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BrowseForFiles, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RunExecution, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CancelExecution, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 245);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // listScripts
            // 
            this.listScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScripts.FormattingEnabled = true;
            this.listScripts.Location = new System.Drawing.Point(527, 16);
            this.listScripts.MaximumSize = new System.Drawing.Size(500, 900);
            this.listScripts.Name = "listScripts";
            this.listScripts.ScrollAlwaysVisible = true;
            this.listScripts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listScripts.Size = new System.Drawing.Size(256, 106);
            this.listScripts.Sorted = true;
            this.listScripts.TabIndex = 17;
            this.listScripts.SelectedIndexChanged += new System.EventHandler(this.listScripts_SelectedIndexChanged);
            // 
            // listScriptFolders
            // 
            this.listScriptFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScriptFolders.FormattingEnabled = true;
            this.listScriptFolders.Location = new System.Drawing.Point(265, 16);
            this.listScriptFolders.MaximumSize = new System.Drawing.Size(500, 900);
            this.listScriptFolders.Name = "listScriptFolders";
            this.listScriptFolders.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listScriptFolders.Size = new System.Drawing.Size(256, 106);
            this.listScriptFolders.Sorted = true;
            this.listScriptFolders.TabIndex = 15;
            this.listScriptFolders.SelectedIndexChanged += new System.EventHandler(this.listScriptFolders_SelectedIndexChanged);
            // 
            // scriptsLable
            // 
            this.scriptsLable.AutoSize = true;
            this.scriptsLable.Location = new System.Drawing.Point(527, 0);
            this.scriptsLable.Name = "scriptsLable";
            this.scriptsLable.Size = new System.Drawing.Size(39, 13);
            this.scriptsLable.TabIndex = 16;
            this.scriptsLable.Text = "Scripts";
            // 
            // listFiles
            // 
            this.listFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(3, 16);
            this.listFiles.MaximumSize = new System.Drawing.Size(500, 900);
            this.listFiles.Name = "listFiles";
            this.listFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listFiles.Size = new System.Drawing.Size(256, 106);
            this.listFiles.Sorted = true;
            this.listFiles.TabIndex = 14;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listFiles_SelectedIndexChanged);
            // 
            // refreshFormButton
            // 
            this.refreshFormButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshFormButton.Location = new System.Drawing.Point(265, 208);
            this.refreshFormButton.Name = "refreshFormButton";
            this.refreshFormButton.Size = new System.Drawing.Size(256, 34);
            this.refreshFormButton.TabIndex = 15;
            this.refreshFormButton.Text = "Refresh Form";
            this.refreshFormButton.UseVisualStyleBackColor = true;
            this.refreshFormButton.Click += new System.EventHandler(this.refreshFormButton_Click);
            // 
            // AddSeletedFileFolderButton
            // 
            this.AddSeletedFileFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSeletedFileFolderButton.Location = new System.Drawing.Point(3, 168);
            this.AddSeletedFileFolderButton.Name = "AddSeletedFileFolderButton";
            this.AddSeletedFileFolderButton.Size = new System.Drawing.Size(256, 34);
            this.AddSeletedFileFolderButton.TabIndex = 14;
            this.AddSeletedFileFolderButton.Text = "Add seleted file folder";
            this.AddSeletedFileFolderButton.UseVisualStyleBackColor = true;
            this.AddSeletedFileFolderButton.Click += new System.EventHandler(this.AddSeletedFileFolderButton_Click);
            // 
            // filesBrowserDialog
            // 
            this.filesBrowserDialog.Description = "Добавить файлы из папки";
            this.filesBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.filesBrowserDialog.SelectedPath = "D:\\SAVE\\DOC";
            this.filesBrowserDialog.ShowNewFolderButton = false;
            // 
            // PacketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 482);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PacketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "E3.Packet";
            this.Load += new System.EventHandler(this.PacketForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PacketForm_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fileLable;
        private System.Windows.Forms.Label scriptFoldersLable;
        private System.Windows.Forms.Button RunExecution;
        private System.Windows.Forms.Button CancelExecution;
        private System.Windows.Forms.Button BrowseForFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FolderBrowserDialog filesBrowserDialog;
        private System.Windows.Forms.Button AddSeletedFileFolderButton;
        private System.Windows.Forms.Button refreshFormButton;
        private System.Windows.Forms.Label scriptsLable;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.ListBox listScriptFolders;
        private System.Windows.Forms.ListBox listScripts;
    }
}

