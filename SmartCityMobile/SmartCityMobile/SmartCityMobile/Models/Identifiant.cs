using SmartCityMobile.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCityMobile.Models
{
    public class Identifiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public Identifiant()
        {
                
        }

        public bool VerifConnexion(string login, string password)
        {
            //il faut récupérer la liste des organisateurs, puis parcourir la liste et pour chaque organisateur on va regarder si son login et son password son
            //égaux à ceux rentré
            var result = false;

            List<Identifiant> resultListe = RecupData.LstIdentifiants;

            foreach (var item in resultListe)
            {
                if (login == item.Login && password==item.Password )
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
