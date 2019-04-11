namespace ppe_valad
{
    partial class inscription
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
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tbmdp = new System.Windows.Forms.TextBox();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.bt_valiver = new System.Windows.Forms.Button();
            this.lb_mdp = new System.Windows.Forms.Label();
            this.lb_log = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_bug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(36, 167);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(327, 22);
            this.tb_login.TabIndex = 0;
            // 
            // tbmdp
            // 
            this.tbmdp.Location = new System.Drawing.Point(36, 298);
            this.tbmdp.Name = "tbmdp";
            this.tbmdp.Size = new System.Drawing.Size(327, 22);
            this.tbmdp.TabIndex = 1;
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(36, 363);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(110, 27);
            this.bt_annuler.TabIndex = 2;
            this.bt_annuler.Text = "annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // bt_valiver
            // 
            this.bt_valiver.Location = new System.Drawing.Point(248, 363);
            this.bt_valiver.Name = "bt_valiver";
            this.bt_valiver.Size = new System.Drawing.Size(115, 27);
            this.bt_valiver.TabIndex = 3;
            this.bt_valiver.Text = "valider";
            this.bt_valiver.UseVisualStyleBackColor = true;
            this.bt_valiver.Click += new System.EventHandler(this.bt_valiver_Click);
            // 
            // lb_mdp
            // 
            this.lb_mdp.AutoSize = true;
            this.lb_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.lb_mdp.Location = new System.Drawing.Point(30, 225);
            this.lb_mdp.Name = "lb_mdp";
            this.lb_mdp.Size = new System.Drawing.Size(180, 29);
            this.lb_mdp.TabIndex = 6;
            this.lb_mdp.Text = "mot de passe :";
            // 
            // lb_log
            // 
            this.lb_log.AutoSize = true;
            this.lb_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.lb_log.Location = new System.Drawing.Point(31, 107);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(81, 29);
            this.lb_log.TabIndex = 5;
            this.lb_log.Text = "login :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(129, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inscription  :";
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(316, 423);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 43;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 458);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_mdp);
            this.Controls.Add(this.lb_log);
            this.Controls.Add(this.bt_valiver);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.tbmdp);
            this.Controls.Add(this.tb_login);
            this.Name = "inscription";
            this.Text = "inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tbmdp;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button bt_valiver;
        private System.Windows.Forms.Label lb_mdp;
        private System.Windows.Forms.Label lb_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_bug;
    }
}