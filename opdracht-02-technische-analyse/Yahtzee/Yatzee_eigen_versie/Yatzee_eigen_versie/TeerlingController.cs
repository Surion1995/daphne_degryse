using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Yatzee_eigen_versie
{
  public class TeerlingController
  {

    // Member die de view ontvangt 
    TeelingView view;
   
    public TeerlingModel model;

    public TeerlingController()
    {
      //maak nieuwe instantie aan van view
      view = new TeelingView(this);
      model = new TeerlingModel();
      
    }


    //methode die view van teerling returnt
    public TeelingView getView()
    {
      return view;
    }

    public void Werp()
    {
      
      if (!model.Vastgezet) { 
      Console.WriteLine("presenter spreekt controller aan");

      int aantalOgen =  StaticRandom.Instance.Next(1, 7);

      model.AantalOgen = aantalOgen;

      Console.WriteLine(aantalOgen);

      }
    }

    public int AantalOgen()
    {
      return model.AantalOgen;
    }

    public void Vastzetten()
    {
      model.KleurTeerling = System.Drawing.Color.Red;
      model.Vastgezet = true;
      
    }


  }
}
