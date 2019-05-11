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
    public partial class gestion_inscrit : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<Participant> dataParticipant = new List<Participant>();
        List<Participant> dataInscrit = new List<Participant>();


        private Formation formation; // init // 
        private Session session;       // init // 


        public Formation Formation { get; set; } // get set de Formation // 
        public Session Session { get; set; }   // get set de Formation //  



        public gestion_inscrit(Formation Item_Formation, Session Item_Session)
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//

            formation = Item_Formation;
            session = Item_Session;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dataParticipant = database.SelectParticipantAll(); // requet sql                 //
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;      // selection de tout la ligne //
            dg_participant.DataSource = dataParticipant;                                // remplissage                //

            dataInscrit = database.SelectParticipant_avc_Sessionn(session.id.ToString());
            dg_inscrit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;     // selection de tout la ligne //
            dg_inscrit.DataSource = dataInscrit;                                // remplissage                //

            tbformation.Text = formation.nom;            // remplissage formation //
            tbdatedebut.Text = session.dateDebut;       // remplissage dateDebut //
            tbdatefin.Text = session.dateFin;        // remplissage dateFin   //

            // style //
            RefreshListe1();
            RefreshListe2();
        }


        private void RefreshListe1() // refresh les la liste participant //
        {
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_participant.Columns[0].Visible = false;
            dg_participant.Columns[1].Visible = false;
       
        }
        private void RefreshListe2() // refresh les la liste inscrit //
        {
            dg_inscrit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_inscrit.Columns[0].Visible = false;
            dg_inscrit.Columns[1].Visible = false;

        }

        private void btsave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;                // ferme le form 2 //
        }

        private void bt_1_Click(object sender, EventArgs e) // traitement de la recherhce //
        {
            string LeNomCherche = tb_recherche.Text;
            string LePrenomCherche = tb_recherche.Text;

            if (tb_recherche.Text != "")               // recherche si pas vide //
            {
                dataParticipant = database.SelectParticipant_recherche(LeNomCherche, LePrenomCherche);

                dg_participant.DataSource = dataParticipant;     // remplissage //
                dg_participant.Columns[0].Visible = false;              // style       //
                dg_participant.Columns[1].Visible = false;             // style       //
            }
            else // sinon affiche tout le monde / refresh
            {
                dataParticipant = database.SelectParticipantAll(); // requet sql //

                dg_participant.DataSource = dataParticipant;    // remplissage //
                dg_participant.Columns[0].Visible = false;             // style       //
                dg_participant.Columns[1].Visible = false;            // style       //
            }
        }
        private void btinscrit_participant_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_inscrit.SelectedRows)
            {

                var Index_inscrit = (Participant)dg_inscrit.CurrentRow.DataBoundItem;
                Participant unInscrit = row.DataBoundItem as Participant;

                int Index_Inscrit = -1;

                Index_Inscrit = dataInscrit.IndexOf(Index_inscrit);
                dataInscrit.RemoveAt(Index_Inscrit);

                //ajout //
                dataParticipant.Add(unInscrit);

                // Refresh  //
                dg_inscrit.DataSource = null;
                dg_inscrit.DataSource = dataInscrit;

                dg_participant.DataSource = null;
                dg_participant.DataSource = dataParticipant;

                // style //
                RefreshListe1();
                RefreshListe2();

                database.delete_postuler(unInscrit.Id, session.id);
            }
        }

        private void btparticipant_inscrit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_participant.SelectedRows)
            {

                var objectInscrit = (Participant)dg_participant.CurrentRow.DataBoundItem;
                Participant unParticipant = row.DataBoundItem as Participant;

                int Index_Participant = -1;

                Index_Participant = dataParticipant.IndexOf(objectInscrit);
                dataParticipant.RemoveAt(Index_Participant);

                //ajout //
                dataInscrit.Add(unParticipant);

                // Refresh  //
                dg_inscrit.DataSource = null;
                dg_inscrit.DataSource = dataInscrit;

                dg_participant.DataSource = null;
                dg_participant.DataSource = dataParticipant;

                // style //
                RefreshListe1();
                RefreshListe2();

                database.Insert_postuler(unParticipant.Id, session.id);
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