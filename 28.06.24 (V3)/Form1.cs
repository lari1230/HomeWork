namespace _28._06._24__V3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"Число n: {trackBar1.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = trackBar1.Value;
            int factorial = Factorial(n);
            label1.Text = $"N! = {factorial}";
            textBox1.Text = factorial.ToString();
        }

        private int Factorial(int n)
        {
            int result = 1;
            if (n == 0 || n == 1) return 1;   
            for (int i = 2; i <= n; i++) result *= i;
            return result;
        }
    }
}
