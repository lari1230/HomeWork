namespace _31._05._24__V3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FIO = label1.Text + ": " + textBox1.Text + "\n";
            string age = label2.Text + ": " + textBox2.Text + "\n";
            string gender = label3.Text + ": " + (radioButton2.Checked ? radioButton2.Text : radioButton1.Text) + "\n";
            string mail = label4.Text + ": " + textBox3.Text + "\n";
            string familyState = label5.Text + ": " + (radioButton3.Checked ?  radioButton3.Text : radioButton4.Text) + "\n";
            string countChildren = label6.Text + ": " + textBox4.Text + "\n";
            MessageBox.Show(FIO + age + gender + mail + familyState + countChildren, "Resume");
        }
    }
}
