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
    public partial class Refu : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        private Participant Participantrefu;       // init // 


        public Participant UnParticipant { get; set; } // get set de Participant // 

        public Refu(Participant unParticipant)
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//

            Participantrefu = unParticipant;
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            
            string motif = rt_motif.Text;
            string accepter = "non";
            database.update_postuler(Participantrefu.id, Participantrefu.Session_Id, accepter, motif);

            this.DialogResult = DialogResult.OK;
        }
    }
}
