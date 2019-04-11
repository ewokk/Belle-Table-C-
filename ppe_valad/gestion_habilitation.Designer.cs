namespace ppe_valad
{
    partial class gestion_habilitation
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
            this.dg_habilitation = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_fermer = new System.Windows.Forms.Button();
            this.bt_valider = new System.Windows.Forms.Button();
            this.cb_habilitation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_bug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_habilitation)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_habilitation
            // 
            this.dg_habilitation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_habilitation.Location = new System.Drawing.Point(67, 76);
            this.dg_habilitation.Name = "dg_habilitation";
            this.dg_habilitation.RowTemplate.Height = 24;
            this.dg_habilitation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_habilitation.Size = new System.Drawing.Size(448, 296);
            this.dg_habilitation.TabIndex = 38;
            this.dg_habilitation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_habilitation_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "tous les comptes :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bt_fermer
            // 
            this.bt_fermer.Location = new System.Drawing.Point(67, 397);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(123, 41);
            this.bt_fermer.TabIndex = 40;
            this.bt_fermer.Text = "fermer";
            this.bt_fermer.UseVisualStyleBackColor = true;
            this.bt_fermer.Click += new System.EventHandler(this.bt_fermer_Click);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(668, 177);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(123, 41);
            this.bt_valider.TabIndex = 41;
            this.bt_valider.Text = "valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // cb_habilitation
            // 
            this.cb_habilitation.FormattingEnabled = true;
            this.cb_habilitation.Location = new System.Drawing.Point(581, 117);
            this.cb_habilitation.Name = "cb_habilitation";
            this.cb_habilitation.Size = new System.Drawing.Size(336, 24);
            this.cb_habilitation.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "choix de la nouvelle habilitation :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(887, 415);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 44;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // gestion_habilitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_habilitation);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.bt_fermer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_habilitation);
            this.Name = "gestion_habilitation";
            this.Text = "gestion_habilitation";
            ((System.ComponentModel.ISupportInitialize)(this.dg_habilitation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_habilitation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_fermer;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.ComboBox cb_habilitation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_bug;
    }
}