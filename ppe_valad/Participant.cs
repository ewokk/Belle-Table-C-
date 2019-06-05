using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace ppe_valad
{
    public class Participant
    {
        private int Id;
        private string nom;
        private string prenom;
        private Session laSessionChoisie;
        private string nom_formation;
        private string session_date;
        private int session_Id;
        private string accepter;


        public int id { get; set; }
        public int Session_Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Nom_formation { get; set; }
        public string Session_date { get; set; }
        public string Accepter { get; set; }

        public Participant()
        {
            this.laSessionChoisie = null;
        }

        public Participant(string Nom, string Prenom, Session Session)
        {
            nom = Nom;
            prenom = Prenom;
            laSessionChoisie = Session;
        }

        public Participant(int Id ,string Nom, string Prenom, Session Session, string Nom_formation, string Session_date,int Session_Id, string Accepter)     
            {
            Id = id;
            nom = Nom;                                                
            prenom = Prenom;
            laSessionChoisie = Session;
            nom_formation = Nom_formation;
            session_date = Session_date;
            session_Id = Session_Id;
            accepter = Accepter  ;
        }

        public void SetParticipant(string Nom, string Prenom, Session Session)
        {
            nom = Nom;
            prenom = Prenom;
            laSessionChoisie = Session;
        }
        public void SetSession(Session Session)
        {
            laSessionChoisie = Session;
        }

        public string GetNom_Prenom()
        {
            return Nom + " " + Prenom;
        }
        public string StrParticipant()
        {
            return this.GetNom_Prenom();
        }

    }

}