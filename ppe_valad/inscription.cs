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
    public partial class inscription : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<connexion> dataConnexion = new List<connexion>();
        
        public inscription()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//
            tb_login.Select();
        }

        private void bt_valiver_Click(object sender, EventArgs e)
        {
            string login = tb_login.Text;

            string mdp =SHA.MakeMD5Hash(tbmdp.Text);

            dataConnexion = database.Select_user(login);

            DateTime date_tentative = DateTime.Now;

            if (dataConnexion.Count > 0)
            {
                MessageBox.Show("l'identifiant existe déjà");
                tb_login.Clear();
                tbmdp.Clear();
                tb_login.Select();
            }
            else
            {
                database.Insert_user(login, mdp,date_tentative);
                this.DialogResult = DialogResult.OK;
            }


         

        
    
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void bt_bug_Click(object sender, EventArgs e)
        {
            string lieux = this.Name;

            bug formsbug = new bug(lieux);

            if (formsbug.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
