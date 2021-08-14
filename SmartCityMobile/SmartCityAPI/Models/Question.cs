using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Question
    {
        public Question()
        {
            ReponseJoueurs = new HashSet<ReponseJoueur>();
            Reponses = new HashSet<Reponse>();
        }

        public int Id { get; set; }
        public int? IdType { get; set; }
        public int? IdMission { get; set; }
        public int? IdBonneReponse { get; set; }
        public short? Score { get; set; }
        public string Intitule { get; set; }

        public virtual Reponse BonneReponse{ get; set; }
        public virtual Mission Mission{ get; set; }
        public virtual Type Type{ get; set; }
        public virtual ICollection<ReponseJoueur> ReponseJoueurs { get; set; }
        public virtual ICollection<Reponse> Reponses { get; set; }
    }
}
