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
            this.filesBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cancelExecution = new System.Windows.Forms.Button();
            this.browseForFiles = new System.Windows.Forms.Button();
            this.fileLable = new System.Windows.Forms.Label();
            this.addSeletedFileFolderButton = new System.Windows.Forms.Button();
            this.refreshFormButton = new System.Windows.Forms.Button();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.scriptsLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scriptsToSelectFromListBox = new System.Windows.Forms.ListBox();
            this.addAvailableScriptsButton = new System.Windows.Forms.Button();
            this.runExecution = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesBrowserDialog
            // 
            this.filesBrowserDialog.Description = "Добавить файлы из папки";
            this.filesBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.filesBrowserDialog.SelectedPath = "D:\\SAVE\\DOC";
            this.filesBrowserDialog.ShowNewFolderButton = false;
            // 
            // cancelExecution
            // 
            this.cancelExecution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelExecution.Location = new System.Drawing.Point(265, 208);
            this.cancelExecution.Name = "cancelExecution";
            this.cancelExecution.Size = new System.Drawing.Size(256, 34);
            this.cancelExecution.TabIndex = 9;
            this.cancelExecution.Text = "Cancel";
            this.cancelExecution.UseVisualStyleBackColor = true;
            this.cancelExecution.Click += new System.EventHandler(this.CancelExecution_Click);
            // 
            // browseForFiles
            // 
            this.browseForFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseForFiles.Location = new System.Drawing.Point(3, 128);
            this.browseForFiles.Name = "browseForFiles";
            this.browseForFiles.Size = new System.Drawing.Size(256, 34);
            this.browseForFiles.TabIndex = 12;
            this.browseForFiles.Text = "Browse for files";
            this.browseForFiles.UseVisualStyleBackColor = true;
            this.browseForFiles.Click += new System.EventHandler(this.BrowseForFiles_Click);
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
            // addSeletedFileFolderButton
            // 
            this.addSeletedFileFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSeletedFileFolderButton.Location = new System.Drawing.Point(3, 168);
            this.addSeletedFileFolderButton.Name = "addSeletedFileFolderButton";
            this.addSeletedFileFolderButton.Size = new System.Drawing.Size(256, 34);
            this.addSeletedFileFolderButton.TabIndex = 14;
            this.addSeletedFileFolderButton.Text = "Add seleted file folder";
            this.addSeletedFileFolderButton.UseVisualStyleBackColor = true;
            this.addSeletedFileFolderButton.Click += new System.EventHandler(this.AddSeletedFileFolderButton_Click);
            // 
            // refreshFormButton
            // 
            this.refreshFormButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshFormButton.Location = new System.Drawing.Point(3, 208);
            this.refreshFormButton.Name = "refreshFormButton";
            this.refreshFormButton.Size = new System.Drawing.Size(256, 34);
            this.refreshFormButton.TabIndex = 15;
            this.refreshFormButton.Text = "Refresh Form";
            this.refreshFormButton.UseVisualStyleBackColor = true;
            this.refreshFormButton.Click += new System.EventHandler(this.refreshFormButton_Click);
            // 
            // filesListBox
            // 
            this.filesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(3, 16);
            this.filesListBox.MaximumSize = new System.Drawing.Size(500, 900);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filesListBox.Size = new System.Drawing.Size(256, 106);
            this.filesListBox.Sorted = true;
            this.filesListBox.TabIndex = 14;
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.listFiles_SelectedIndexChanged);
            // 
            // scriptsLable
            // 
            this.scriptsLable.AutoSize = true;
            this.scriptsLable.Location = new System.Drawing.Point(265, 0);
            this.scriptsLable.Name = "scriptsLable";
            this.scriptsLable.Size = new System.Drawing.Size(39, 13);
            this.scriptsLable.TabIndex = 16;
            this.scriptsLable.Text = "Scripts";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.scriptsToSelectFromListBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.addAvailableScriptsButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.filesListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.refreshFormButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.addSeletedFileFolderButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fileLable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.browseForFiles, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.runExecution, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cancelExecution, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.scriptsLable, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 245);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // scriptsToSelectFromListBox
            // 
            this.scriptsToSelectFromListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptsToSelectFromListBox.FormattingEnabled = true;
            this.scriptsToSelectFromListBox.Location = new System.Drawing.Point(265, 16);
            this.scriptsToSelectFromListBox.MaximumSize = new System.Drawing.Size(500, 900);
            this.scriptsToSelectFromListBox.Name = "scriptsToSelectFromListBox";
            this.scriptsToSelectFromListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.scriptsToSelectFromListBox.Size = new System.Drawing.Size(256, 106);
            this.scriptsToSelectFromListBox.Sorted = true;
            this.scriptsToSelectFromListBox.TabIndex = 18;
            // 
            // addAvailableScriptsButton
            // 
            this.addAvailableScriptsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAvailableScriptsButton.Location = new System.Drawing.Point(265, 128);
            this.addAvailableScriptsButton.Name = "addAvailableScriptsButton";
            this.addAvailableScriptsButton.Size = new System.Drawing.Size(256, 34);
            this.addAvailableScriptsButton.TabIndex = 17;
            this.addAvailableScriptsButton.Text = "Add Scripts";
            this.addAvailableScriptsButton.UseVisualStyleBackColor = true;
            this.addAvailableScriptsButton.Click += new System.EventHandler(this.addAvailableScriptsButton_Click);
            // 
            // runExecution
            // 
            this.runExecution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runExecution.Location = new System.Drawing.Point(265, 168);
            this.runExecution.Name = "runExecution";
            this.runExecution.Size = new System.Drawing.Size(256, 34);
            this.runExecution.TabIndex = 8;
            this.runExecution.Text = "Run";
            this.runExecution.UseVisualStyleBackColor = true;
            this.runExecution.Click += new System.EventHandler(this.RunExecution_Click);
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
        private System.Windows.Forms.FolderBrowserDialog filesBrowserDialog;
        private System.Windows.Forms.Button cancelExecution;
        private System.Windows.Forms.Button browseForFiles;
        private System.Windows.Forms.Label fileLable;
        private System.Windows.Forms.Button addSeletedFileFolderButton;
        private System.Windows.Forms.Button refreshFormButton;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Label scriptsLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button runExecution;
        private System.Windows.Forms.Button addAvailableScriptsButton;
        private System.Windows.Forms.ListBox scriptsToSelectFromListBox;
    }
}

