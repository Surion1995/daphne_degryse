﻿using System;
using System.Windows.Forms;

namespace Yahtzee
{
	public partial class YahtzeeView : Form
	{
		private YahtzeeController controller;

		public YahtzeeView(YahtzeeController c)
		{
			InitializeComponent();
			controller = c;
			MakeScoreboard();
			this.Location = new System.Drawing.Point((int)(this.Width * (controller.model.PlayerNumber / 5.0f)), (int)(this.Height * (controller.model.PlayerNumber / 5.0f))); //Elk scherm krijgt een eigen locatie.
			this.StartPosition = FormStartPosition.Manual; //Gebruikt de Location om de startpositie van het scherm te bepalen.
			this.Text = "Player " + (controller.model.PlayerNumber + 1);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			controller.ScoreChangedAll();
		}

		public void MakeDice(TeerlingView teerlingView, int i) //Laat teerlingen verschijnen
		{
			teerlingView.Location = new System.Drawing.Point(i * teerlingView.Width, teerlingView.Location.Y);
			flowLayoutPanel2.Controls.Add(teerlingView);
		}

		public void MakeScoreboard() //Laat scoreboard verschijnen
		{
			ScoreboardView scoreView = controller.GetScoreView();
			scoreView.Location = new System.Drawing.Point(100, 100);
			flowLayoutPanel1.Controls.Add(scoreView);
		}

		private void refresh_Click(object sender, EventArgs e)
		{
			controller.RefreshGame();
		}

		private void CloseForm(object sender, FormClosingEventArgs e) //Bij het sluiten van het scherm, kan de speler het opgeven.
		{
			DialogResult forfeit = MessageBox.Show("Do you want to stop?", "Warning: Forfeit", MessageBoxButtons.YesNo);
			if (forfeit == DialogResult.No) {
				e.Cancel = true;		//Stopt het sluiten van het formulier.
			}
			else if (forfeit == DialogResult.Yes) {
				controller.Forfeit();
			}
		}

		private void cheat_Click(object sender, EventArgs e)
		{
			controller.Cheat();
		}
	}
}
