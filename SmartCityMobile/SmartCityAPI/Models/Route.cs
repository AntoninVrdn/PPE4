using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Route
    {
        public Route()
        {
            Jeus = new HashSet<Jeu>();
            Steproutereports = new HashSet<Steproutereport>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public bool? Handicap { get; set; }
        public TimeSpan? Time { get; set; }
        public string Distance { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Name { get; set; }
        public int? IdCreator { get; set; }

        public virtual Organisateur Organisateur{ get; set; }
        public virtual ICollection<Jeu> Jeus { get; set; }
        public virtual ICollection<Steproutereport> Steproutereports { get; set; }
    }
}
