using RPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsWithAI
{
    public partial class RockPaperScissors : Form
    {
        public RPSGame Game;
        public Pick ComputerPick;
        public Pick HumanPick;
        public short CurrentRound;
        public Round MatchRound;

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void GameStart()
        {
            
            MessageBox.Show("Choose your pick!");
            StartButton.Visible = false;
            ResetButton.Visible = true;

            RockButton.Enabled = true;
            PaperButton.Enabled = true;
            ScissorsButton.Enabled = true;

            Game = new RPSGame();
            
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
           ComputerPick =  Game.GetComputerPick(Pick.Rock);
           HumanPick = Pick.Rock;

            PlayerPictureBox.Image = Properties.Resources.scissors;

            if (ComputerPick == Pick.Rock)
                ComputerPictureBox.Image = Properties.Resources.scissors;
            else if (ComputerPick == Pick.Rock)
                ComputerPictureBox.Image = Properties.Resources.paper;
            else
                ComputerPictureBox.Image = Properties.Resources.rock;

            AddRound(MatchRound);
            Game.RoundEnd();

            HumanScore.Text = Game.Score.HumanScore.ToString();
            ComputerScore.Text = Game.Score.ComputerScore.ToString();
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            ComputerPick = Game.GetComputerPick(Pick.Paper);
            HumanPick = Pick.Paper;

            PlayerPictureBox.Image = Properties.Resources.scissors;

            if (ComputerPick == Pick.Scissor)
                ComputerPictureBox.Image = Properties.Resources.scissors;
            else if (ComputerPick == Pick.Paper)
                ComputerPictureBox.Image = Properties.Resources.paper;
            else
                ComputerPictureBox.Image = Properties.Resources.rock;

            AddRound(MatchRound);
            Game.RoundEnd();

            HumanScore.Text = Game.Score.HumanScore.ToString();
            ComputerScore.Text = Game.Score.ComputerScore.ToString();
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {

            ComputerPick = Game.GetComputerPick(Pick.Scissor);
            HumanPick = Pick.Scissor;

            PlayerPictureBox.Image = Properties.Resources.scissors;
            if (ComputerPick == Pick.Scissor)
                ComputerPictureBox.Image = Properties.Resources.scissors;
            else if (ComputerPick == Pick.Paper)
                ComputerPictureBox.Image = Properties.Resources.paper;
            else
                ComputerPictureBox.Image = Properties.Resources.rock;

            AddRound(MatchRound);
            Game.RoundEnd();  
            
            HumanScore.Text = Game.Score.HumanScore.ToString();
            ComputerScore.Text = Game.Score.ComputerScore.ToString();


            //TODO koniec gry (do 3) Game.Winner == Player.Computer;
            //TODO wyswietlic na koncu historie rund
        }

        private void AddRound(Round RoundToAdd)
        {
            CurrentRound += 1;
            Game.Rounds.Add(RoundToAdd);
            RoundCounter.Text = CurrentRound.ToString();
        }
    }
}
