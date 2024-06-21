namespace _21._06._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string textBox1Content;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextChanged += TextBox1TextChanged;
            textBox1.LostFocus += TextBox1LostFocus;
            textBox1.GotFocus += TextBox1GotFocus;
        }
        private void TextBox1TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.Length.ToString();
        }
        private void TextBox1LostFocus(object sender, EventArgs e)
        {
            textBox1Content = textBox1.Text;
            Clipboard.SetText(textBox1.Text);
            textBox1.Clear();
        }
        private void TextBox1GotFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1Content))
            {
                textBox1.Text = textBox1Content;
                textBox1Content = null;
            }
        }
    }
}
