﻿using System;
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
    public partial class calendrier : Form
    {
        private DBMySQLUtils database = new DBMySQLUtils();
        List<Formation> cbFormationData = new List<Formation>();

        public calendrier()
        {
            InitializeComponent();
            database.InitDb(); //Init la conection avec la basse MySQL//

            cbFormationData = database.SellectFormationAll();

            cb_formation.DataSource = cbFormationData;
            cb_formation.DisplayMember = "nom";
            cb_formation.ValueMember = "id";


            var object_Formation = cb_formation.SelectedItem as Formation;
            String id_Formation;
            id_Formation = object_Formation.id; //recupere l id de la formation //

            dg_Session.DataSource = database.SelectSession_avc_Formation(id_Formation); // referesh

            dg_Session.Columns[0].Visible = false;
        }

        private void cb_formation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var object_Formation = cb_formation.SelectedItem as Formation;
            String id_Formation;
            id_Formation = object_Formation.id; //recupere l id de la formation //

            dg_Session.DataSource = database.SelectSession_avc_Formation(id_Formation); // referesh
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