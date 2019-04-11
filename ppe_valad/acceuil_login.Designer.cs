namespace ppe_valad
{
    partial class acceuil_login
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
            this.tb_log = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.lb_log = new System.Windows.Forms.Label();
            this.lb_mdp = new System.Windows.Forms.Label();
            this.bt_valider = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(45, 90);
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(218, 22);
            this.tb_log.TabIndex = 1;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(45, 214);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.PasswordChar = '*';
            this.tb_mdp.Size = new System.Drawing.Size(218, 22);
            this.tb_mdp.TabIndex = 2;
            // 
            // lb_log
            // 
            this.lb_log.AutoSize = true;
            this.lb_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.lb_log.Location = new System.Drawing.Point(41, 36);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(81, 29);
            this.lb_log.TabIndex = 3;
            this.lb_log.Text = "login :";
            // 
            // lb_mdp
            // 
            this.lb_mdp.AutoSize = true;
            this.lb_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.lb_mdp.Location = new System.Drawing.Point(40, 154);
            this.lb_mdp.Name = "lb_mdp";
            this.lb_mdp.Size = new System.Drawing.Size(180, 29);
            this.lb_mdp.TabIndex = 4;
            this.lb_mdp.Text = "mot de passe :";
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(46, 281);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(204, 36);
            this.bt_valider.TabIndex = 5;
            this.bt_valider.Text = "valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(73, 352);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mot de passe oublié ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // acceuil_login
            // 
            this.AcceptButton = this.bt_valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 399);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.lb_mdp);
            this.Controls.Add(this.lb_log);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_log);
            this.Name = "acceuil_login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.Label lb_log;
        private System.Windows.Forms.Label lb_mdp;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}