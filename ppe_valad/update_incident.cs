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
    public partial class update_incident : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<incidents> dataincidents = new List<incidents>();
        public update_incident()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//
            dataincidents = database.SellectincidentsAll();

            dg_incidents.DataSource = dataincidents;

            textBox1.Text = "JJ/MM/AAAA";

        }

        private void bt_fin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = textBox1.Text;
            var Item_incident = (incidents)dg_incidents.CurrentRow.DataBoundItem;
            int Id = Item_incident.Id;
            database.Update_incidents(Id, Convert.ToDateTime(date));

            dataincidents = database.SellectincidentsAll();

            dg_incidents.DataSource = dataincidents;

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
