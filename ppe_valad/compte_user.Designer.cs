namespace ppe_valad
{
    partial class compte_user
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
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.bt_valider_creer = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.bt_bug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(55, 119);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(196, 22);
            this.tb_nom.TabIndex = 0;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(55, 220);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(196, 22);
            this.tb_prenom.TabIndex = 1;
            // 
            // lb_prenom
            // 
            this.lb_prenom.AutoSize = true;
            this.lb_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.lb_prenom.Location = new System.Drawing.Point(50, 167);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(116, 29);
            this.lb_prenom.TabIndex = 6;
            this.lb_prenom.Text = "Prénom :";
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.lb_nom.Location = new System.Drawing.Point(50, 49);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(81, 29);
            this.lb_nom.TabIndex = 5;
            this.lb_nom.Text = "Nom :";
            // 
            // bt_valider_creer
            // 
            this.bt_valider_creer.Location = new System.Drawing.Point(165, 276);
            this.bt_valider_creer.Name = "bt_valider_creer";
            this.bt_valider_creer.Size = new System.Drawing.Size(81, 30);
            this.bt_valider_creer.TabIndex = 7;
            this.bt_valider_creer.Text = "valider";
            this.bt_valider_creer.UseVisualStyleBackColor = true;
            this.bt_valider_creer.Click += new System.EventHandler(this.bt_valider_creer_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(50, 276);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(81, 30);
            this.bt_annuler.TabIndex = 8;
            this.bt_annuler.Text = "annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(225, 337);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 43;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // compte_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 372);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_valider_creer);
            this.Controls.Add(this.lb_prenom);
            this.Controls.Add(this.lb_nom);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Name = "compte_user";
            this.Text = "compte_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.Button bt_valider_creer;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button bt_bug;
    }
}