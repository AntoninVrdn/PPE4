using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCityMobile.Models
{
    public class Jeu
    {
      public int ID { get; set; }
      public int ID_ROUTE { get; set; }
      public DateTime TEMPSFINAL { get; set; }
      public int SCOREFINAL { get; set; }
      public DateTime DATECREATION { get; set; }
    }
}
