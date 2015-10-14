namespace Yahtzee
{
	partial class ScoreboardView
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblScore = new System.Windows.Forms.Label();
			this.lblHighscore = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(45, 29);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(47, 13);
			this.lblScore.TabIndex = 0;
			this.lblScore.Text = "Score: 0";
			// 
			// lblHighscore
			// 
			this.lblHighscore.AutoSize = true;
			this.lblHighscore.Location = new System.Drawing.Point(48, 87);
			this.lblHighscore.Name = "lblHighscore";
			this.lblHighscore.Size = new System.Drawing.Size(67, 13);
			this.lblHighscore.TabIndex = 1;
			this.lblHighscore.Text = "Highscore: 0";
			// 
			// ScoreboardView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblHighscore);
			this.Controls.Add(this.lblScore);
			this.Name = "ScoreboardView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblHighscore;
	}
}
