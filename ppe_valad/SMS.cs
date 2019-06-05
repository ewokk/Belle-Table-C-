using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace ppe_valad
{
    public partial class SMS : Form
    {
        public SMS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String msg = rtb_sms.Text;
            SMS_classe.Send(msg);
            MessageBox.Show("Sms envoyé");
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
