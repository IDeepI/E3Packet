namespace E3Packet
{
    partial class AvailableScriptsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableScriptsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scriptsListBox = new System.Windows.Forms.ListBox();
            this.scriptFoldersListBox = new System.Windows.Forms.ListBox();
            this.scriptsLable = new System.Windows.Forms.Label();
            this.scriptFoldersLable = new System.Windows.Forms.Label();
            this.selectAvailableScriptsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.scriptsListBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.scriptFoldersListBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.scriptsLable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.scriptFoldersLable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectAvailableScriptsButton, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 165);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // scriptsListBox
            // 
            this.scriptsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptsListBox.FormattingEnabled = true;
            this.scriptsListBox.Location = new System.Drawing.Point(265, 16);
            this.scriptsListBox.MaximumSize = new System.Drawing.Size(500, 900);
            this.scriptsListBox.Name = "scriptsListBox";
            this.scriptsListBox.ScrollAlwaysVisible = true;
            this.scriptsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.scriptsListBox.Size = new System.Drawing.Size(256, 106);
            this.scriptsListBox.Sorted = true;
            this.scriptsListBox.TabIndex = 17;
            this.scriptsListBox.SelectedIndexChanged += new System.EventHandler(this.scriptsListBox_SelectedIndexChanged);
            // 
            // scriptFoldersListBox
            // 
            this.scriptFoldersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptFoldersListBox.FormattingEnabled = true;
            this.scriptFoldersListBox.Location = new System.Drawing.Point(3, 16);
            this.scriptFoldersListBox.MaximumSize = new System.Drawing.Size(500, 900);
            this.scriptFoldersListBox.Name = "scriptFoldersListBox";
            this.scriptFoldersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.scriptFoldersListBox.Size = new System.Drawing.Size(256, 106);
            this.scriptFoldersListBox.Sorted = true;
            this.scriptFoldersListBox.TabIndex = 15;
            this.scriptFoldersListBox.SelectedIndexChanged += new System.EventHandler(this.scriptFoldersListBox_SelectedIndexChanged);
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
            // scriptFoldersLable
            // 
            this.scriptFoldersLable.AutoSize = true;
            this.scriptFoldersLable.Location = new System.Drawing.Point(3, 0);
            this.scriptFoldersLable.Name = "scriptFoldersLable";
            this.scriptFoldersLable.Size = new System.Drawing.Size(70, 13);
            this.scriptFoldersLable.TabIndex = 6;
            this.scriptFoldersLable.Text = "Script folders";
            // 
            // selectAvailableScriptsButton
            // 
            this.selectAvailableScriptsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAvailableScriptsButton.Location = new System.Drawing.Point(265, 128);
            this.selectAvailableScriptsButton.Name = "selectAvailableScriptsButton";
            this.selectAvailableScriptsButton.Size = new System.Drawing.Size(256, 34);
            this.selectAvailableScriptsButton.TabIndex = 8;
            this.selectAvailableScriptsButton.Text = "Select scripts";
            this.selectAvailableScriptsButton.UseVisualStyleBackColor = true;
            this.selectAvailableScriptsButton.Click += new System.EventHandler(this.selectAvailableScriptsButton_Click);
            // 
            // AvailableScriptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 181);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AvailableScriptsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AvailableScriptsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox scriptsListBox;
        private System.Windows.Forms.ListBox scriptFoldersListBox;
        private System.Windows.Forms.Label scriptsLable;
        private System.Windows.Forms.Label scriptFoldersLable;
        private System.Windows.Forms.Button selectAvailableScriptsButton;
    }
}