using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Step
    {
        public Step()
        {
            Steproutereports = new HashSet<Steproutereport>();
            Taggedreports = new HashSet<Taggedreport>();
        }

        public int Id { get; set; }
        public string Coordgps { get; set; }
        public string Description { get; set; }
        public string Validation { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Name { get; set; }
        public int? Missionid { get; set; }

        public virtual Mission Mission { get; set; }
        public virtual ICollection<Steproutereport> Steproutereports { get; set; }
        public virtual ICollection<Taggedreport> Taggedreports { get; set; }
    }
}
