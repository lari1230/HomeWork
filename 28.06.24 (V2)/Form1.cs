namespace _28._06._24__V2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.KeyPress += TextBox1TextChanged;
        }
        private void TextBox1TextChanged(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text[textBox1.Text.Length - 1] == e.KeyChar)
            {
                e.Handled = true;
            }
        }
    }
}
