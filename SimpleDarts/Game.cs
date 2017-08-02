using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThrowDart;

namespace SimpleDarts
{
    public class Game
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public Random Random { get; set; }

        public Game()
        {
            this.Player1 = "Player 1";
            this.Player2 = "Player 2";
            this.Player1Score = 0;
            this.Player2Score = 0;
            this.Random = new Random();
        }

        private void PlayOneGame()
        {
            Player1Score += TakeATurn();
            Player2Score += TakeATurn();

        }

        int TakeATurn()
        {
            int[] scoreOneTurn = new int[] { ThrowOneDart(), ThrowOneDart(), ThrowOneDart() };
            return scoreOneTurn.Sum();
        }

        private int ThrowOneDart()
        {
            Dart dart = new Dart();
            Score score = new Score();
            dart.Throw(Random);
            int scoreOneThrow = score.CalculateScore(dart);
            return scoreOneThrow;
        }
    }
}