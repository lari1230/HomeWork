namespace _31._05._24__V2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
           
            form2.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            form2.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }
}
