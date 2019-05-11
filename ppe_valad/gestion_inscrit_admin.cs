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
    public partial class gestion_inscrit_admin : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<Participant> dataParticipant = new List<Participant>();


        public gestion_inscrit_admin()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dataParticipant     =   database.SelectParticipantadmin();                        // requet sql                 //
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;          // selection de tout la ligne //
            dg_participant.DataSource = dataParticipant;                                    // remplissage                //


            // style //
           RefreshListe1();
           
        }

        private void RefreshListe1() // refresh les la liste participant //
        {
            dg_participant.SelectionMode            =       DataGridViewSelectionMode.FullRowSelect;
            dg_participant.Columns[0].Visible       =       false;
            dg_participant.Columns[1].Visible       =       false;
        }


        private void bt_bug_Click(object sender, EventArgs e)
        {
            string lieux = this.Name;

            bug formsbug = new bug(lieux);

            if (formsbug.ShowDialog() == DialogResult.OK)
            {

            }
        }



        private void bt_Refuser_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_participant.SelectedRows)
            {
                var objectInscrit = (Participant)dg_participant.CurrentRow.DataBoundItem;
                Participant unParticipant = row.DataBoundItem as Participant;
                Refu forms2 = new Refu(unParticipant);

                if (forms2.ShowDialog() == DialogResult.OK)
                {
                    dataParticipant = database.SelectParticipantadmin();                        // requet sql                 //
                    dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;          // selection de tout la ligne //
                    dg_participant.DataSource = dataParticipant;                                    // remplissage                //


                    // style //
                    RefreshListe1();
                }
            }
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_participant.SelectedRows)
            {

                var objectInscrit = (Participant)dg_participant.CurrentRow.DataBoundItem;
                Participant unParticipant = row.DataBoundItem as Participant;
                string motif = "";
                string accepter = "oui";
                database.update_postuler(unParticipant.Id, unParticipant.Id_Session, motif, accepter);
            }
                dataParticipant = database.SelectParticipantadmin();                              // requet sql                 //
                dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;          // selection de tout la ligne //
                dg_participant.DataSource = dataParticipant;                                    // remplissage                //


                // style //
                RefreshListe1();

        }

        }
    }

