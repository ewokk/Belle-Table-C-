using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe_valad
{
    class incidents
    {
        private int id;
        private string lieux;
        private string etat;
        private string description ;
        private int rapporteur;
        private DateTime date_incident;
        private DateTime date_resolution;

        public string Lieux { get; set; }
        public string Etat { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int Rapporteur { get; set; }
        public DateTime Date_incident { get; set; }
        public DateTime Date_resolution { get; set; }

        public incidents(int id,string lieux, string description, int rapporteur , string etat , DateTime date_incident , DateTime date_resolution)
        {
            Id                  =   id;
            Lieux               =   lieux;
            Description         =   description;
            Rapporteur          =   rapporteur;
            Etat                =   etat;
            Date_incident       =   date_incident;
            Date_resolution     =   date_resolution;
        }


    }
}
