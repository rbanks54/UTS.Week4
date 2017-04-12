using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTS.WebGuessGame
{
    public partial class WebGame : System.Web.UI.Page
    {
        private Game game = new Game();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                game.Start();
                if (Session["game"] == null)
                {
                    Session["game"] = game;
                }
                //var cookie = new HttpCookie("GameGuess", game.Number.ToString());
                //cookie.Expires = DateTime.Now.AddMinutes(10.0);
                //Response.SetCookie(cookie);
            }
            else
            {
                game = (Game)Session["game"];
                //var guess = Request.Cookies["GameGuess"].Value;
                //game.Number = int.Parse(guess);
            }
        }

        protected void GuessButton_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(GuessTextBox.Text);
            ResultLabel.Text = game.Guess(guess).ToString();
        }

        protected void NewGameButton_Click(object sender, EventArgs e)
        {
            game.Start();
        }
    }
}