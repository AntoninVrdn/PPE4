using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Reponse
    {
        public Reponse()
        {
            Questions = new HashSet<Question>();
            ReponseJoueurs = new HashSet<ReponseJoueur>();
        }

        public int Id { get; set; }
        public int IdQuestion { get; set; }
        public string Intitule { get; set; }
        public string Photo { get; set; }

        public virtual Question Question{ get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ReponseJoueur> ReponseJoueurs { get; set; }
    }
}
