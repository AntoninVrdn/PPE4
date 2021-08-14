using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? IdEmetteur { get; set; }
        public int? IdRecepteur { get; set; }

        public virtual Contact Emetteur { get; set; }
        public virtual Contact Recepteur { get; set; }
    }
}
