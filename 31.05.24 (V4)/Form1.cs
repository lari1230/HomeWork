using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _31._05._24__V4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string dialogStr;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    dialogStr = dialog.SelectedPath;
                    DirectoryInfo directoryInfo = new DirectoryInfo(dialogStr);
                    var items = directoryInfo.GetFiles();
                    listBox1.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (items[i].Extension == comboBox1.SelectedItem.ToString())
                        {
                            listBox1.Items.Add(items[i].Name);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, choose extension in combo box.", "Error", MessageBoxButtons.OK);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dialogStr != null)
            {
                listBox1.Items.Clear();
                DirectoryInfo directoryInfo = new DirectoryInfo(dialogStr);
                var items = directoryInfo.GetFiles();
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i].Extension == comboBox1.SelectedItem.ToString())
                    {
                        listBox1.Items.Add(items[i].Name);
                    }
                }
            }
        }
    }
}

