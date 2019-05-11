namespace ppe_valad
{
    partial class gestion_inscrit
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbdatefin = new System.Windows.Forms.TextBox();
            this.tbdatedebut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbformation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_participant = new System.Windows.Forms.DataGridView();
            this.dg_inscrit = new System.Windows.Forms.DataGridView();
            this.bt_1 = new System.Windows.Forms.Button();
            this.tb_recherche = new System.Windows.Forms.TextBox();
            this.btinscrit_participant = new System.Windows.Forms.Button();
            this.btparticipant_inscrit = new System.Windows.Forms.Button();
            this.bt_bug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inscrit)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(502, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 29);
            this.label6.TabIndex = 61;
            this.label6.Text = "Date Fin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(48, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 29);
            this.label5.TabIndex = 60;
            this.label5.Text = "Date début :";
            // 
            // tbdatefin
            // 
            this.tbdatefin.Location = new System.Drawing.Point(507, 233);
            this.tbdatefin.Name = "tbdatefin";
            this.tbdatefin.Size = new System.Drawing.Size(306, 22);
            this.tbdatefin.TabIndex = 59;
            // 
            // tbdatedebut
            // 
            this.tbdatedebut.Location = new System.Drawing.Point(53, 246);
            this.tbdatedebut.Name = "tbdatedebut";
            this.tbdatedebut.Size = new System.Drawing.Size(306, 22);
            this.tbdatedebut.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(48, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 57;
            this.label4.Text = "Session :";
            // 
            // tbformation
            // 
            this.tbformation.Location = new System.Drawing.Point(53, 77);
            this.tbformation.Name = "tbformation";
            this.tbformation.Size = new System.Drawing.Size(306, 22);
            this.tbformation.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(48, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Formation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "Participants non inscrit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Participant inscrit:";
            // 
            // dg_participant
            // 
            this.dg_participant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_participant.Location = new System.Drawing.Point(507, 410);
            this.dg_participant.Name = "dg_participant";
            this.dg_participant.RowTemplate.Height = 24;
            this.dg_participant.Size = new System.Drawing.Size(375, 272);
            this.dg_participant.TabIndex = 52;
            // 
            // dg_inscrit
            // 
            this.dg_inscrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_inscrit.Location = new System.Drawing.Point(12, 410);
            this.dg_inscrit.Name = "dg_inscrit";
            this.dg_inscrit.RowTemplate.Height = 24;
            this.dg_inscrit.Size = new System.Drawing.Size(329, 272);
            this.dg_inscrit.TabIndex = 51;
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_1.Location = new System.Drawing.Point(616, 363);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(172, 26);
            this.bt_1.TabIndex = 50;
            this.bt_1.Text = "recherche";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // tb_recherche
            // 
            this.tb_recherche.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_recherche.Location = new System.Drawing.Point(507, 333);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(375, 22);
            this.tb_recherche.TabIndex = 49;
            // 
            // btinscrit_participant
            // 
            this.btinscrit_participant.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btinscrit_participant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinscrit_participant.Location = new System.Drawing.Point(396, 564);
            this.btinscrit_participant.Name = "btinscrit_participant";
            this.btinscrit_participant.Size = new System.Drawing.Size(58, 118);
            this.btinscrit_participant.TabIndex = 48;
            this.btinscrit_participant.Text = ">";
            this.btinscrit_participant.UseVisualStyleBackColor = false;
            this.btinscrit_participant.Click += new System.EventHandler(this.btinscrit_participant_Click);
            // 
            // btparticipant_inscrit
            // 
            this.btparticipant_inscrit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btparticipant_inscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btparticipant_inscrit.Location = new System.Drawing.Point(396, 410);
            this.btparticipant_inscrit.Name = "btparticipant_inscrit";
            this.btparticipant_inscrit.Size = new System.Drawing.Size(58, 118);
            this.btparticipant_inscrit.TabIndex = 47;
            this.btparticipant_inscrit.Text = "<";
            this.btparticipant_inscrit.UseVisualStyleBackColor = false;
            this.btparticipant_inscrit.Click += new System.EventHandler(this.btparticipant_inscrit_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(865, 701);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 34);
            this.bt_bug.TabIndex = 63;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // gestion_inscrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 742);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbdatefin);
            this.Controls.Add(this.tbdatedebut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbformation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_participant);
            this.Controls.Add(this.dg_inscrit);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.tb_recherche);
            this.Controls.Add(this.btinscrit_participant);
            this.Controls.Add(this.btparticipant_inscrit);
            this.Name = "gestion_inscrit";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inscrit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbdatefin;
        private System.Windows.Forms.TextBox tbdatedebut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_participant;
        private System.Windows.Forms.DataGridView dg_inscrit;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.TextBox tb_recherche;
        private System.Windows.Forms.Button btinscrit_participant;
        private System.Windows.Forms.Button btparticipant_inscrit;
        private System.Windows.Forms.Button bt_bug;
    }
}