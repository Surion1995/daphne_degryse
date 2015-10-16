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
      SetText();
			controller.ScoreChanged();
		}

		public void SetText()
		{
      throwns++;
      controller.Werp();
      int nieuwAantalOgen = controller.model.AantalOgen;
      TeerlingLabel.Text = nieuwAantalOgen.ToString();

			if (throwns == 3)
			{
        DisableThrow();
			}
		}

    private void DisableThrow()
    {
      controller.Vastzetten();
      TeerlingLabel.ForeColor = controller.model.KleurTeerling;
      if (!controller.model.isBtnVisible)
      {
        TeerlingWerpen.Hide();
      }
    }

		private void TeerlingLabel_Click(object sender, EventArgs e)
		{
      DisableThrow();		
		}

		public void SetIndexOfTeerling()
		{
			label1.Text = "Teerling: " + (controller.model.IndexOfTeerling + 1 );
		}
	}
}
