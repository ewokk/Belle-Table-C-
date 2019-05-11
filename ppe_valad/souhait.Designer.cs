namespace ppe_valad
{
    partial class souhait
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
            this.cb_formation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Participants non inscrit:";
            // 
            // dg_participant
            // 
            this.dg_participant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_participant.Location = new System.Drawing.Point(25, 154);
            this.dg_participant.Name = "dg_participant";
            this.dg_participant.RowTemplate.Height = 24;
            this.dg_participant.Size = new System.Drawing.Size(375, 272);
            this.dg_participant.TabIndex = 61;
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_1.Location = new System.Drawing.Point(134, 107);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(172, 26);
            this.bt_1.TabIndex = 60;
            this.bt_1.Text = "recherche";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // tb_recherche
            // 
            this.tb_recherche.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_recherche.Location = new System.Drawing.Point(25, 77);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(375, 22);
            this.tb_recherche.TabIndex = 59;
            // 
            // cb_formation
            // 
            this.cb_formation.FormattingEnabled = true;
            this.cb_formation.Location = new System.Drawing.Point(434, 77);
            this.cb_formation.Name = "cb_formation";
            this.cb_formation.Size = new System.Drawing.Size(354, 24);
            this.cb_formation.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "Formation :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 35);
            this.button1.TabIndex = 65;
            this.button1.Text = "souhaiter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // souhait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_formation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_participant);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.tb_recherche);
            this.Name = "souhait";
            this.Text = "souhait";
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_participant;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.TextBox tb_recherche;
        private System.Windows.Forms.ComboBox cb_formation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}