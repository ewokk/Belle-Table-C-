namespace ppe_valad
{
    partial class panneau_gestionnaire
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
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_inscrit = new System.Windows.Forms.Button();
            this.bt_inscription = new System.Windows.Forms.Button();
            this.bt_postuler = new System.Windows.Forms.Button();
            this.bt_bug = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(46, 242);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(709, 40);
            this.bt_4.TabIndex = 20;
            this.bt_4.Text = "Convocation";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(46, 178);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(709, 40);
            this.bt_3.TabIndex = 19;
            this.bt_3.Text = "Emargement";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_inscrit
            // 
            this.bt_inscrit.Location = new System.Drawing.Point(46, 44);
            this.bt_inscrit.Name = "bt_inscrit";
            this.bt_inscrit.Size = new System.Drawing.Size(709, 40);
            this.bt_inscrit.TabIndex = 17;
            this.bt_inscrit.Text = "Gestion des inscrits";
            this.bt_inscrit.UseVisualStyleBackColor = true;
            this.bt_inscrit.Click += new System.EventHandler(this.bt_inscrit_Click);
            // 
            // bt_inscription
            // 
            this.bt_inscription.Location = new System.Drawing.Point(46, 108);
            this.bt_inscription.Name = "bt_inscription";
            this.bt_inscription.Size = new System.Drawing.Size(709, 40);
            this.bt_inscription.TabIndex = 24;
            this.bt_inscription.Text = "Création de compte";
            this.bt_inscription.UseVisualStyleBackColor = true;
            this.bt_inscription.Click += new System.EventHandler(this.bt_inscription_Click);
            // 
            // bt_postuler
            // 
            this.bt_postuler.Location = new System.Drawing.Point(46, 306);
            this.bt_postuler.Name = "bt_postuler";
            this.bt_postuler.Size = new System.Drawing.Size(709, 40);
            this.bt_postuler.TabIndex = 25;
            this.bt_postuler.Text = "Postuler a une formation";
            this.bt_postuler.UseVisualStyleBackColor = true;
            this.bt_postuler.Click += new System.EventHandler(this.bt_postuler_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(680, 427);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 43;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(709, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "numérisation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panneau_gestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.bt_postuler);
            this.Controls.Add(this.bt_inscription);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_inscrit);
            this.Name = "panneau_gestionnaire";
            this.Text = "panneau_gestionnaire";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_inscrit;
        private System.Windows.Forms.Button bt_inscription;
        private System.Windows.Forms.Button bt_postuler;
        private System.Windows.Forms.Button bt_bug;
        private System.Windows.Forms.Button button1;
    }
}