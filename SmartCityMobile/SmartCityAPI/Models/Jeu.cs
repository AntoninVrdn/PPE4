using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Jeu
    {
        public Jeu()
        {
            Jouers = new HashSet<Jouer>();
            ReponseJoueurs = new HashSet<ReponseJoueur>();
        }

        public int Id { get; set; }
        public int IdRoute { get; set; }
        public DateTime? Tempsfinal { get; set; }
        public short? Scorefinal { get; set; }
        public DateTime? Datecreation { get; set; }

        public virtual Route Route { get; set; }
        public virtual ICollection<Jouer> Jouers { get; set; }
        public virtual ICollection<ReponseJoueur> ReponseJoueurs { get; set; }
    }
}
