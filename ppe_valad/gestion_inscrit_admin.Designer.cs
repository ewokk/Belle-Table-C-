namespace ppe_valad
{
    partial class gestion_inscrit_admin
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
            this.bt_bug = new System.Windows.Forms.Button();
            this.bt_Refuser = new System.Windows.Forms.Button();
            this.bt_valider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "Participants non valider:";
            // 
            // dg_participant
            // 
            this.dg_participant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_participant.Location = new System.Drawing.Point(214, 81);
            this.dg_participant.Name = "dg_participant";
            this.dg_participant.RowTemplate.Height = 24;
            this.dg_participant.Size = new System.Drawing.Size(736, 272);
            this.dg_participant.TabIndex = 52;
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(1120, 486);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 34);
            this.bt_bug.TabIndex = 63;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // bt_Refuser
            // 
            this.bt_Refuser.Location = new System.Drawing.Point(214, 406);
            this.bt_Refuser.Name = "bt_Refuser";
            this.bt_Refuser.Size = new System.Drawing.Size(248, 56);
            this.bt_Refuser.TabIndex = 64;
            this.bt_Refuser.Text = "Refuser";
            this.bt_Refuser.UseVisualStyleBackColor = true;
            this.bt_Refuser.Click += new System.EventHandler(this.bt_Refuser_Click);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(702, 406);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(248, 56);
            this.bt_valider.TabIndex = 65;
            this.bt_valider.Text = "valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // gestion_inscrit_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 532);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.bt_Refuser);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_participant);
            this.Name = "gestion_inscrit_admin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_participant;
        private System.Windows.Forms.Button bt_bug;
        private System.Windows.Forms.Button bt_Refuser;
        private System.Windows.Forms.Button bt_valider;
    }
}