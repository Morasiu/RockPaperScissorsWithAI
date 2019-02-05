using System;
using System.Collections.Generic;
using Xunit;
using RPS;

namespace RPSClassLib.Tests
{
    public class RSPGameTest
    {
		// Ładny test, chyba mój
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

		// "ShouldReturnRoundProperRoundValue"
		// Round and Round
		// https://www.youtube.com/watch?v=0u8teXR8VE4
		// -> (...)_ShouldReturnProperRoundCount
		[Fact]
        public void Rounds_ThirdRound_ShouldReturnRoundProperRoundValue()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
            var eachRound = rpsGame.GetComputerPick(playerPick);
            eachRound = rpsGame.GetComputerPick(playerPick);
            eachRound = rpsGame.GetComputerPick(playerPick);

			// magia, można zrobić po prostu wywołanie metody, bez przypisania
			// rpsGame.GetComputerPick(playerPick);
			// rpsGame.GetComputerPick(playerPick);
			// rpsGame.GetComputerPick(playerPick);

			// Najlepiej użyć tego
			//int expectedRoundCount = 3;
			//for(int i = 0; i < expectedRoundCount; i++) {
			//	rpsGame.GetComputerPick(playerPick);
			//}
			// i spójność danych zachowana


			// eee... to nie dżawa. Zrób gamePlayCount = 0;
			int gamePlayCount = new int();

			// Do kosza?
            foreach (var round in rpsGame.Rounds)
            {
                gamePlayCount++;
            }

			// what?
			// Okej... zamiast tego polecam użyć
			// var expectedRoundCount = 3;
            var howManyRounds = rpsGame.Rounds.Count;

            Assert.Equal(gamePlayCount, howManyRounds);
        }

		// Ładny test. Nie ma się do czego przyczepić.
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

		// Ten też spoko 
        [Fact]
        public void GetComputerPick_SecondRound_ShouldReturnRock()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
			// Przypominam, że można zrobić po prostu wywołanie, bez przypisania do zmiennej
			// rpsGame.GetComputerPick(playerPick);
			var computerPick = rpsGame.GetComputerPick(playerPick);
            computerPick = rpsGame.GetComputerPick(playerPick);

			// Żeby było ładnie można zrobić
			// Pick expectedPick = Pick.Rock;
			// i potem jest użyć niżej.
            Assert.Equal(Pick.Rock, computerPick);
        }

		// Ładnie. Obszedłeś randomowy wybór na początku :) 
        [Fact]
        public void CurrentRound_SecondRound_ShouldReturnOppositePick()
        {
            var rpsGame = new RPSGame();
            var playerPick = Pick.Paper;
            var eachRound = rpsGame.GetComputerPick(playerPick);
            eachRound = rpsGame.GetComputerPick(playerPick);

			// -> computerPick
            var currentRound = rpsGame.CurrentRound.ComputerPick;

            Assert.NotEqual(playerPick, currentRound);
        }

		// Szalony test. Ale działa
		// Tylko nazwa słaba
		// IsGameOver_GetComputerPickAfterGameOver_ShouldThrowApplicationException
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
			// Eee... Użyj tego, bo tamto boli:
			// !rpsGame.IsGameOver
			// Ps. to drugi poziom mema https://pics.me.me/if-condition-f-if-conditiontrue-if-condition-true-66-condition-37268147.png
			while(rpsGame.IsGameOver != true);

			// Nawet assert wyjątku zrobiłeś. Nieźle
			// Można też zrobić tak:
			//Action getPickAfterGameOver = () => rpsGame.GetComputerPick(playerPick);
			// To tylko zmienna. Nic się tam nie wykonuje jeszcze. Potem dajesz ją do tego asserta.
			//Assert.Throws<ApplicationException>(getPickAfterGameOver);

			Assert.Throws<ApplicationException>(() => rpsGame.GetComputerPick(playerPick));
        }

		// Co to jest? Do kosza to
        public static IEnumerable<object[]> enumValues()
        {
            foreach (var player in Enum.GetValues(typeof(Player)))
                yield return new object[] { player };

        }

		// Do kosza. Enumów się nie testuje raczej.
        [Theory]
        [MemberData(nameof(enumValues))]
        public void Player_TestRound_EnumShouldBeSetToProperNumber(Player player)
        {
            Assert.NotNull(player);
        }

		// Podsumowanie:
		// Ogólnie spoko. Kilka spoko testów. Małe błędy, ale ok.
		// Przyda sie więcej testów. Im więcej tym lepiej!

    }
}
