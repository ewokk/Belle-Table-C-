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
    public class Session
    {
        private int Id;
        private string DateDebut;
        private string DateFin;
        private string Lieux;
        private Formation laFormation;
        private List<Participant> lesParticipants;


        public int id { get; set; }
        public string dateFin { get; set; }
        public string dateDebut { get; set; }
        public string lieux { get; set; }

        public int Nbmax { get; set; }
        public Session()
        {
            this.lesParticipants = null;
        }
        public Session(string dateDebut, string dateFin, string lieux, Formation Formation)
        {
            DateDebut = dateDebut;
            DateFin = dateFin;
            Lieux = lieux;
            laFormation = Formation;
        }
        public void SetLesDates(string Debut, string Fin)
        {
            dateDebut = Debut;
            dateFin = Fin;
        }
        public void SetLieu(string lieu)
        {
            Lieux = lieux;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public void SetLaFormation(Formation Formation)
        {
            laFormation = Formation;
        }
        public void AjouterParticipant(Participant Participant)
        {
            lesParticipants.Add(Participant);
        }
        public string StrSession()
        {
            return laFormation.GetNom() + " " + lieux + " " + DateDebut + " " + DateFin;
        }
        public List<Participant> GetLesParticipants()
        {
            return lesParticipants;
        }
        public bool SupprimerParticipant(Participant Participant)
        {
            lesParticipants.Remove(Participant);
            return true;
        }
    }
}