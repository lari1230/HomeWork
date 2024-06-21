using System;
using System.IO;
using System.Windows.Forms;

namespace _2._06._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo directory = new DirectoryInfo(dialog.SelectedPath);
                string searchPattern = textBox1.Text;
                string searchDirectory = directory.FullName;

                string[] files = Directory.GetFiles(searchDirectory, searchPattern, SearchOption.AllDirectories);

                progressBar1.Maximum = files.Length;
                progressBar1.Value = 0;

                foreach (string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                    progressBar1.Value++;
                }
            }
            
        }
    }
}
