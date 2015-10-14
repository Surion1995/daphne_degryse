using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Yahtzee
{
	public partial class Yahtzee : Form
	{
		private List<TeerlingController> teerlingen = new List<TeerlingController>();
		private const int aantalTeerlingen = 6, aantalWorpen = 0;
		ScoreboardController Scoreboard = new ScoreboardController();
		public Yahtzee()
		{
			InitializeComponent();

			for (int i = 0; i < aantalTeerlingen; i++)
			{
				//Maak instantie aan van TeerlingController
				//Voeg teerling toe aan het formulier
				teerlingen.Add(new TeerlingController(i, this));

				TeerlingView teerlingView = teerlingen[i].getView();
				teerlingView.Location = new System.Drawing.Point(i * teerlingView.Width, teerlingView.Location.Y);
				flowLayoutPanel2.Controls.Add(teerlingView);

			}

			ScoreboardView scoreboardView = Scoreboard.getView();
			scoreboardView.Location = new System.Drawing.Point(5, 5);
			flowLayoutPanel1.Controls.Add(scoreboardView);
		}

		public void ScoreChanged()
		{
			for (int i = 0; i < aantalTeerlingen; i++)
			{
				Scoreboard.ChangeScore(i, teerlingen[i].model.AantalOgen);
			}
			Scoreboard.UpdateScore();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			for (int i = 0; i < aantalTeerlingen; i++)
			{
				teerlingen[i].getView().SetText();
				Scoreboard.ChangeScore(i, teerlingen[i].model.AantalOgen);
			}
			Scoreboard.UpdateScore();

		}
	}
}
