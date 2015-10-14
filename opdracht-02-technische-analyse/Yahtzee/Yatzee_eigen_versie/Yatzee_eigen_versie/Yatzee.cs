using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzee_eigen_versie
{
  public partial class Yatzee : Form
  {
    List<TeerlingController> teerlingen = new List<TeerlingController>();
    int aantalWorpen;
    int maxWorpen = 3;
    int Score = 0;
    int Highscore = 0;

    public Yatzee()
    {
      InitializeComponent();
    
      int aantalTeerlingen = 3;

      //teerlingen tonen
      for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
      {
        
        teerlingen.Add(new TeerlingController());

        // maak instantie aan van TeerlingControlle
        TeelingView teerling = teerlingen[teerlingNummer].getView();

        // breedte van teerling ophalen en positie berekenen
        int horizontalPosition = teerlingNummer * teerling.Width;

        teerling.Location = new System.Drawing.Point(horizontalPosition, 0);

        Controls.Add(teerling);
        
      }

     
    }

    private void WerperAll_Click(object sender, EventArgs e)
    {

      if (aantalWorpen < maxWorpen)
      {
        foreach (TeerlingController teerling in teerlingen)
        {
          teerling.Werp();
          teerling.getView().updateUI();
        }

        aantalWorpen++;
        UpdateAantalWorpen();
        Refresh();
        UpdateScore();
        HighScore();
      }

      else
      {
        foreach (TeerlingController teerling in teerlingen)
        {
          teerling.Vastzetten();
        }
      }

    }


    // elke keer als een dobbelsteen rolt wordt het getelt;
    public void UpdateAantalWorpen()
    {

             worpen.Text = aantalWorpen.ToString();
      
    }

    //score

    public void UpdateScore()
    {
      ScorCounting();
      score.Text = Score.ToString();
    }

    public void ScorCounting()
    {
     
      foreach (TeerlingController teerling in teerlingen)
      {
        Score += teerling.AantalOgen();
      }

      Console.Write("score = " + Score);
    }

    public void HighScore()
    {

      if (Highscore < Score){
        Highscore = Score;
        high.Text = Score.ToString();
      }

      else{}
      
    }

    private void Yatzee_Load(object sender, EventArgs e)
    {
      
    }


    // herstarten

    private void Refresh()
    {
      Score = 0;
    }


    //om de werp knoppen te laten verdwijnenen en verschijnen
    private void Yatzee_Click(object sender, EventArgs e)
    {
      Console.WriteLine("Daphne");

        foreach (TeerlingController teerling in teerlingen)
        {
          teerling.getView().revealButtons();
        }
 
    }

    }




  }

