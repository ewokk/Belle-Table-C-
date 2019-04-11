namespace ppe_valad
{
    partial class gestion_mdp
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
            this.bt_valider = new System.Windows.Forms.Button();
            this.bt_fermer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_mdp = new System.Windows.Forms.DataGridView();
            this.bt_bug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mdp)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(191, 390);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(269, 41);
            this.bt_valider.TabIndex = 47;
            this.bt_valider.Text = "Réinitialiser le mot de passe ";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // bt_fermer
            // 
            this.bt_fermer.Location = new System.Drawing.Point(12, 390);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(123, 41);
            this.bt_fermer.TabIndex = 46;
            this.bt_fermer.Text = "fermer";
            this.bt_fermer.UseVisualStyleBackColor = true;
            this.bt_fermer.Click += new System.EventHandler(this.bt_fermer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "tous les comptes :";
            // 
            // dg_mdp
            // 
            this.dg_mdp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mdp.Location = new System.Drawing.Point(12, 69);
            this.dg_mdp.Name = "dg_mdp";
            this.dg_mdp.RowTemplate.Height = 24;
            this.dg_mdp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_mdp.Size = new System.Drawing.Size(448, 296);
            this.dg_mdp.TabIndex = 44;
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(392, 459);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 48;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // gestion_mdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 494);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.bt_fermer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_mdp);
            this.Name = "gestion_mdp";
            this.Text = "gestion_mdp";
            ((System.ComponentModel.ISupportInitialize)(this.dg_mdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Button bt_fermer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_mdp;
        private System.Windows.Forms.Button bt_bug;
    }
}