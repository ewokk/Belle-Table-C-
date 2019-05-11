using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ppe_valad
{
    public partial class convocation : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<Participant> dataInscrit = new List<Participant>();
        public convocation()
        {
            InitializeComponent();
            database.InitDb();                                       //Init la conection avec la basse MySQL//
            dg_session.DataSource = database.SelectSessionall();    // referesh
            dg_session.Columns[0].Visible = false;
            dg_session.Columns[4].Visible = false;
            dg_session.ReadOnly = true;
            dg_participant.ReadOnly = true;
        }

        private void dg_session_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Item_Session = (Session)dg_session.CurrentRow.DataBoundItem;
            string id = Item_Session.id.ToString();
            dataInscrit = database.SelectParticipant_pdf(id);
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;       // selection de tout la ligne //
            dg_participant.DataSource = dataInscrit;                                     // remplissage                //
            dg_participant.Columns[0].Visible = false;
            dg_participant.Columns[1].Visible = false;
            dg_participant.Columns[2].Visible = false;
        }


        


        private void dg_participant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Clear();
            var Item_Participant = (Participant)dg_participant.CurrentRow.DataBoundItem;
            var Item_Session = (Session)dg_session.CurrentRow.DataBoundItem;
            DateTime dateDebut = Convert.ToDateTime(Item_Session.dateDebut);

            richTextBox1.Text = "Madame, Monsieur "+
            "\n\n\n Afin d’encourager la professionnalisation, nous avons décidé de vous permettre d’accéder à une formation qualifiante." +
            "\n\nCelle-ci vous permettra de progresser dans vos missions et d’approfondir vos compétences." +
            "\n\nNous pensons en effet que la qualité de nos prestations et la satisfaction de nos clients passent avant tout par le bien-être de nos salariés !" +
            "\n\nVous trouverez ci-après tous les détails relatifs à cette formation.Celle - ci est obligatoire et rémunérée. Votre emploi du temps sera donc aménagé de telle sorte que vous puissiez y assister." +
            "\n\nPour toute information complémentaire, n’hésitez pas à contacter votre agence de proximité." +
            "\n\n\n\nLieu de la formation : " + Item_Session.lieux + "" +
            "\n\nDu:" + Item_Session.dateDebut+ "  au: " + Item_Session.dateFin +"" +
            "\n\nHoraire début de la formation:" + "8h30" +
            "\n\nStagiaire(s) : " + Item_Participant.Nom +"  "+ Item_Participant.Prenom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(richTextBox1.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        doc.Close();
                    }
                }
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
