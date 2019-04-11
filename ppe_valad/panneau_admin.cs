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
    public partial class panneau_admin : Form
    {
        public panneau_admin()
        {
            InitializeComponent();
        }

        private void bt_visu_Click(object sender, EventArgs e)
        {
            visu_incidents formsvisu = new visu_incidents();

            if (formsvisu.ShowDialog() == DialogResult.OK)
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

        private void bt_modif_visu_Click(object sender, EventArgs e)
        {
            update_incident formsmodif = new update_incident();

            if (formsmodif.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bt_habilitation_Click(object sender, EventArgs e)
        {
            gestion_habilitation formshabilitation = new gestion_habilitation();

            if (formshabilitation.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bt_mdp_Click(object sender, EventArgs e)
        {
            gestion_mdp formsmpd = new gestion_mdp();

            if (formsmpd.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_session formaddsession = new add_session();

            if (formaddsession.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_formation formaddformation= new add_formation();

            if (formaddformation.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bt_inscription_Click(object sender, EventArgs e)
        {
           
                inscription formsinscription = new inscription();

                if (formsinscription.ShowDialog() == DialogResult.OK)
                {

                }
            
        }
    }
}
