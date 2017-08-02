using System;

namespace SimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        public Game Game { get; set; }
        //public Game PlayOneGame { get; set; }
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public String Winner { get; set; }

        //Tried to make a constructor, to disastrous effect
        //public Default()
        //{
        //    this.Game = new Game();
        //    this.Player1 = Game.Player1;
        //    this.Player2 = Game.Player2;
        //    //this.Player1Score = 0;//Game.Player1Score;
        //    //this.Player2Score = 0;//Game.Player2Score;
        //    this.Winner = "";
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void PlayButton_Click1(object sender, EventArgs e)
        {
            Game Game = new Game();

            Game.PlayOneGame(/*Player1Score, Player2Score*/);

            Player1 = Game.Player1;
            Player2 = Game.Player2;
            Player1Score = Game.Player1Score;
            Player2Score = Game.Player2Score;

            ShowResults();
        }

        private void ShowResults()
        {
            String Winner = "";
            if (Player1Score > Player2Score) Winner = Player1 + " Wins!";
            else if (Player1Score < Player2Score) Winner = Player2 + " Wins!";
            else Winner = "It's a tie!";

            ResultLabel.Text = String.Format("{0} Score: {1}<br/>{2} Score: {3}<br/>{4}",
                Player1, Player1Score, Player2, Player2Score, Winner);
        }
    }
}