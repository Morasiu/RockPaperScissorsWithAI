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
            SetComputerPickPicture(Game.GetComputerPick(Pick.Rock));
            PlayerPictureBox.Image = Properties.Resources.rock;

            SetRoundCount();
            SetScore();

            GameOverCheck();
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            SetComputerPickPicture(Game.GetComputerPick(Pick.Paper));
            PlayerPictureBox.Image = Properties.Resources.paper;

            SetRoundCount();
            SetScore();

            GameOverCheck(); ;
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            SetComputerPickPicture(Game.GetComputerPick(Pick.Scissor));
            PlayerPictureBox.Image = Properties.Resources.scissors;          

            SetRoundCount();
            SetScore();       

            GameOverCheck();
        }


        private void GameStart()
        {
            StartButton.Visible = false;
            ButtonRestart.Visible = true; // <-- Error bejbe

            RockButton.Enabled = true;
            PaperButton.Enabled = true;
            ScissorsButton.Enabled = true;

            Game = new RPSGame();
        }

        private void GameOverCheck()
        {
            if (Game.IsGameOver)
            {
                RockButton.Enabled = false;
                PaperButton.Enabled = false;
                ScissorsButton.Enabled = false;

                if (Game.Winner == Player.Human)
                {
                    MessageBox.Show("Game Has Ended. YOU WIN!");
                }
                else if (Game.Winner == Player.Computer)
                {
                    MessageBox.Show("Game Has Ended. YOU LOSE!");
                }
            }            
        }

        private void SetComputerPickPicture(Pick ComputerPickPicture)
        {
            switch (ComputerPickPicture)
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
            RoundCounter.Text = Game.Rounds.Count.ToString();           
        }

        #endregion
    }
}
