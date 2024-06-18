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
        private void imbo(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\...\\Pictures");
            listBox1.Items.Clear();
            if (sender == comboBox1)
            {
                comboBox1_SelectedIndexChanged(sender, e, directoryInfo);
            }
            if (sender == button1)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo directoryInfo1 = new DirectoryInfo(dialog.SelectedPath);
                    directoryInfo = directoryInfo1;
                    button1_Click(sender, e, directoryInfo1);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e, DirectoryInfo directoryInfo)
        {
            var items = directoryInfo.GetFiles();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Extension == comboBox1.SelectedItem)
                {
                    listBox1.Items.Add(items[i].Name);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e, DirectoryInfo directoryInfo)
        {
            var items = directoryInfo.GetFiles();
            for (int i = 0; i < items.Length; i++)
            {
                comboBox1.Items.Add(items[i].Extension);
            }
        }

    }
}

