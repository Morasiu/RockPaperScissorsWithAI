using System;
using System.Collections.Generic;
using System.Linq;

namespace RPS {
    public class RPSGame {
        #region Public contructors

        public RPSGame () {
            score = new Score ();
            rounds = new List<Round> ();
            currentRound = new Round ();
        }

        #endregion

        #region Public variables

        public Score Score { get => score; }
        public List<Round> Rounds { get => rounds; }
        public Round CurrentRound { get => currentRound; }
        public bool IsGameOver { get => isGameOver; }
        public Player Winner { get => winner; }

        #endregion

        #region Public methods

        public Pick GetComputerPick (Pick playerPick) {
            if (isGameOver)
                throw new ApplicationException ("Game is over");

            Pick computerPick = Pick.Paper;
            // First round
            if (rounds.Count == 0) {
                computerPick = GetFirstRoundPick ();
            } else {
                var playerPicks = rounds
                    .Select (pick => pick.HumanPick)
                    .GroupBy (g => g)
                    .Select (g => new PickTimes () {
                        Pick = g.Key,
                            Times = g.Count ()
                    })
                    .OrderBy (pick => pick.Times)
                    .ToList ();

                if (playerPicks[0].Times == playerPicks[1].Times && playerPicks[1].Times == playerPicks[2].Times) {
                    // Set pick, that will lose with previous player pick
                    computerPick = GetLosingPick (GetLastPlayerPick ());
                } else if (playerPicks[0].Times < playerPicks[1].Times) {
                    computerPick = GetWinningPick (playerPicks[0].Pick);
                } else if (playerPicks[0].Times == playerPicks[1].Times) {
                    computerPick = GetDrawOrWinningPick (playerPicks[0].Pick, playerPicks[1].Pick);
                }
            }
            currentRound.ComputerPick = computerPick;
            currentRound.HumanPick = playerPick;
            RoundEnd ();
            return computerPick;
        }

        #endregion

        #region Private variables

        private Player winner;
        private List<Round> rounds;
        private Score score;
        private Round currentRound;
        private bool isGameOver;

        #endregion

        #region Private methods

        private void RoundEnd () {
            if (currentRound.HumanPick == GetWinningPick (currentRound.ComputerPick))
                score.HumanScore++;
            else if (currentRound.ComputerPick == GetWinningPick (currentRound.HumanPick))
                score.ComputerScore++;
            else {
                // Draw. Do nothing
            }

            if (score.ComputerScore == 3) {
                isGameOver = true;
                winner = Player.Computer;
            } else if (score.HumanScore == 3) {
                isGameOver = true;
                winner = Player.Human;
            }

            rounds.Add (currentRound);
            currentRound = new Round ();
        }

        private Pick GetLastPlayerPick () => rounds[rounds.Count - 1].HumanPick;

        private Pick GetLosingPick (Pick pick) {
            Pick losingPick;
            if (pick == Pick.Paper)
                losingPick = Pick.Rock;
            else if (pick == Pick.Rock)
                losingPick = Pick.Scissor;
            else if (pick == Pick.Scissor)
                losingPick = Pick.Paper;
            else
                throw new NotImplementedException ("Pick not recognized");
            return losingPick;
        }

        private Pick GetWinningPick (Pick pick) {
            Pick winningPick;
            if (pick == Pick.Paper)
                winningPick = Pick.Scissor;
            else if (pick == Pick.Rock)
                winningPick = Pick.Paper;
            else if (pick == Pick.Scissor)
                winningPick = Pick.Rock;
            else
                throw new NotImplementedException ("Pick not implemented");
            return winningPick;
        }

        private Pick GetDrawOrWinningPick (Pick pick1, Pick pick2) {
            Pick winningPick;

            if (pick1 == GetWinningPick (pick2))
                winningPick = pick1;
            else
                winningPick = pick2;
            return winningPick;
        }

        private Pick GetFirstRoundPick () {
            Pick firstRoundPick;
            var random = new Random ();
            var chance = random.Next (1, 101);
            // People mostly use rock or paper as first pick, so this is a counter for that.
            if (chance <= 40)
                firstRoundPick = Pick.Paper;
            else if (chance > 40 && chance <= 70)
                firstRoundPick = Pick.Rock;
            else
                firstRoundPick = Pick.Scissor;
            return firstRoundPick;
        }

        #endregion
    }

    public enum Player {
        Human,
        Computer
    }
}