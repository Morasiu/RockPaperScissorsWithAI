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
            var winner = rpsGame.Rounds[0].Winner; // Nigdzie nie użyte
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

			// Najpierw jest podawane to czego sie spodziewamy:
			// Assert.Equal(expectedRoundCount, gamePlayCount);
			Assert.Equal(gamePlayCount, expectedRoundCount);

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

			// Można przypisać tylko drugą rudnę robiąc tak:
			//rpsGame.GetComputerPick(playerPick)
			//var computerPick = rpsGame.GetComputerPick(playerPick);

			var computerPick = rpsGame.GetComputerPick(playerPick);

            computerPick = rpsGame.GetComputerPick(playerPick); //Konieczne wydaje się przypisanie do zmiennej 
                                                                //z powodu użycia jej w Assercie.

			Pick expectedPick = Pick.Rock;
	
            Assert.Equal(expectedPick, computerPick);
        }


        [Fact]
        public void CurrentRound_SecondRound_ShouldReturnOppositePick()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
			// Tak samo jak wyżej
            var eachRound = rpsGame.GetComputerPick(playerPick);
            eachRound = rpsGame.GetComputerPick(playerPick);

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
                computerPick = rpsGame.GetComputerPick(playerPick);
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
            var winner = rpsGame.Winner;
            var win = false;

            do
            {
                computerPick = rpsGame.GetComputerPick(playerPick);
            }
            while (!rpsGame.IsGameOver);

			// Co?
			// Sprawdzaj kto ma 3 punkty przy użyciu
			//rpsGame.Score;
			// I potem sprawdź czy Winner to jest ta osoba z 3 punktami
            if (winner == Player.Computer | winner == Player.Human)
                win = true;

            Assert.True(win);
        }


        [Fact]
        public void GetComputerPick_ThirdRound_ShouldReturnLosingWithLastPick()
        {
            var rpsGame = new RPSGame();
            var computerPick = rpsGame.GetComputerPick(Pick.Paper);
                               rpsGame.GetComputerPick(Pick.Rock);
                computerPick = rpsGame.GetComputerPick(Pick.Scissor);
			// eee.. Dodaj jeszcze jedną rudnę i dopiero sprawdzaj. AI bierze tylko picki, które już były, a tutaj były dopiero 2
			Assert.Equal(Pick.Paper, computerPick);
        }


        [Fact]
        public void GetComputerPick_TestRounds_ShouldReturnLosingWithLessFrequentlyChoosenPick()
        {
            var rpsGame = new RPSGame();
            var computerPick = rpsGame.GetComputerPick(Pick.Rock);
                               rpsGame.GetComputerPick(Pick.Rock);
			computerPick = rpsGame.GetComputerPick(Pick.Paper);
			// eee.. Dodaj jeszcze jedną rudnę i dopiero sprawdzaj. AI bierze tylko picki, które już były, a tutaj były dopiero 2
			Assert.Equal(Pick.Rock, computerPick);
        }


        [Fact]
        public void GetComputerPick_TestRounds_ShouldReturnLosingOrDrawingWithLessFrequentlyChoosenPicks()
        {
            var rpsGame = new RPSGame();
            var computerPick = rpsGame.GetComputerPick(Pick.Rock);
                               rpsGame.GetComputerPick(Pick.Rock);
                               rpsGame.GetComputerPick(Pick.Paper);
                computerPick = rpsGame.GetComputerPick(Pick.Scissor);
			// eee.. Dodaj jeszcze jedną rudnę i dopiero sprawdzaj. AI bierze tylko picki, które już były, a tutaj były dopiero 2

			Assert.Equal(Pick.Scissor, computerPick);
        }

		// Chyba nie jako null
		//_MethodShouldntReturnComputerPickAs->Not<-Null
		// i bez Method
		[Fact]
        public void GetComputerPick_TestRound_MethodShouldntReturnComputerPickAsANull()
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
