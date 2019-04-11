using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using HashageStandard;
using MySql.Data.MySqlClient;

namespace ppe_valad
{
    public partial class acceuil_login : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<connexion> dataConnexion = new List<connexion>();
        List<connexion> datalogin = new List<connexion>();
        public connexion connexion_user = new connexion();
        public connexion tentative_user = new connexion();

        public connexion Connexion_user { get; set; }

        public static int type;
        public static int id;

        public acceuil_login()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {

            string Login = tb_log.Text;
            // string Mdp = tb_mdp.Text;
            string Mdp = SHA.MakeMD5Hash(tb_mdp.Text);

            dataConnexion = database.Sellectlogin(Login, Mdp);
            datalogin = database.Select_user(Login);

            if (dataConnexion.Count == 1)
            {
                foreach (connexion user_connecté in dataConnexion)
                {
                    connexion_user = user_connecté;
                }
                type = connexion_user.Type_user;
                id = connexion_user.Id;
                database.mjr_tentativeetdate(connexion_user.Id);
                this.DialogResult = DialogResult.OK;
            }
            else if (datalogin.Count == 1) // si le mdp n'est pas bon
            {
                foreach (connexion user_tentative in datalogin)
                {
                    tentative_user = user_tentative;
                }
                int tentative = tentative_user.Tentative;
                DateTime date_dernière_tentative = tentative_user.Date_tentative;

                if(date_dernière_tentative.Day != DateTime.Now.Day)//remet la date a jour et les tentative
                {
                   database.mjr_tentativeetdate(tentative_user.Id);
                    tentative = 0;
                }

                if (tentative == 6)// si toute ses tentative sont utilisée bloquage du compte
                {
                    database.mjr_bloquer(tentative_user.Id);
                    MessageBox.Show("votre compte est bloqué pour aujourd'hui");
                    tb_log.Clear();
                    tb_mdp.Clear();
                }
                else // sinon alerte 
                {
                    tentative = tentative + 1;
                    database.mjr_tentative(tentative_user.Id, tentative);
                    MessageBox.Show("il vous reste plus que : " + (6 - tentative) + " tentatives ");
                    tb_mdp.Clear();
                    tb_mdp.Select();
                }
            }
            else // si sont login existe pas clear tout 
            {
                tb_log.Clear();
                tb_mdp.Clear();
                MessageBox.Show("L'identifiant ou le mot de passe n'est pas bon");
                tb_log.Select();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
