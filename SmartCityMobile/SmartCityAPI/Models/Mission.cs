using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Mission
    {
        public Mission()
        {
            Questions = new HashSet<Question>();
            ReponseJoueurs = new HashSet<ReponseJoueur>();
            Steps = new HashSet<Step>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public short? Score { get; set; }
        public TimeSpan? Time { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ReponseJoueur> ReponseJoueurs { get; set; }
        public virtual ICollection<Step> Steps { get; set; }
    }
}
