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
   
    public partial class postuler : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<Formation> cbFormationData = new List<Formation>();
        List<Participant> user = new List<Participant>();
        public Participant user_id = new Participant();
        List<Participant> dataParticipant = new List<Participant>();
        public postuler()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL
            cbFormationData = database.SellectFormationAll();

            cb_formation.DataSource = cbFormationData;
            cb_formation.DisplayMember = "nom";
            cb_formation.ValueMember = "id";


            var object_Formation = cb_formation.SelectedItem as Formation;
            string id_Formation = object_Formation.id; //recupere l id de la formation //;
            
             

            dg_Session.DataSource = database.SelectSession_avc_Formation(id_Formation); // referesh
            dg_Session.Columns[0].Visible = false;

           
        }

        private void RefreshListe1() // refresh les la liste participant //
        {
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_participant.Columns[0].Visible = false;
            dg_participant.Columns[1].Visible = false;

        }

        private void cb_formation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var object_Formation = cb_formation.SelectedItem as Formation;
            String id_Formation;
            id_Formation = object_Formation.id; //recupere l id de la formation //

            dg_Session.DataSource = database.SelectSession_avc_Formation(id_Formation); // referesh
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Item_Session = (Session)dg_Session.CurrentRow.DataBoundItem;
            int id_session = Item_Session.id;
            var  Item_participant = (Participant)dg_participant.CurrentRow.DataBoundItem;
            int id = Item_participant.id;
            
            database.Insert_postuler(id, id_session);

            MessageBox.Show("Vous avez bien postuler a la session du  " + Item_Session.dateDebut + " à " + Item_Session.lieux);

            dataParticipant = database.SelectParticipantAllnoninscrit(Item_Session.id);              // requet sql                 //
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;                 // selection de tout la ligne //
            dg_participant.DataSource = dataParticipant;


        }

        private void bt_bug_Click(object sender, EventArgs e)
        {
            string lieux = this.Name;

            bug formsbug = new bug(lieux);

            if (formsbug.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bt_1_Click(object sender, EventArgs e)//recherche
        {
            string LeNomCherche         =       tb_recherche.Text;
            string LePrenomCherche      =       tb_recherche.Text;
            var Item_Session = (Session)dg_Session.CurrentRow.DataBoundItem;
            
            

            if (tb_recherche.Text != "" )               // recherche si pas vide //
            {
                dataParticipant             =       database.SelectParticipant_recherche(LeNomCherche, LePrenomCherche);

                dg_participant.DataSource               =       dataParticipant;     // remplissage //

            }
            else // sinon affiche tout le monde / refresh
            {
                dataParticipant = database.SelectParticipantAll(); // requet sql //

                dg_participant.DataSource               =       dataParticipant;    // remplissage //
               
            }

            // style //
            RefreshListe1();
        }

        private void dg_Session_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Item_Session = (Session)dg_Session.CurrentRow.DataBoundItem;
            dataParticipant = database.SelectParticipantAllnoninscrit(Item_Session.id);              // requet sql                 //
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;                 // selection de tout la ligne //
            dg_participant.DataSource = dataParticipant;                                           // remplissage                //

            // style //
            RefreshListe1();
        }

        private void tb_recherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_1.PerformClick();
            }
        }

        private void dg_participant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
