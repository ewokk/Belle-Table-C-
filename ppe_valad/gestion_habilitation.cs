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
using MySql.Data.MySqlClient;

namespace ppe_valad
{
    public partial class gestion_habilitation : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<connexion> datahabilitation = new List<connexion>();
        public gestion_habilitation()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//
            datahabilitation = database.Sellectconnexionhabilitaion();

            dg_habilitation.DataSource = datahabilitation;

            dg_habilitation.Columns[1].Visible = false;

            cb_habilitation.Items.AddRange(new object[] { "Admin" });
            cb_habilitation.Items.AddRange(new object[] { "Gestionnaire" });
            cb_habilitation.Items.AddRange(new object[] { "Utilisateur" });

           
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            var item_habilitation = cb_habilitation.SelectedItem;
            string habilitation = item_habilitation.ToString();
            int type = 0;

            var Item_habilitation = (connexion)dg_habilitation.CurrentRow.DataBoundItem;
            int Id = Item_habilitation.Id;

            switch (habilitation)
            {
                case "Admin":
                    type = 1;
                    database.Update_habilitations(Id, type);
                    break;
                case "Gestionnaire":
                    type = 2;
                    database.Update_habilitations(Id, type);
                    break;
                case "Utilisateur":
                    type = 0;
                    database.Update_habilitations(Id, type);
                    break;
                default:
                    MessageBox.Show("Sélectionner une habilitation valide");
                    break;
            }

            datahabilitation = database.Sellectconnexionhabilitaion();
            dg_habilitation.DataSource = datahabilitation;
            dg_habilitation.Columns[1].Visible = false;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dg_habilitation_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
