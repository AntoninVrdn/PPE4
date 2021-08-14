using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Tag
    {
        public Tag()
        {
            Taggedreports = new HashSet<Taggedreport>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Taggedreport> Taggedreports { get; set; }
    }
}
