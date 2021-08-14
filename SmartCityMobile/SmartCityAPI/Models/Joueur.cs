using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Joueur
    {
        public Joueur()
        {
            Appartenirs = new HashSet<Appartenir>();
            ReponseJoueurs = new HashSet<ReponseJoueur>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ICollection<Appartenir> Appartenirs { get; set; }
        public virtual ICollection<ReponseJoueur> ReponseJoueurs { get; set; }
    }
}
