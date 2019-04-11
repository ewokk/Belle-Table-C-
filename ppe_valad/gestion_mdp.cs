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
  
    public partial class gestion_mdp : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<connexion> datamdp = new List<connexion>();
        public gestion_mdp()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//

            database.InitDb(); //Init la conection avec la basse MySQL//
            datamdp = database.Sellectconnexionmdp();

            dg_mdp.DataSource = datamdp;

            dg_mdp.Columns[1].Visible = false;
            dg_mdp.Columns[2].Visible = false;
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            var Item_habilitation = (connexion)dg_mdp.CurrentRow.DataBoundItem;
            int Id = Item_habilitation.Id;

            string mdp = SHA.MakeMD5Hash("0000");
            database.New_mdp(Id, mdp);

            MessageBox.Show("Mot de passe réinitianlisé : 0000");

        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

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
