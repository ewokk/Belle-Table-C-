namespace ppe_valad
{
    partial class panneau_admin
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
            this.bt_visu = new System.Windows.Forms.Button();
            this.bt_modif_visu = new System.Windows.Forms.Button();
            this.bt_bug = new System.Windows.Forms.Button();
            this.bt_habilitation = new System.Windows.Forms.Button();
            this.bt_mdp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_inscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_visu
            // 
            this.bt_visu.Location = new System.Drawing.Point(50, 28);
            this.bt_visu.Name = "bt_visu";
            this.bt_visu.Size = new System.Drawing.Size(709, 40);
            this.bt_visu.TabIndex = 0;
            this.bt_visu.Text = "visualisation des incidents ";
            this.bt_visu.UseVisualStyleBackColor = true;
            this.bt_visu.Click += new System.EventHandler(this.bt_visu_Click);
            // 
            // bt_modif_visu
            // 
            this.bt_modif_visu.Location = new System.Drawing.Point(50, 94);
            this.bt_modif_visu.Name = "bt_modif_visu";
            this.bt_modif_visu.Size = new System.Drawing.Size(709, 40);
            this.bt_modif_visu.TabIndex = 1;
            this.bt_modif_visu.Text = "modification des incidents ";
            this.bt_modif_visu.UseVisualStyleBackColor = true;
            this.bt_modif_visu.Click += new System.EventHandler(this.bt_modif_visu_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(713, 430);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 33);
            this.bt_bug.TabIndex = 12;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // bt_habilitation
            // 
            this.bt_habilitation.Location = new System.Drawing.Point(50, 162);
            this.bt_habilitation.Name = "bt_habilitation";
            this.bt_habilitation.Size = new System.Drawing.Size(709, 40);
            this.bt_habilitation.TabIndex = 13;
            this.bt_habilitation.Text = "Gestion habilitation ";
            this.bt_habilitation.UseVisualStyleBackColor = true;
            this.bt_habilitation.Click += new System.EventHandler(this.bt_habilitation_Click);
            // 
            // bt_mdp
            // 
            this.bt_mdp.Location = new System.Drawing.Point(50, 226);
            this.bt_mdp.Name = "bt_mdp";
            this.bt_mdp.Size = new System.Drawing.Size(709, 40);
            this.bt_mdp.TabIndex = 14;
            this.bt_mdp.Text = "Gestion des mot de passe ";
            this.bt_mdp.UseVisualStyleBackColor = true;
            this.bt_mdp.Click += new System.EventHandler(this.bt_mdp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(709, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ajout de session";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(709, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ajout de formation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_inscription
            // 
            this.bt_inscription.Location = new System.Drawing.Point(50, 416);
            this.bt_inscription.Name = "bt_inscription";
            this.bt_inscription.Size = new System.Drawing.Size(637, 30);
            this.bt_inscription.TabIndex = 17;
            this.bt_inscription.Text = "Inscription ";
            this.bt_inscription.UseVisualStyleBackColor = true;
            this.bt_inscription.Click += new System.EventHandler(this.bt_inscription_Click);
            // 
            // panneau_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.bt_inscription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_mdp);
            this.Controls.Add(this.bt_habilitation);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.bt_modif_visu);
            this.Controls.Add(this.bt_visu);
            this.Name = "panneau_admin";
            this.Text = "panneau_admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_visu;
        private System.Windows.Forms.Button bt_modif_visu;
        private System.Windows.Forms.Button bt_bug;
        private System.Windows.Forms.Button bt_habilitation;
        private System.Windows.Forms.Button bt_mdp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_inscription;
    }
}