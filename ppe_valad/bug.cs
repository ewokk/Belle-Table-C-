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
    public partial class bug : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();

        public bug(string lieux)
        {
            InitializeComponent();
            bt_valider.DialogResult = DialogResult.OK;
            database.InitDb(); //Init la conection avec la basse MySQL//
            tb_lieux_bug.Text = lieux;


        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            string Description = rt_description.Text;
            string Lieux = tb_lieux_bug.Text;
            string Etat = "En cours";
            int Rapporteur = acceuil_login.id;


            DateTime Date_incident = DateTime.Now;


            database.Insert_incidents( Lieux,  Etat, Description,  Rapporteur,  Date_incident);

            this.DialogResult = DialogResult.OK;
        }

        private void bt_annuler_Click(object sender, EventArgs e)
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
