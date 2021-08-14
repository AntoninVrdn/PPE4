using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Steproutereport
    {
        public Steproutereport()
        {
            ParcoursEquipes = new HashSet<ParcoursEquipe>();
        }

        public int Idroute { get; set; }
        public int Idstep { get; set; }

        public virtual Route Route{ get; set; }
        public virtual Step Step{ get; set; }
        public virtual ICollection<ParcoursEquipe> ParcoursEquipes { get; set; }
    }
}
