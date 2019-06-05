using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe_valad
{
    public partial class compte_update : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<Participant> dataParticipant = new List<Participant>();
        
        public compte_update()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL
            dataParticipant = database.SelectParticipantAll();
            dg_participant.DataSource = dataParticipant;
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;          // selection de tout la ligne //

            RefreshListe1();
        }

      
        private void bt_1_Click(object sender, EventArgs e)
        {
             string LeNomCherche         =       tb_recherche.Text;
            string LePrenomCherche      =       tb_recherche.Text;
                      
            

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
        private void RefreshListe1() // refresh les la liste participant //
        {
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_participant.Columns[0].Visible = false;
            dg_participant.Columns[1].Visible = false;
            dg_participant.Columns[4].Visible = false;
            dg_participant.Columns[5].Visible = false;
            dg_participant.Columns[6].Visible = false;
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;          // selection de tout la ligne //



        }

        private void dg_participant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_participant_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            var Item_Participant = (Participant)dg_participant.CurrentRow.DataBoundItem;
            string nom = Item_Participant.Nom;
            string prenom = Item_Participant.Prenom;

            tb_nom.Text = nom;
            tb_prenom.Text = prenom;
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bt_valider_creer_Click(object sender, EventArgs e)
        {
            string nom = tb_nom.Text;
            string prenom = tb_prenom.Text;
            var Item_Participant = (Participant)dg_participant.CurrentRow.DataBoundItem;
            int id = Item_Participant.id;

            database.Update_participant(id,nom, prenom);    // changer le 1 en Id
            MessageBox.Show("Le compte " + nom + " " + prenom + " a été modifié");
            this.DialogResult = DialogResult.OK;
        }

        private void tb_recherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
