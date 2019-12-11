using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PickFolder_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                StartFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            FolderList.Items.Clear();
            Count.Text = "0";
            List<string> dirs = FindFile.GetDirectories(StartFolder.Text, FileName.Text, Exact.Checked);
            dirs.ForEach(x => FolderList.Items.Add(x));
            Count.Text = FolderList.Items.Count.ToString();
        }

        private void FolderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = FolderList.SelectedItem.ToString();
            string folderToOpen = selection.Substring(0, selection.LastIndexOf(@"\"));
            Process.Start(folderToOpen);
        }
    }
}
