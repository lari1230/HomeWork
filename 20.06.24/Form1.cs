using System.Windows.Forms;

namespace _20._06._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Func();
        }
        private void Func()
        {
            for (int i = 0; i < 3; i++) 
            { 
                for(int j = 0; j < 3; j++)
                {
                    Button button = new Button()
                    {
                        Text = $"Button {i * 3 + j + 1}",
                        Dock = DockStyle.Fill
                    };
                    button.Click += Button_Click;
                    tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                MessageBox.Show(button.Text);
            }
        }
    }
}
