using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using System.Data.Common;

namespace ppe_valad
{
    class DBMySQLUtils
    {
        //instancie la classe Mysql qu'on vient de rajouter pour pouvoir utiliser la "ConnectionString"//
        private MySqlConnection dbconnection;

        public void InitDb()
        {
            String connString = "Server='127.0.0.1'; User='root'; Password=''; Database='ppe_valad'; SslMode=none";
            dbconnection = new MySqlConnection(connString);
        }

        public void Insert_incidents(string Lieux, string Etat, string Description, int Rapporteur, DateTime Date_incident)
        {
            dbconnection.Open();
            String strQuery = "INSERT INTO incidents(id ,lieux ,description ,rapporteur ,etat ,date_incident ,date_resolution ) VALUES(NULL , @Thelieux ,@Thedescription,@Therapporteur,@Theetat,@Thedate_incident,NULL)";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Thelieux",           Lieux);
            DynamicParameters.Add("Thedescription",     Description);
            DynamicParameters.Add("Therapporteur",      Rapporteur);
            DynamicParameters.Add("Theetat",            Etat);
            DynamicParameters.Add("Thedate_incident",   Date_incident);
            dbconnection.Query<incidents>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();

        }

        public void Insert_postuler(int Id_Participant, int Id_Session)
        {
            dbconnection.Open();
            String strQuery = "INSERT INTO candidater(id ,accepter ,Id_Participant ,Id_Session ) VALUES(NULL , NULL ,@TheId_Participant,@TheId_Session)";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("TheId_Participant",  Id_Participant);
            DynamicParameters.Add("TheId_Session",      Id_Session);
            dbconnection.Query<Participant>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }
        public void update_postuler(int Id_Participant, int Id_Session, string motif,string accepter)
        {
            dbconnection.Open();
            String strQuery = "UPDATE candidater SET accepter = '@accepter' ,motif_refus=@Themotif  WHERE Id = @TheId_Participant and Id_Session = @TheId_Session";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("TheId_Participant", Id_Participant);
            DynamicParameters.Add("TheId_Session", Id_Session);
            DynamicParameters.Add("Themotif", motif);
            DynamicParameters.Add("accepter", accepter);
            dbconnection.Query<Participant>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }
        public void delete_postuler(int Id_Participant, int Id_Session)
        {
            dbconnection.Open();
            String strQuery = "DELETE FROM candidater WHERE Id_Participant=@TheId_Participant and Id_Session=@TheId_Session";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("TheId_Participant", Id_Participant);
            DynamicParameters.Add("TheId_Session", Id_Session);
            dbconnection.Query<Participant>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }



        public List<Session> Select_session_lié_compte(int id_participant)
        {
            dbconnection.Open();
            List<Session> Messessions = new List<Session>();
            String strQuery = "select * from Session where id in (  select id_session from candidater where id_participant = @id)";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("id",     id_participant);
            Messessions = dbconnection.Query<Session>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
            return Messessions;
        }



        public void Insert_user(string login, string mdp , DateTime date_tentative)
        {
            dbconnection.Open();
            String strQuery = "INSERT INTO user (login, mdp, type_user, id,tentative,date_tentative) VALUES (@Thelogin,@Themdp, '0', NULL,0,@Thedate);";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Thelogin",   login);
            DynamicParameters.Add("Themdp",     mdp);
            DynamicParameters.Add("Thedate",    date_tentative);
            dbconnection.Query<connexion>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }

        public void Insert_participant(string Nom, string Prenom)
        {
            dbconnection.Open();
            String strQuery = "INSERT INTO participant (Nom, Prenom) VALUES (@TheNom,@ThePrenom);";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("TheNom",     Nom);
            DynamicParameters.Add("ThePrenom",  Prenom);
            dbconnection.Query<Participant>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }

        public void Insert_souhait(int id_formation, int id_participant)
        {
            dbconnection.Open();
            String strQuery = "INSERT INTO souhait (id_formation, id_participant) VALUES (@Theid_formation,@Theid_participant);";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Theid_formation", id_formation);
            DynamicParameters.Add("Theid_participant", id_participant);
            dbconnection.Query<Participant>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }

        public void New_mdp(int Id,string mdp)
        {
            dbconnection.Open();
            String strQuery = "UPDATE user SET mdp = @Themdp  WHERE id = @Theid;";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Theid",      Id);
            DynamicParameters.Add("Themdp",     mdp);
            dbconnection.Query<connexion>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }

        public void mjr_tentativeetdate(int Id)
        {
            dbconnection.Open();
            DateTime datenow = DateTime.Now;
            String strQuery = "UPDATE user SET tentative = 0 , date_tentative = @Thedatenow , bloquer =0 WHERE id = @Theid;";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Theid",          Id);
            DynamicParameters.Add("Thedatenow",     datenow);
            dbconnection.Query<connexion>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }
        public void mjr_tentative(int Id ,int tentative)
        {
            dbconnection.Open();
            String strQuery = "UPDATE user SET tentative = @Thetentative, bloquer = 0 WHERE id = @Theid;";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Theid",          Id);
            DynamicParameters.Add("Thetentative",   tentative);
            dbconnection.Query<connexion>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }
        public void mjr_bloquer(int Id)
        {
            dbconnection.Open();
            String strQuery = "UPDATE user SET bloquer = 1 WHERE id = @Theid;";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Theid", Id);
            dbconnection.Query<connexion>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }

        public void Update_incidents(int Id ,DateTime Date_resolution)
        {
            dbconnection.Open();
            String strQuery = "UPDATE incidents SET date_resolution = @Thedate_resolution ,etat='résolu'  WHERE id = @Theid;";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Thedate_resolution", Date_resolution);
            DynamicParameters.Add("Theid", Id);
            dbconnection.Query<incidents>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }

        public void Update_habilitations(int Id, int habilitation)
        {
            dbconnection.Open();
            String strQuery = "UPDATE user SET type_user = @Thehabilitation WHERE id = @Theid;";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Thehabilitation", habilitation);
            DynamicParameters.Add("Theid", Id);
            dbconnection.Query<connexion>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }

        public void Update_participant(int Id, string nom , string prenom)
        {
            dbconnection.Open();
            String strQuery = "UPDATE participant SET nom = @Thenom , prenom = @Theprenom  WHERE id = @Theid;";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Thenom", nom);
            DynamicParameters.Add("Thenom", nom);
            DynamicParameters.Add("Theid", Id);
            dbconnection.Query<connexion>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }

        public List<incidents> SellectincidentsAll()
        {
            dbconnection.Open();
            var incident = dbconnection.Query<incidents>("SELECT * FROM incidents").ToList();
            dbconnection.Close();
            return incident;
        }
        public List<connexion> Sellectconnexionhabilitaion()
        {
            dbconnection.Open();
            var habilitation = dbconnection.Query<connexion>("SELECT id,login,type_user FROM user").ToList();
            dbconnection.Close();
            return habilitation;
        }

        public List<connexion> Sellectconnexionmdp()
        {
            dbconnection.Open();
            var usermdp = dbconnection.Query<connexion>("SELECT id,login,type_user,bloquer FROM user where bloquer = 1 ").ToList();
            dbconnection.Close();
            return usermdp;
        }


        public List<connexion>Select_user(string login)
        {
            dbconnection.Open();
            List<connexion> user = new List<connexion>();
            String strQuery = "select * from user where login  = @Thelogin";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Thelogin",   login);
            user = dbconnection.Query<connexion>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
            return user;

        }

        public List<Formation> SellectFormationAll()
        {
            dbconnection.Open();
            var formations = dbconnection.Query<Formation>("SELECT * FROM Formation").ToList();
            dbconnection.Close();
            return formations;
        }

        public List<Session> SellectSession_par_jr()
        {
            dbconnection.Open();
            List<Session> Sessions = new List<Session>();
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            String strQuery = "select * from Session where DateDebut  = @Thedate";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Thedate", date);
            Sessions = dbconnection.Query<Session>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();

            return Sessions;
        }

        


        public List<connexion> Sellectlogin(string Login, string Mdp)
        {
            dbconnection.Open();
            List<connexion> inscrits = new List<connexion>();
            String strQuery = "SELECT * FROM user Where login = @TheLogin and mdp =@TheMdp";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("TheLogin",   Login);
            DynamicParameters.Add("TheMdp",     Mdp);
            inscrits = dbconnection.Query<connexion>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
            return inscrits;
        }
        public List<Participant> SelectParticipantAll()
        {
            dbconnection.Open();
            List<Participant> participants = new List<Participant>();
            String strQuery = "SELECT * FROM participant ";
            var DynamicParameters = new DynamicParameters();
            participants = dbconnection.Query<Participant>(strQuery).ToList();
            dbconnection.Close();
            return participants;
        }

        public List<Participant> SelectParticipantadmin()
        {
            dbconnection.Open();
            List<Participant> participants = new List<Participant>();
            String strQuery = "SELECT participant.Nom,participant.Prenom,formation.Nom as nom_formation,session.DateDebut as session_date,candidater.accepter from participant join candidater on participant.Id = candidater.Id_Participant join session on candidater.Id_Session = session.Id join formation on session.Id_Formation = formation.Id";
            var DynamicParameters = new DynamicParameters();
            participants = dbconnection.Query<Participant>(strQuery).ToList();
            dbconnection.Close();
            return participants;
        }


        public List<Participant> SelectParticipantAllsouhait(int Id_formation,int Id_session)
        {
            dbconnection.Open();
            List<Participant> participants = new List<Participant>();
            String strQuery = "SELECT * FROM participant where id in(select id_participant FROM souhait where Id_formation = @Theid and id_participant not in (select id_participant FROM candidater where Id_Session = @TheId_session))";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Theid", Id_formation);
            DynamicParameters.Add("TheId_session", Id_session);
            participants = dbconnection.Query<Participant>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
            return participants;
        }

        public List<Participant> SelectParticipantAllnoninscrit(int Id_session)
        {
            dbconnection.Open();
            List<Participant> participants = new List<Participant>();
            String strQuery = "SELECT * FROM participant where id not in(select id_participant FROM candidater where Id_Session = @Theid)";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("Theid", Id_session);
            participants = dbconnection.Query<Participant>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
            return participants;
        }
        public List<Session> SelectSessionall()
        {
            dbconnection.Open();
            List<Session> Sessions = new List<Session>();
            String strQuery = "SELECT * FROM session ";
            var DynamicParameters = new Session();
            Sessions = dbconnection.Query<Session>(strQuery).ToList();
            dbconnection.Close();
            return Sessions;
        }

        public List<Session> SelectSession_avc_Formation(String Id_formation)
        {
            dbconnection.Open();
            List<Session> sessions = new List<Session>();
            String strQuery = "SELECT * FROM session WHERE id_formation = @theId";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("theId",  Id_formation);
            sessions = dbconnection.Query<Session>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
            return sessions;
        }

        public List<Participant> SelectParticipant_avc_Sessionn(String id_Session)
        {
            dbconnection.Open();
            List<Participant> inscrits = new List<Participant>();
            String strQuery = "SELECT * FROM participant WHERE Id in (select id_participant from candidater where id_session= @TheId)";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("TheId",      id_Session);
            inscrits = dbconnection.Query<Participant>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
            return inscrits;
        }

        public List<Participant> SelectParticipant_pdf(String id_Session)
        {
            dbconnection.Open();
            List<Participant> inscrits = new List<Participant>();
            String strQuery = "SELECT Nom , Prenom FROM participant WHERE Id in (select id_participant from candidater where id_session= @TheId)";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("TheId", id_Session);
            inscrits = dbconnection.Query<Participant>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
            return inscrits;
        }

        public List<Participant> SelectParticipant_recherche(string LeNomCherche, string LePrenomCherche)
        {
            dbconnection.Open();
            List<Participant> inscrits = new List<Participant>();
            String strQuery = "SELECT * FROM Participant Where Prenom =@ThePrenom or Nom =@TheName";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("TheName",        LeNomCherche);
            DynamicParameters.Add("ThePrenom",      LePrenomCherche);
            inscrits = dbconnection.Query<Participant>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
            return inscrits;
        }

        public void Insert_Formation(string Nom, int Niveau)
        {
            dbconnection.Open();
            String strQuery = "INSERT INTO Formation(Nom, Niveau) VALUES(@TheNom , @TheNiveau)";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("TheNom",         Nom);
            DynamicParameters.Add("TheNiveau",      Niveau);
            dbconnection.Query<Formation>(strQuery, DynamicParameters).ToList();
            dbconnection.Close();
        }

        public void Insert_Session(string dateselect1, string dateselect2, string lieu, string valeur)
        {
            dbconnection.Open();
            String StrQuerry2 = " INSERT INTO[Session](DateDebut,DateFin,Lieu,Id_Formation)VALUES(@dateselect1, @dateselect2,@lieu,@valeur,@nbmax); ";
            var DynamicParameters = new DynamicParameters();
            DynamicParameters.Add("dateselect1",    dateselect1);
            DynamicParameters.Add("dateselect2",    dateselect2);
            DynamicParameters.Add("Lieu",           lieu);
            DynamicParameters.Add("valeur",         valeur);
            dbconnection.Query<Participant>(StrQuerry2, DynamicParameters).ToList();
            dbconnection.Close();
        }
    }
}
