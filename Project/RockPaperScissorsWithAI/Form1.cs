using RPS;
using System;
using System.Windows.Forms;

namespace RockPaperScissorsWithAI
{
    public partial class RockPaperScissors : Form
    {
        #region Public contructors

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        #endregion

        #region Private variables

        private RPSGame Game;

        // Do kosza
        private Pick ComputerPick;

        //Używasz tego do czegoś? Nie, to zgadnij? Do kosza
        private Pick HumanPick;

        // Zaznacz i BackSpace
        private byte RoundCount;

        #endregion

        #region Private methods

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            PlayerPictureBox.Image = null;
            ComputerPictureBox.Image = null;

            RockButton.Enabled = true;
            PaperButton.Enabled = true;
            ScissorsButton.Enabled = true;

            //Clear GUI
            RoundCounter.Text = 0.ToString();
            HumanScore.Text = 0.ToString();
            ComputerScore.Text = 0.ToString();

            //Create New RPSGame Instance
            Game = new RPSGame();
        }

        private void RockButton_Click(object sender, EventArgs e)
        {     
            ComputerPick = Game.GetComputerPick(Pick.Rock);
            HumanPick = Pick.Rock;

            SetRoundCount();
            SetScore();

            PlayerPictureBox.Image = Properties.Resources.rock;
            SetComputerPickPicture();
            
            // Zrób z tego metodę GameOverCheck() czy coś zasiast powtarzać
            if (Game.IsGameOver)
            {
                GameEnd();
            }
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            ComputerPick = Game.GetComputerPick(Pick.Paper);
            HumanPick = Pick.Paper;

            SetRoundCount();
            SetScore();

            PlayerPictureBox.Image = Properties.Resources.paper;
            SetComputerPickPicture();

            if (Game.IsGameOver)
            {
                GameEnd();
            }
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            ComputerPick = Game.GetComputerPick(Pick.Scissor);
            HumanPick = Pick.Scissor;

            SetRoundCount();
            SetScore();

            PlayerPictureBox.Image = Properties.Resources.scissors;
            SetComputerPickPicture();

            if (Game.IsGameOver)
            {
                GameEnd();
            }
        }


        private void GameStart()
        {
            MessageBox.Show("Choose your pick!");

            StartButton.Visible = false;
            ButtonRestart.Visible = true; // <-- Error bejbe

            RockButton.Enabled = true;
            PaperButton.Enabled = true;
            ScissorsButton.Enabled = true;

            Game = new RPSGame();
        }

        private void GameEnd()
        {
            RockButton.Enabled = false;
            PaperButton.Enabled = false;
            ScissorsButton.Enabled = false;


            // Po to jest Game.Winner!;
            if (Game.Score.HumanScore == 3)
            {
                MessageBox.Show("Game Has Ended. YOU WIN!");
            }
            else if(Game.Score.ComputerScore == 3)
            {
                MessageBox.Show("Game Has Ended. YOU LOSE!");
            }        
        }

        // Dodaj tutaj paramter:
        // private void SetComputerPickPicture(Pick computerPick)
        // i podstawie tego zmieniaj.
        private void SetComputerPickPicture()
        {
            switch (ComputerPick)
            {
                case Pick.Rock:
                    ComputerPictureBox.Image = Properties.Resources.rock;
                    break;
                case Pick.Paper:
                    ComputerPictureBox.Image = Properties.Resources.paper;
                    break;
                case Pick.Scissor:
                    ComputerPictureBox.Image = Properties.Resources.scissors;
                    break;
            }
        }

        private void SetScore()
        {
            HumanScore.Text = Game.Score.HumanScore.ToString();
            ComputerScore.Text = Game.Score.ComputerScore.ToString();
        }

        private void SetRoundCount()
        {
            RoundCount = Convert.ToByte(Game.Rounds.Count);

            // Wtf? Why? Po prostu zrób:
            //RoundCounter.Text = Game.Rounds.Count.ToString();

            RoundCounter.Text = RoundCount.ToString();
            
        }

        #endregion
    }
}
