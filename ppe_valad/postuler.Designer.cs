namespace ppe_valad
{
    partial class postuler
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
            this.cb_formation = new System.Windows.Forms.ComboBox();
            this.dg_Session = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_bug = new System.Windows.Forms.Button();
            this.dg_participant = new System.Windows.Forms.DataGridView();
            this.bt_1 = new System.Windows.Forms.Button();
            this.tb_recherche = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Session)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_formation
            // 
            this.cb_formation.FormattingEnabled = true;
            this.cb_formation.Location = new System.Drawing.Point(31, 91);
            this.cb_formation.Name = "cb_formation";
            this.cb_formation.Size = new System.Drawing.Size(354, 24);
            this.cb_formation.TabIndex = 41;
            this.cb_formation.SelectedIndexChanged += new System.EventHandler(this.cb_formation_SelectedIndexChanged);
            // 
            // dg_Session
            // 
            this.dg_Session.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Session.Location = new System.Drawing.Point(31, 195);
            this.dg_Session.Name = "dg_Session";
            this.dg_Session.RowTemplate.Height = 24;
            this.dg_Session.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Session.Size = new System.Drawing.Size(578, 225);
            this.dg_Session.TabIndex = 40;
            this.dg_Session.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Session_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Session :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Formation :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1016, 41);
            this.button2.TabIndex = 43;
            this.button2.Text = "Postuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(1087, 463);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 44;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // dg_participant
            // 
            this.dg_participant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_participant.Location = new System.Drawing.Point(634, 195);
            this.dg_participant.Name = "dg_participant";
            this.dg_participant.RowTemplate.Height = 24;
            this.dg_participant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_participant.Size = new System.Drawing.Size(528, 225);
            this.dg_participant.TabIndex = 45;
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_1.Location = new System.Drawing.Point(818, 123);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(172, 26);
            this.bt_1.TabIndex = 52;
            this.bt_1.Text = "recherche";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // tb_recherche
            // 
            this.tb_recherche.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_recherche.Location = new System.Drawing.Point(709, 93);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(375, 22);
            this.tb_recherche.TabIndex = 51;
            this.tb_recherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_recherche_KeyDown);
            // 
            // postuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 498);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.tb_recherche);
            this.Controls.Add(this.dg_participant);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_formation);
            this.Controls.Add(this.dg_Session);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "postuler";
            this.Text = "postuler";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Session)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_formation;
        private System.Windows.Forms.DataGridView dg_Session;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_bug;
        private System.Windows.Forms.DataGridView dg_participant;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.TextBox tb_recherche;
    }
}