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
    public partial class PDF : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<Participant> dataInscrit = new List<Participant>();
        public PDF()
        {
            InitializeComponent();
            database.InitDb();  //Init la conection avec la basse MySQL//
            dg_session.DataSource = database.SellectSession_par_jr(); // referesh
            dg_session.Columns[0].Visible = false;
            dg_session.ReadOnly = true;
            dg_participant.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable((dg_participant.ColumnCount) - 2);
            pdfTable.DefaultCell.Padding = 15;
            pdfTable.WidthPercentage = 80;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            dg_participant.Columns.Add("Signature", "Signature");
            dg_participant.Columns[5].Visible = false;
            //Adding Header row
            foreach (DataGridViewColumn column in dg_participant.Columns)
            {
                if(column.Name == "Id_Session" || column.Name == "id_user" || column.Name == "Id")
                { }
                else
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }  
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dg_participant.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 5)
                    {
                        pdfTable.AddCell(" ");
                    }
                    else if(cell.ColumnIndex == 0 || cell.ColumnIndex == 1 || cell.ColumnIndex == 2) { }
                    else { pdfTable.AddCell(cell.Value.ToString()); }
                }
            }

            //Exporting to //
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(pdfTable);
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
        private void dg_session_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var Item_Session = (Session)dg_session.CurrentRow.DataBoundItem;
            string id = Item_Session.id.ToString();
            dataInscrit = database.SelectParticipant_pdf(id);
            dg_participant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;     // selection de tout la ligne //
            dg_participant.DataSource = dataInscrit;                                     // remplissage                //
            dg_participant.Columns[0].Visible = false;
            dg_participant.Columns[1].Visible = false;
            dg_participant.Columns[2].Visible = false;
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
