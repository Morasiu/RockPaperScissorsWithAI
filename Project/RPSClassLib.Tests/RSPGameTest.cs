using System;
using System.Collections.Generic;
using Xunit;
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
        public void Rounds_ThirdRound_ShouldReturnProperRoundValue()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;

            int expectedRoundCount = 3;
              for(int i = 0; i < expectedRoundCount; i++)
              	rpsGame.GetComputerPick(playerPick);

            int gamePlayCount = rpsGame.Rounds.Count;

			Assert.Equal(expectedRoundCount, gamePlayCount);

		}


        [Fact]
        public void RoundClassWinner_TestRoundFirst_ShouldReturnWinner()
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

            rpsGame.GetComputerPick(playerPick);

			var computerPick = rpsGame.GetComputerPick(playerPick);

			Pick expectedPick = Pick.Rock;
	
            Assert.Equal(expectedPick, computerPick);
        }


        [Fact]
        public void CurrentRound_SecondRound_ShouldReturnOppositePick()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;

            rpsGame.GetComputerPick(playerPick);

            var eachRound = rpsGame.GetComputerPick(playerPick);

            var computerPick = rpsGame.CurrentRound.ComputerPick;

            Assert.NotEqual(playerPick, computerPick);
        }


        [Fact]
        public void IsGameOver_GetComputerPickAfterGameOver_ShouldThrowApplicationException()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
            var computerPick = rpsGame.GetComputerPick(playerPick);

            do
            {
                rpsGame.GetComputerPick(playerPick);
            }

            while (!rpsGame.IsGameOver);

			Action getPickAfterGameOver = () => rpsGame.GetComputerPick(playerPick);

			Assert.Throws<ApplicationException>(getPickAfterGameOver);
        }

        [Fact]
        public void RPSGameClassWinner_TestRound_CheckingIfSomeoneWins()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Rock;
            var computerPick = rpsGame.GetComputerPick(playerPick);
            var expectedWinner = rpsGame.Winner;
            var score = new Score();
            Player winner = new Player();

            do
            {
                rpsGame.GetComputerPick(playerPick);
            }
            while (!rpsGame.IsGameOver);

            if (score.HumanScore == 3)
            {
                winner = Player.Human;
            }
            else if (score.ComputerScore == 3)
            {
                winner = Player.Computer;
            }
           

            Assert.Equal(expectedWinner, winner);

        }


        [Fact]
        public void GetComputerPick_ThirdRound_ShouldReturnLosingWithLastPick()
        {
            var rpsGame = new RPSGame();
            var computerPick = rpsGame.GetComputerPick(Pick.Paper);
                               rpsGame.GetComputerPick(Pick.Rock);
                               rpsGame.GetComputerPick(Pick.Scissor);
                computerPick = rpsGame.GetComputerPick(Pick.Scissor);

			Assert.Equal(Pick.Paper, computerPick);
        }


        [Fact]
        public void GetComputerPick_TestRounds_ShouldReturnLosingWithLessFrequentlyChoosenPick()
        {
            var rpsGame = new RPSGame();
            var computerPick = rpsGame.GetComputerPick(Pick.Rock);
                               rpsGame.GetComputerPick(Pick.Rock);
                               rpsGame.GetComputerPick(Pick.Paper);
			    computerPick = rpsGame.GetComputerPick(Pick.Paper);

			Assert.Equal(Pick.Rock, computerPick);
        }


        [Fact]
        public void GetComputerPick_TestRounds_ShouldReturnLosingOrDrawingWithLessFrequentlyChoosenPicks()
        {
            var rpsGame = new RPSGame();
            var computerPick = rpsGame.GetComputerPick(Pick.Rock);
                               rpsGame.GetComputerPick(Pick.Rock);
                               rpsGame.GetComputerPick(Pick.Paper);
                               rpsGame.GetComputerPick(Pick.Scissor);
                computerPick = rpsGame.GetComputerPick(Pick.Scissor);

			Assert.Equal(Pick.Scissor, computerPick);
        }


		[Fact]
        public void GetComputerPick_TestRound_ShouldntReturnComputerPickAsANull()
        {

            var rpsGame = new RPSGame();
            var playerPick = Pick.Rock;
            var computerPick = rpsGame.GetComputerPick(playerPick);
            rpsGame.GetComputerPick(playerPick);
            rpsGame.GetComputerPick(playerPick);
            Pick? nullPick = null;

            Assert.NotEqual(nullPick, computerPick);
        }
    }
}
