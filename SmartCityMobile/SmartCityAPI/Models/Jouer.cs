using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Jouer
    {
        public Jouer()
        {
            ParcoursEquipes = new HashSet<ParcoursEquipe>();
        }

        public int IdJeux { get; set; }
        public int IdEquipe { get; set; }
        public int? Score { get; set; }
        public DateTime? Datedebut { get; set; }
        public DateTime? Datefin { get; set; }

        public virtual Equipe Equipe { get; set; }
        public virtual Jeu Jeux { get; set; }
        public virtual ICollection<ParcoursEquipe> ParcoursEquipes { get; set; }
    }
}
