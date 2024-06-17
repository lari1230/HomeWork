namespace _31._05._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private int countMsgBox = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = "Name: Ivan \nLang: C++, C#, Python, HTML";
            string text2 = "My name is Ivan, i'm a programer.\nI can programing on C++, C#, HTMP and python.";
            string text3 = "I want to programing";
            int countMidSymbol = (text1.Length + text2.Length + text3.Length) / countMsgBox;
            for (int i = 0; i < countMsgBox; i++)
            {
                switch (i) 
                { 
                    case 0:
                        MessageBox.Show(text1, "Small Resume");
                        break;
                    case 1:
                        MessageBox.Show(text2, "Small Resume");
                        break;
                    case 2:
                        MessageBox.Show(text3, countMidSymbol.ToString());
                        break;
                }
            }
        }
    }
}
