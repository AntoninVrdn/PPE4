using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Organisateur
    {
        public Organisateur()
        {
            Equipes = new HashSet<Equipe>();
            Routes = new HashSet<Route>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual Contact IdNavigation { get; set; }
        public virtual ICollection<Equipe> Equipes { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
    }
}
