namespace _28._06._28__V4_
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            PlayGame("Rock");
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            PlayGame("Paper");
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            PlayGame("Scissors");
        }

        private void PlayGame(string userChoice)
        {
            string[] choices = { "Rock", "Paper", "Scissors" };
            string computerChoice = choices[random.Next(choices.Length)];

            DisplayChoice(pictureBoxUser, userChoice);
            DisplayChoice(pictureBoxComputer, computerChoice);

            string result = DetermineWinner(userChoice, computerChoice);
            labelResult.Text = $"Result: {result}";
        }

        private void DisplayChoice(PictureBox pictureBox, string choice)
        {
            switch (choice)
            {
                case "Rock":
                    pictureBox.Image = Properties.Resources.Rock; // Add Rock image to resources
                    break;
                case "Paper":
                    pictureBox.Image = Properties.Resources.Paper; // Add Paper image to resources
                    break;
                case "Scissors":
                    pictureBox.Image = Properties.Resources.Scissors; // Add Scissors image to resources
                    break;
            }
        }

        private string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
                return "Draw";

            if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                (userChoice == "Paper" && computerChoice == "Rock") ||
                (userChoice == "Scissors" && computerChoice == "Paper"))
            {
                return "You Win!";
            }
            else
            {
                return "Computer Wins!";
            }
        }
    }
}
