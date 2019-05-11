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
    public partial class compte_user : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();

        public compte_user()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//
            tb_nom.Select();
        }

        private void bt_valider_creer_Click(object sender, EventArgs e)
        {
            string nom = tb_nom.Text;
            string prenom = tb_prenom.Text;

            database.Insert_participant(nom, prenom);    // changer le 1 en Id
            MessageBox.Show("Le compte "+nom+" "+prenom+" a été créé");
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
