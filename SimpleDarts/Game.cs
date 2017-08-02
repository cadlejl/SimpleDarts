using System;
using System.Linq;
using Darts;


namespace SimpleDarts
{
    public class Game
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        private Random _random;

        public Game()
        {
            this.Player1 = "Player 1";
            this.Player2 = "Player 2";
            this.Player1Score = 0;
            this.Player2Score = 0;
            this._random = new Random();
        }

        public void PlayOneGame(/*int Player1Score, int Player2Score*/)
        {
            while ((Player1Score < 300) && (Player2Score < 300))
            {
                Player1Score += TakeATurn();
                Player2Score += TakeATurn();
            }
        }

        int TakeATurn()
        {
            int[] scoreOneTurn = new int[]
            {
                ThrowOneDart(),
                ThrowOneDart(),
                ThrowOneDart()
            };

            return scoreOneTurn.Sum();
        }

        private int ThrowOneDart()
        {
            Dart dart = new Dart();
            Score score = new Score();

            dart.Throw(_random);
            score.CalculateScore(dart);

            int scoreOneThrow = score.HitScore;
            return scoreOneThrow;
        }
    }
}