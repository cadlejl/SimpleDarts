using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PlayButton_Click1(object sender, EventArgs e)
        {
            Game game = new Game();
            game.PlayOneGame();
            int player1Score = game.Player1Score;
            int player2Score = game.Player2Score;
            string winner = "";
            if (player1Score > player2Score) winner = game.Player1 + " Wins!";
            if (player1Score < player2Score) winner = game.Player2 + " Wins!";
            if (player1Score == player2Score) winner = "It's a tie!";
            ResultLabel.Text = String.Format("{0} Score: {1}<br/>{2} Score: {3}<br/>{4}",
                game.Player1,
                player1Score,
                game.Player2,
                player2Score,
                winner);
        }
    }
}