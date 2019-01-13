using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using RPSClassLib;
using RPS;

namespace RPSClassLib.Tests
{
    public class RSPGameTest
    {
        [Fact]
        public void Score_FirstRound_ShouldHasCorrectScore()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
            var computerPick = rpsGame.GetComputerPick(playerPick);
            var winner = rpsGame.Rounds[0].Winner;
            var expectedScore = new Score();
            
            if (playerPick == computerPick)
            {
                expectedScore.ComputerScore = 0;
            }

            else if (computerPick == Pick.Rock)
            {
                expectedScore.HumanScore = 1;
            }

            else if (computerPick == Pick.Scissor)
            {
                expectedScore.ComputerScore = 1;
            }

            Assert.Equal(expectedScore.HumanScore, rpsGame.Score.HumanScore);
            Assert.Equal(expectedScore.ComputerScore, rpsGame.Score.ComputerScore);
        }
        
        [Fact]
        public void Winner_TestRoundFirst_ShouldReturnWinner()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
            var computerPick = rpsGame.GetComputerPick(playerPick);
            var winner = rpsGame.Rounds[0].Winner;
            Player? expectedWinner;

            if (playerPick == computerPick)
            {
                expectedWinner = null;
            }

            else if (computerPick == Pick.Rock)
            {
                expectedWinner = Player.Human;
            }

            else
            {
                expectedWinner = Player.Computer;
            }

            Assert.Equal(expectedWinner, winner);
            
            
        }

        [Fact]
        public void GetComputerPick_SecondRound_ShouldReturnRock()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
            var computerPick = rpsGame.GetComputerPick(playerPick);
             computerPick = rpsGame.GetComputerPick(playerPick);

            Assert.Equal(Pick.Rock, computerPick);


        }


    }
}
