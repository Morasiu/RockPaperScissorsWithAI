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

            Assert.Equal(expectedScore.HumanScore, rpsGame.Score.HumanScore);
            Assert.Equal(expectedScore.ComputerScore, rpsGame.Score.ComputerScore);
        }
        
       

    }
}
