using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Appartenir
    {
        public int IdEquipe { get; set; }
        public int IdJoueur { get; set; }

        public virtual Equipe Equipe { get; set; }
        public virtual Joueur Joueur { get; set; }
    }
}
