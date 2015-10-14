using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Yatzee_eigen_versie
{
  public class TeerlingModel
  {
    private int aantalOgen;
    private Color kleurteerling;
    private bool vastgezet = false;
    private bool visible = false;

    public int AantalOgen{
      get{ return aantalOgen;}
      set { aantalOgen = value;}
    }

    public Color KleurTeerling{
      get { return kleurteerling; }
      set { kleurteerling = value;}
    }

    public bool Vastgezet
    {
      get { return vastgezet; }
      set { vastgezet = value; }
    }

    public bool Visible
    {
      get { return visible; }
      set { visible = value; }
    }


  }
}
