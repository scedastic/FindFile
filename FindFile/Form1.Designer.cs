namespace FindFile
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.PickFolder = new System.Windows.Forms.Button();
            this.StartFolder = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.FolderList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.Exact = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PickFolder
            // 
            this.PickFolder.Location = new System.Drawing.Point(20, 12);
            this.PickFolder.Name = "PickFolder";
            this.PickFolder.Size = new System.Drawing.Size(101, 28);
            this.PickFolder.TabIndex = 0;
            this.PickFolder.Text = "Choose Folder";
            this.PickFolder.UseVisualStyleBackColor = true;
            this.PickFolder.Click += new System.EventHandler(this.PickFolder_Click);
            // 
            // StartFolder
            // 
            this.StartFolder.Location = new System.Drawing.Point(146, 12);
            this.StartFolder.Name = "StartFolder";
            this.StartFolder.ReadOnly = true;
            this.StartFolder.Size = new System.Drawing.Size(286, 20);
            this.StartFolder.TabIndex = 1;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(146, 66);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(203, 20);
            this.FileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File name to find";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(492, 64);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // FolderList
            // 
            this.FolderList.FormattingEnabled = true;
            this.FolderList.Location = new System.Drawing.Point(146, 136);
            this.FolderList.Name = "FolderList";
            this.FolderList.Size = new System.Drawing.Size(612, 394);
            this.FolderList.TabIndex = 6;
            this.FolderList.SelectedIndexChanged += new System.EventHandler(this.FolderList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Files Found";
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.Location = new System.Drawing.Point(87, 136);
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Size = new System.Drawing.Size(34, 20);
            this.Count.TabIndex = 8;
            // 
            // Exact
            // 
            this.Exact.AutoSize = true;
            this.Exact.Location = new System.Drawing.Point(367, 69);
            this.Exact.Name = "Exact";
            this.Exact.Size = new System.Drawing.Size(110, 17);
            this.Exact.TabIndex = 9;
            this.Exact.Text = "Exact Match Only";
            this.Exact.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.Exact);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FolderList);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.StartFolder);
            this.Controls.Add(this.PickFolder);
            this.Name = "Form1";
            this.Text = "Find File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button PickFolder;
        private System.Windows.Forms.TextBox StartFolder;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox FolderList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.CheckBox Exact;
    }
}

