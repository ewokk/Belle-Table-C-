using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe_valad
{
    public class connexion
    {

        private int id;
        private string login;
        private string mdp;
        private int type_user;
        private int tentative;
        private int bloquer;
        private DateTime date_tentative;

        public string Login { get; set; }
        public string Mdp { get; set; }
        public int Id { get; set; }
        public int Type_user { get; set; }
        public int Tentative { get; set; }
        public int Bloquer { get; set; }
        public DateTime Date_tentative { get; set; }


        public connexion(string Login, string Mdp, int Type_user , int Id, int tentative , DateTime date_tentative, int bloquer)
        {
            login           =   Login;
            mdp             =   Mdp;
            type_user       =   Type_user;
            id              =   Id;
            tentative       =   Tentative;
            date_tentative  =   Date_tentative;
            bloquer         =   Bloquer;
        }
        public connexion(int Id)
        {
            tentative = Tentative;
        }

        public connexion()
        {
            this.login = "Inconnue";
            this.mdp = "Inconnue";
            this.type_user = 0 ;
            this.tentative = 0;
            
        }

        public string GetLogin()
        {
            return login;
        }
        public string GetMdp()
        {
            return mdp;
        }
        public int GetType_user()
        {
            return type_user;
        }

        public int GetId()
        {
            return id;
        }

    }
}
