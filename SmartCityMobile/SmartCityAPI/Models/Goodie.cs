using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Goodie
    {
        public Goodie()
        {
            EquipeGoodies = new HashSet<EquipeGoodie>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EquipeGoodie> EquipeGoodies { get; set; }
    }
}
