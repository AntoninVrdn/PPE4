using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class ParcoursEquipe
    {
        public int IdJeu { get; set; }
        public int IdEquipe { get; set; }
        public int? IdRoute { get; set; }
        public int? IdStep { get; set; }
        public int Ordre { get; set; }
        public DateTime? Datevalidation { get; set; }

        public virtual Jouer Jouer { get; set; }
        public virtual Steproutereport Steproutereport { get; set; }
    }
}
