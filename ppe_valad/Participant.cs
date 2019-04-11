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
        private int id;
        private string nom;
        private string prenom;
        private Session laSessionChoisie;

        public int Id { get; set; }
        public int Id_Session { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }

        public Participant()
        {
            this.laSessionChoisie = null;
        }

        public Participant(string Nom, string Prenom, Session Session )
        {
        nom                 =    Nom;
        prenom              =    Prenom;
        laSessionChoisie    =    Session;
        }

       public void SetParticipant(string Nom, string Prenom, Session Session)
    {
        nom                 =    Nom;
        prenom              =    Prenom;
        laSessionChoisie    =    Session;
    }
    public void SetSession(Session Session)
    {
        laSessionChoisie    =    Session;
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
