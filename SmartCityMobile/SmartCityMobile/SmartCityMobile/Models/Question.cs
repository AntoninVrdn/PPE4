using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCityMobile.Models
{
    public class Question
    {
        public int ID { get; set; }
        public int IdJ { get; set; }
        public int ID_TYPE { get; set; }
        public int ID_MISSION { get; set; }
        public int ID_BONNE_REPONSE { get; set; }
        public int SCORE { get; set; }
        public string INTITULE { get; set; }
        public string INTITULE_REP { get; set; }
    }
}
