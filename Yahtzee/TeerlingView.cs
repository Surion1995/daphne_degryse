using System;
using System.Windows.Forms;

namespace Yahtzee
{
	public partial class TeerlingView : UserControl
	{
		private int throwns = 0;
		private TeerlingController controller;

		public TeerlingView(TeerlingController c)
		{
			InitializeComponent();
			controller = c;
		}

		private void TeerlingWerpen_Click(object sender, EventArgs e)
		{
			
			if (throwns == 2)
			{
				throwns++;
				controller.Werp();
				int nieuwAantalOgen = controller.model.AantalOgen;
				TeerlingLabel.Text = nieuwAantalOgen.ToString();
				controller.Vastzetten();
				TeerlingLabel.ForeColor = controller.model.KleurTeerling;
				if (!controller.model.isBtnVisible)
				{
					TeerlingWerpen.Hide();
				}
			}
			else
			{
				throwns++;
				controller.Werp();
				int nieuwAantalOgen = controller.model.AantalOgen;
				TeerlingLabel.Text = nieuwAantalOgen.ToString();
			}
			controller.ScoreChanged();
		}

		public void SetText()
		{
			if (throwns == 2)
			{
				throwns++;
				controller.Werp();
				int nieuwAantalOgen = controller.model.AantalOgen;
				TeerlingLabel.Text = nieuwAantalOgen.ToString();
				controller.Vastzetten();
				TeerlingLabel.ForeColor = controller.model.KleurTeerling;
				if (!controller.model.isBtnVisible)
				{
					TeerlingWerpen.Hide();
				}
			}
			else
			{
				throwns++;
				controller.Werp();
				int nieuwAantalOgen = controller.model.AantalOgen;
				TeerlingLabel.Text = nieuwAantalOgen.ToString();
			}
		}

		private void TeerlingLabel_Click(object sender, EventArgs e)
		{
			controller.Vastzetten();
			TeerlingLabel.ForeColor = controller.model.KleurTeerling;
			if (!controller.model.isBtnVisible)
			{
				TeerlingWerpen.Hide();
			}
			
		}

		public void SetIndexOfTeerling()
		{
			label1.Text = "Teerling: " + controller.model.IndexOfTeerling;
		}
	}
}
