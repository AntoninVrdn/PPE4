using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class ReponseJoueur
    {
        public int IdJoueur { get; set; }
        public int IdEquipe { get; set; }
        public int IdJeu { get; set; }
        public int IdMission { get; set; }
        public int IdQuestion { get; set; }
        public int? IdReponse { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public double? Lng { get; set; }
        public double? Lat { get; set; }
        public DateTime? Date { get; set; }
        public bool? Bonne { get; set; }

        public virtual Equipe Equipe{ get; set; }
        public virtual Jeu Jeu{ get; set; }
        public virtual Joueur Joueur{ get; set; }
        public virtual Mission Mission{ get; set; }
        public virtual Question Question{ get; set; }
        public virtual Reponse Reponse{ get; set; }
    }
}
