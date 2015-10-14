using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzee_eigen_versie
{
  public partial class TeelingView : UserControl
  {
    private TeerlingController controller;
    public TeelingView (TeerlingController c)
    {
      InitializeComponent();
      controller = c;

    }

    private void TeelingView_Load(object sender, EventArgs e)
    {

    }


    private void werp_Click(object sender, EventArgs e)
    {

      controller.Werp();

      updateUI();

    }

    private void teerling_Click(object sender, EventArgs e)
    {
      controller.Vastzetten();
      teerling.ForeColor = controller.model.KleurTeerling;
      
    }

    // voor   alle stenen
    public void updateUI()
    {
      int nieuwAantalOgen = controller.model.AantalOgen;

      teerling.Text = nieuwAantalOgen.ToString();

      
    }

    public void revealButtons(){

     // de visibility van werp aanspreken.

      if (!controller.model.Visible)
      {
          controller.model.Visible = true;
        }
        else{
          controller.model.Visible = false;
        }

        werp.Visible = controller.model.Visible;

    }



  }
}
