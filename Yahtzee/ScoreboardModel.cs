using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
	public class ScoreboardModel
	{
		private int[] numbers = new int[6];
		private int score, highscore;
		public int Score { get { return score; } set {score = value; } }
		public int Highscore { get { return highscore; } set { highscore = value; } }
		public int[] Numbers
		{
			get { return numbers; }
			set { numbers = value; }
		}

	}
}
