using System;
using System.Collections.Generic;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Contact
    {
        public Contact()
        {
            MessageEmetteur = new HashSet<Message>();
            MessageRecepteur = new HashSet<Message>();
        }

        public int Id { get; set; }

        public virtual Joueur Joueur { get; set; }
        public virtual Organisateur Organisateur { get; set; }
        public virtual ICollection<Message> MessageEmetteur { get; set; }
        public virtual ICollection<Message> MessageRecepteur { get; set; }
    }
}
