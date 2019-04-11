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
    public partial class add_session : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        public add_session()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string lieu     =       tb_lieu.Text;

            //var Item =       /*(combovaluecs)cb1.selecteditem;*/;

            string dateselect1      =       date1.SelectionRange.Start.ToString();

            string dateselect2      =       date2.SelectionRange.Start.ToString();

            //string valeur           =       Item.Value;

            //database.Insert_Session(dateselect1, dateselect2, lieu, valeur);

            //this.DialogResult = DialogResult.OK;                // ferme le form formation apres le traitement //
        }

        private void bt_bug_Click(object sender, EventArgs e)
        {
            string lieux = this.Name;

            bug formsbug = new bug(lieux);

            if (formsbug.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
