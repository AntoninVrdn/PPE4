using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class EquipeGoodie
    {
        public int IdEquipe { get; set; }
        public int IdGoodies { get; set; }
        public DateTime DateObtention { get; set; }

        public virtual Equipe Equipe { get; set; }
        public virtual Goodie Goodie { get; set; }
    }
}
