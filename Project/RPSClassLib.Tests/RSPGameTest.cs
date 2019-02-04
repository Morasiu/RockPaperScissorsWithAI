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
        public void Rounds_ThirdRound_ShouldReturnRoundProperRoundValue()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
            var eachRound = rpsGame.GetComputerPick(playerPick);
            eachRound = rpsGame.GetComputerPick(playerPick);
            eachRound = rpsGame.GetComputerPick(playerPick);

            int gamePlayCount = new int();

            foreach (var round in rpsGame.Rounds)
            {
                gamePlayCount++;
            }
            var howManyRounds = rpsGame.Rounds.Count;

            Assert.Equal(gamePlayCount, howManyRounds);
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

        [Fact]
        public void CurrentRound_SecondRound_ShouldReturnOppositePick()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
            var eachRound = rpsGame.GetComputerPick(playerPick);
            eachRound = rpsGame.GetComputerPick(playerPick);

            var currentRound = rpsGame.CurrentRound.ComputerPick;

            Assert.NotEqual(playerPick, currentRound);

        }


        [Fact]
        public void IsGameOver()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
            var computerPick = rpsGame.GetComputerPick(playerPick);

            do
            {
                computerPick = rpsGame.GetComputerPick(playerPick);
            }

            while (rpsGame.IsGameOver != true);


            Assert.Throws<ApplicationException>(() => rpsGame.GetComputerPick(playerPick));
        }

        public static IEnumerable<object[]> enumValues()
        {
            foreach (var player in Enum.GetValues(typeof(Player)))
                yield return new object[] { player };

        }
        [Theory]
        [MemberData(nameof(enumValues))]
        public void Player_TestRound_EnumShouldBeSetToProperNumber(Player player)
        {

            Assert.NotNull(player);
            
        }



    }
}
