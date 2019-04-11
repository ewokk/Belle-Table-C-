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
    public partial class visu_incidents : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<incidents> dataincidents = new List<incidents>();
        public visu_incidents()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//
            dataincidents = database.SellectincidentsAll();

            dg_incidents.DataSource = dataincidents;
        }
        
       

        private void bt_fin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void visu_incidents_Load(object sender, EventArgs e)
        {
            var Item = (incidents)dg_incidents.CurrentRow.DataBoundItem;

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
