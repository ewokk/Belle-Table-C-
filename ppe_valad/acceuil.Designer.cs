namespace ppe_valad
{
    partial class acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_Session = new System.Windows.Forms.DataGridView();
            this.cb_formation = new System.Windows.Forms.ComboBox();
            this.bt_add_formation = new System.Windows.Forms.Button();
            this.bt_add_session = new System.Windows.Forms.Button();
            this.bt_bug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Session)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Formation :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Session :";
            // 
            // dg_Session
            // 
            this.dg_Session.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Session.Location = new System.Drawing.Point(17, 201);
            this.dg_Session.Name = "dg_Session";
            this.dg_Session.RowTemplate.Height = 24;
            this.dg_Session.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Session.Size = new System.Drawing.Size(578, 225);
            this.dg_Session.TabIndex = 36;
            this.dg_Session.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Session_CellDubleClick);
            // 
            // cb_formation
            // 
            this.cb_formation.FormattingEnabled = true;
            this.cb_formation.Location = new System.Drawing.Point(17, 74);
            this.cb_formation.Name = "cb_formation";
            this.cb_formation.Size = new System.Drawing.Size(354, 24);
            this.cb_formation.TabIndex = 37;
            this.cb_formation.SelectedIndexChanged += new System.EventHandler(this.cb_formation_SelectedIndexChanged);
            // 
            // bt_add_formation
            // 
            this.bt_add_formation.Location = new System.Drawing.Point(393, 67);
            this.bt_add_formation.Name = "bt_add_formation";
            this.bt_add_formation.Size = new System.Drawing.Size(51, 39);
            this.bt_add_formation.TabIndex = 64;
            this.bt_add_formation.Text = "+";
            this.bt_add_formation.UseVisualStyleBackColor = true;
            this.bt_add_formation.Click += new System.EventHandler(this.bt_add_formation_Click);
            // 
            // bt_add_session
            // 
            this.bt_add_session.Location = new System.Drawing.Point(160, 124);
            this.bt_add_session.Name = "bt_add_session";
            this.bt_add_session.Size = new System.Drawing.Size(51, 39);
            this.bt_add_session.TabIndex = 65;
            this.bt_add_session.Text = "+";
            this.bt_add_session.UseVisualStyleBackColor = true;
            this.bt_add_session.Click += new System.EventHandler(this.bt_add_session_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(557, 441);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 66;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 461);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.bt_add_session);
            this.Controls.Add(this.bt_add_formation);
            this.Controls.Add(this.cb_formation);
            this.Controls.Add(this.dg_Session);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "acceuil";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Session)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_Session;
        private System.Windows.Forms.ComboBox cb_formation;
        private System.Windows.Forms.Button bt_add_formation;
        private System.Windows.Forms.Button bt_add_session;
        private System.Windows.Forms.Button bt_bug;
    }
}

