using System;

namespace Yahtzee
{
	
	public class TeerlingController
	{
		static int seed = 0;
		int aantalOgen = 0;
		public int AantalOgen { get { return aantalOgen; }  }
										   //member die de view opvangt
		private TeerlingView view;
		public TeerlingModel model;
		Yahtzee yahtzeeclass;
		public TeerlingController(int i, Yahtzee y)
		{
			view = new TeerlingView(this);
			model = new TeerlingModel();
			model.IndexOfTeerling = i;
			view.SetIndexOfTeerling();
			yahtzeeclass = y;
		}

		public TeerlingView getView()
		{
			return view;
		}

		public void Werp()
		{
			if (!model.Vastgezet)
			{
				//Nieuwe instantie van Random object genereren
				Random random = new Random(seed++);

				//Random getal genereren tussen 1 & 6
				int aantalOgen = random.Next(1, 7);

				//Het model updaten
				model.AantalOgen = aantalOgen;
				Console.WriteLine(aantalOgen + "Presenter spreekt controller aan. Kom dat zien, kom dat zien :)");
			}
		}

		public void Vastzetten()
		{
			model.KleurTeerling = System.Drawing.Color.Red;
			model.Vastgezet = true;
			model.isBtnVisible = false;
		}

		public void ScoreChanged()
		{
			yahtzeeclass.ScoreChanged();
		}
	}
}
