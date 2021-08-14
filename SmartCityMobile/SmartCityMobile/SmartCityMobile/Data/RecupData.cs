using Newtonsoft.Json;
using SmartCityMobile.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace SmartCityMobile.Data
{
    public class RecupData : Call
    {
        public static List<Jeu> LstJeu;
        public static List<Identifiant> LstIdentifiants;
        string flux;
        Stream stream;
        Assembly assembly = typeof(App).GetTypeInfo().Assembly;
        StreamReader reader;

        public void RecupLesGames()
        {
            LstJeu = new List<Jeu>();
            stream = assembly.GetManifestResourceStream("SmartCityMobile.FichierDataLocal.Jeux.json");
            reader = new StreamReader(stream);
            flux = reader.ReadToEnd();
            LstJeu = JsonConvert.DeserializeObject<List<Jeu>>(flux);
        }

        public void RecupLesIdentifiants()
        {
            LstIdentifiants = new List<Identifiant>();
            stream = assembly.GetManifestResourceStream("SmartCityMobile.FichierDataLocal.Organisateurs.json");
            reader = new StreamReader(stream);
            flux = reader.ReadToEnd();
            LstIdentifiants = JsonConvert.DeserializeObject<List<Identifiant>>(flux);

        }

        public static int Connection(string login, string mdp)
        {
            string url = "api/Connexion?login=" + login +"&mdp=" + mdp;
            var answer = GetDataFromHttpClient(url);
            var result = JsonConvert.DeserializeObject<dynamic>(answer);

            if (result.status == 200) return 1; // 1 connection ok 0 login et mdp different
            else return 0;
        }
    }
}
