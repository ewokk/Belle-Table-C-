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
    public partial class add_formation : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        public add_formation()
        {
            InitializeComponent();
            button1.DialogResult    =   DialogResult.OK;
            database.InitDb(); //Init la conection avec la basse MySQL//
            tb_nom.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nom      =       tb_nom.Text;
            int lvl         =       int.Parse(tb_lvl.Text);

            database.Insert_Formation(nom, lvl);

            this.DialogResult = DialogResult.OK;                // ferme le form formation apres le traitement //
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            tb_lvl.Text = "";
            tb_nom.Text = "";

            this.DialogResult = DialogResult.OK;                // ferme le form formation sans faire de traitement s//
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
