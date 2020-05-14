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
            this.listOpendFiles = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RunExecution = new System.Windows.Forms.Button();
            this.CancelExecution = new System.Windows.Forms.Button();
            this.BrowseForFiles = new System.Windows.Forms.Button();
            this.BrowseForScripts = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listAvailableScripts = new System.Windows.Forms.CheckedListBox();
            this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.filesBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOpendFiles
            // 
            this.listOpendFiles.CheckOnClick = true;
            this.listOpendFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOpendFiles.FormattingEnabled = true;
            this.listOpendFiles.Location = new System.Drawing.Point(3, 16);
            this.listOpendFiles.MinimumSize = new System.Drawing.Size(251, 251);
            this.listOpendFiles.Name = "listOpendFiles";
            this.listOpendFiles.Size = new System.Drawing.Size(256, 260);
            this.listOpendFiles.TabIndex = 0;
            this.listOpendFiles.SelectedValueChanged += new System.EventHandler(this.listOpendFiles_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Scripts";
            // 
            // RunExecution
            // 
            this.RunExecution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunExecution.Location = new System.Drawing.Point(265, 322);
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
            this.CancelExecution.Location = new System.Drawing.Point(265, 362);
            this.CancelExecution.Name = "CancelExecution";
            this.CancelExecution.Size = new System.Drawing.Size(256, 34);
            this.CancelExecution.TabIndex = 9;
            this.CancelExecution.Text = "Cancel";
            this.CancelExecution.UseVisualStyleBackColor = true;
            // 
            // BrowseForFiles
            // 
            this.BrowseForFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseForFiles.Location = new System.Drawing.Point(3, 282);
            this.BrowseForFiles.Name = "BrowseForFiles";
            this.BrowseForFiles.Size = new System.Drawing.Size(256, 34);
            this.BrowseForFiles.TabIndex = 12;
            this.BrowseForFiles.Text = "Browse for files";
            this.BrowseForFiles.UseVisualStyleBackColor = true;
            this.BrowseForFiles.Click += new System.EventHandler(this.BrowseForFiles_Click);
            // 
            // BrowseForScripts
            // 
            this.BrowseForScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseForScripts.Location = new System.Drawing.Point(265, 282);
            this.BrowseForScripts.Name = "BrowseForScripts";
            this.BrowseForScripts.Size = new System.Drawing.Size(256, 34);
            this.BrowseForScripts.TabIndex = 12;
            this.BrowseForScripts.Text = "Browse for Scripts";
            this.BrowseForScripts.UseVisualStyleBackColor = true;
            this.BrowseForScripts.Click += new System.EventHandler(this.BrowseForScripts_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listAvailableScripts, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listOpendFiles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BrowseForFiles, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BrowseForScripts, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.RunExecution, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CancelExecution, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 399);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // listAvailableScripts
            // 
            this.listAvailableScripts.CheckOnClick = true;
            this.listAvailableScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAvailableScripts.FormattingEnabled = true;
            this.listAvailableScripts.Location = new System.Drawing.Point(265, 16);
            this.listAvailableScripts.MaximumSize = new System.Drawing.Size(1000, 750);
            this.listAvailableScripts.MinimumSize = new System.Drawing.Size(251, 251);
            this.listAvailableScripts.Name = "listAvailableScripts";
            this.listAvailableScripts.Size = new System.Drawing.Size(256, 260);
            this.listAvailableScripts.TabIndex = 13;
            this.listAvailableScripts.SelectedValueChanged += new System.EventHandler(this.listAvailableScripts_SelectedValueChanged);
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
            this.ClientSize = new System.Drawing.Size(585, 482);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RunExecution;
        private System.Windows.Forms.Button CancelExecution;
        private System.Windows.Forms.Button BrowseForFiles;
        private System.Windows.Forms.Button BrowseForScripts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.CheckedListBox listOpendFiles;
        public System.Windows.Forms.CheckedListBox listAvailableScripts;
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
        private System.Windows.Forms.FolderBrowserDialog filesBrowserDialog;
    }
}

