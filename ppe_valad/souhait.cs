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
    public partial class souhait : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<Participant> dataParticipant = new List<Participant>();
        List<Formation> cbFormationData = new List<Formation>();

        public souhait()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL
            dataParticipant = database.SelectParticipantAll();
            dg_participant.DataSource = dataParticipant;

            cbFormationData = database.SellectFormationAll();

            cb_formation.DataSource = cbFormationData;
            cb_formation.DisplayMember = "nom";
            cb_formation.ValueMember = "id";


            RefreshListe1();
        }
        private void RefreshListe1() // refresh les la liste participant //
        {
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_participant.Columns[0].Visible = false;
            dg_participant.Columns[1].Visible = false;

        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            string LeNomCherche = tb_recherche.Text;
            string LePrenomCherche = tb_recherche.Text;



            if (tb_recherche.Text != "")               // recherche si pas vide //
            {
                dataParticipant = database.SelectParticipant_recherche(LeNomCherche, LePrenomCherche);

                dg_participant.DataSource = dataParticipant;     // remplissage //

            }
            else // sinon affiche tout le monde / refresh
            {
                dataParticipant = database.SelectParticipantAll(); // requet sql //

                dg_participant.DataSource = dataParticipant;    // remplissage //

            }

            // style //
            RefreshListe1();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var object_Formation = cb_formation.SelectedItem as Formation;
            int id_Formation;
            id_Formation = int.Parse(object_Formation.id); //recupere l id de la formation //

            var Item_Participant = (Participant)dg_participant.CurrentRow.DataBoundItem;
            int id = Item_Participant.Id;

            database.Insert_souhait(id_Formation, id);

            MessageBox.Show("Mr/Mdm "+Item_Participant.Nom+" a souhaité la formation : "+ object_Formation.nom);
        }
    }
}
