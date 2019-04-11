namespace ppe_valad
{
    partial class MesSessions
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
            this.bt_fermer = new System.Windows.Forms.Button();
            this.dg_Session = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_bug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Session)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_fermer
            // 
            this.bt_fermer.Location = new System.Drawing.Point(49, 363);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(183, 23);
            this.bt_fermer.TabIndex = 45;
            this.bt_fermer.Text = "fermer";
            this.bt_fermer.UseVisualStyleBackColor = true;
            this.bt_fermer.Click += new System.EventHandler(this.bt_fermer_Click);
            // 
            // dg_Session
            // 
            this.dg_Session.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Session.Location = new System.Drawing.Point(49, 118);
            this.dg_Session.Name = "dg_Session";
            this.dg_Session.RowTemplate.Height = 24;
            this.dg_Session.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Session.Size = new System.Drawing.Size(578, 225);
            this.dg_Session.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mes sessions :";
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(638, 415);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 46;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // MesSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.bt_fermer);
            this.Controls.Add(this.dg_Session);
            this.Controls.Add(this.label1);
            this.Name = "MesSessions";
            this.Text = "MesSessions";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Session)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_fermer;
        private System.Windows.Forms.DataGridView dg_Session;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_bug;
    }
}