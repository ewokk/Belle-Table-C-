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
    public partial class panneau_gestionnaire : Form
    {
        public panneau_gestionnaire()
        {
            InitializeComponent();
        }

        private void bt_inscrit_Click(object sender, EventArgs e)
        {
            acceuil formsinscrit = new acceuil();

            if (formsinscrit.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bt_inscription_Click(object sender, EventArgs e)
        {
            compte_user formscomte = new compte_user();

            if (formscomte.ShowDialog() == DialogResult.OK)
            {

            }
            
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            PDF formsPDF = new PDF();

            if (formsPDF.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            convocation formsconvocation = new convocation();

            if (formsconvocation.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bt_postuler_Click(object sender, EventArgs e)
        {
            postuler formspostuler = new postuler();

            if (formspostuler.ShowDialog() == DialogResult.OK)
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

        private void button1_Click(object sender, EventArgs e)
        {
            numérisation formsnumérisation = new numérisation();

            if (formsnumérisation.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
