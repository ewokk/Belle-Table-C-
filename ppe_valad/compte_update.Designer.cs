namespace ppe_valad
{
    partial class compte_update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dg_participant = new System.Windows.Forms.DataGridView();
            this.bt_1 = new System.Windows.Forms.Button();
            this.tb_recherche = new System.Windows.Forms.TextBox();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.bt_valider_creer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Participants non inscrit:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dg_participant
            // 
            this.dg_participant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_participant.Location = new System.Drawing.Point(367, 176);
            this.dg_participant.Name = "dg_participant";
            this.dg_participant.RowTemplate.Height = 24;
            this.dg_participant.Size = new System.Drawing.Size(375, 272);
            this.dg_participant.TabIndex = 57;
            this.dg_participant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_participant_CellContentClick);
            this.dg_participant.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_participant_DoubleClick);
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_1.Location = new System.Drawing.Point(476, 129);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(172, 26);
            this.bt_1.TabIndex = 56;
            this.bt_1.Text = "recherche";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // tb_recherche
            // 
            this.tb_recherche.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_recherche.Location = new System.Drawing.Point(367, 99);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(375, 22);
            this.tb_recherche.TabIndex = 55;
            this.tb_recherche.TextChanged += new System.EventHandler(this.tb_recherche_TextChanged);
            // 
            // lb_prenom
            // 
            this.lb_prenom.AutoSize = true;
            this.lb_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.lb_prenom.Location = new System.Drawing.Point(47, 176);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(116, 29);
            this.lb_prenom.TabIndex = 62;
            this.lb_prenom.Text = "Prénom :";
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.lb_nom.Location = new System.Drawing.Point(47, 58);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(81, 29);
            this.lb_nom.TabIndex = 61;
            this.lb_nom.Text = "Nom :";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(52, 229);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(196, 22);
            this.tb_prenom.TabIndex = 60;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(52, 128);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(196, 22);
            this.tb_nom.TabIndex = 59;
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(52, 327);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(81, 30);
            this.bt_annuler.TabIndex = 64;
            this.bt_annuler.Text = "annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // bt_valider_creer
            // 
            this.bt_valider_creer.Location = new System.Drawing.Point(167, 327);
            this.bt_valider_creer.Name = "bt_valider_creer";
            this.bt_valider_creer.Size = new System.Drawing.Size(81, 30);
            this.bt_valider_creer.TabIndex = 63;
            this.bt_valider_creer.Text = "valider";
            this.bt_valider_creer.UseVisualStyleBackColor = true;
            this.bt_valider_creer.Click += new System.EventHandler(this.bt_valider_creer_Click);
            // 
            // compte_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 512);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_valider_creer);
            this.Controls.Add(this.lb_prenom);
            this.Controls.Add(this.lb_nom);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_participant);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.tb_recherche);
            this.Name = "compte_update";
            this.Text = "compte_update";
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_participant;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.TextBox tb_recherche;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button bt_valider_creer;
    }
}