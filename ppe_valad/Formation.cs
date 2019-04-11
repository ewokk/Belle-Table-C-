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
    public class Formation
    {
        //private int Id;
        private string Nom;
        private int Niveau;
        private List<Session> lesSessions;
        private List<Participant> lesParticipantsvoulu;

        public string nom { get; set; }
        public string niveau { get; set; }

        public string id { get; set; }
    

        public Formation()
        {
            this.lesSessions = null;
        }
        public string GetNom()
        {
            return Nom;
        }
        public string GetNom_Niveau()
        {
            return Nom + " " + Niveau;
        }
        public Formation(string nom, int niveau)
        {
            Nom = nom;
            Niveau = niveau;
        }
        public Formation(string nom)
        {
            Nom = nom;
        }
        public void SetNom(string nom)
        {
            Nom = nom;
        }
        public string StrFormation()
        {
            return this.GetNom_Niveau();
        }
        public void SetLeNiveau(int niveau)
        {
            Niveau = niveau;
        }
        public List<Session> GetlesSessions()
        {
            return lesSessions;
        }

       

       
    }
}
    