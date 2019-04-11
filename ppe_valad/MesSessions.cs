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
    public partial class MesSessions : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<Session> datasession = new List<Session>();
        public MesSessions()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//
            int id = 9;
            datasession = database.Select_session_lié_compte(id);

            dg_Session.DataSource = datasession;

        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
