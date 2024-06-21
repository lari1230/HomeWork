namespace _28._06._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = textBox2.Text;
            if (!string.IsNullOrEmpty(fileName))
            {
                File.WriteAllText(fileName, textBox1.Text);
                MessageBox.Show("Text saved to file " + fileName);
            }
            else
            {
                MessageBox.Show("Please enter a file name.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }

        }
    }
}
