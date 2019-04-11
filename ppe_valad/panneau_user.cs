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
    public partial class panneau_user : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<Participant> dataConnexion = new List<Participant>();
        public panneau_user()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//
        }
        private void bt_3_Click(object sender, EventArgs e)
        {
            MesSessions formsMesSessions = new MesSessions();

            if (formsMesSessions.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            calendrier formscalendrier = new calendrier();

            if (formscalendrier.ShowDialog() == DialogResult.OK)
            {

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
