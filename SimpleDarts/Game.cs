using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDarts
{
    public class Game
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public Game()
        {
            this.Player1 = "Player 1";
            this.Player2 = "Player 2";
            this.Player1Score = 0;
            this.Player2Score = 0;
        }

        private void PlayOneGame()
        {
            Darts.Throw();
        }
    }
}