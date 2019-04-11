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
    public partial class acceuil : Form
    {
        private DBMySQLUtils database   =    new DBMySQLUtils();
        List<Formation> cbFormationData =   new List<Formation>();

        public acceuil()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//

            cbFormationData     =      database.SellectFormationAll();

            cb_formation.DataSource = cbFormationData;
            cb_formation.DisplayMember = "nom";
            cb_formation.ValueMember = "id";


            var object_Formation = cb_formation.SelectedItem as Formation;
            String id_Formation;
            id_Formation = object_Formation.id; //recupere l id de la formation //

            dg_Session.DataSource = database.SelectSession_avc_Formation(id_Formation); // referesh

            dg_Session.Columns[0].Visible = false;

        }

        private void cb_formation_SelectedIndexChanged(object sender, EventArgs e)
        {
             var object_Formation = cb_formation.SelectedItem as Formation;
            String id_Formation;
            id_Formation = object_Formation.id; //recupere l id de la formation //

            dg_Session.DataSource = database.SelectSession_avc_Formation(id_Formation); // referesh
        }

        private void dg_Session_CellDubleClick(object sender, DataGridViewCellEventArgs e)
        {
           var Item_Formation = cb_formation.SelectedItem as Formation;
            var Item_Session         =       (Session)dg_Session.CurrentRow.DataBoundItem;

            gestion_inscrit forms2 = new gestion_inscrit(Item_Formation, Item_Session);

            if (forms2.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bt_add_formation_Click(object sender, EventArgs e)
        {
            add_formation formsadd   =   new add_formation();

            if (formsadd.ShowDialog() == DialogResult.OK)
            {
                cbFormationData = database.SellectFormationAll();

                cb_formation.DataSource = cbFormationData;
            }
        }

        private void bt_add_session_Click(object sender, EventArgs e)
        {
            add_session formsaddS = new add_session();

            if (formsaddS.ShowDialog() == DialogResult.OK)
            {
                var object_Formation = cb_formation.SelectedItem as Formation;
                String id_Formation;
                id_Formation = object_Formation.id; //recupere l id de la formation //

                dg_Session.DataSource = database.SelectSession_avc_Formation(id_Formation); // referesh

                dg_Session.Columns[0].Visible = false;
            }
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

