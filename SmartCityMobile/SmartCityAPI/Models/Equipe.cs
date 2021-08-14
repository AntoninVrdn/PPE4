using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Equipe
    {
        public Equipe()
        {
            Appartenirs = new HashSet<Appartenir>();
            Jouers = new HashSet<Jouer>();
            ReponseJoueurs = new HashSet<ReponseJoueur>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Image { get; set; }
        public int? IdCreator { get; set; }
        public int? IdCapitaine { get; set; }

        public virtual Organisateur Organisateur { get; set; }
        public virtual ICollection<Appartenir> Appartenirs { get; set; }
        public virtual ICollection<Jouer> Jouers { get; set; }
        public virtual ICollection<ReponseJoueur> ReponseJoueurs { get; set; }
    }
}
