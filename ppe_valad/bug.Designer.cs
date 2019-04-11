namespace ppe_valad
{
    partial class bug
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
            this.tb_lieux_bug = new System.Windows.Forms.TextBox();
            this.rt_description = new System.Windows.Forms.RichTextBox();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.bt_valider = new System.Windows.Forms.Button();
            this.bt_bug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Incidents trouvé  :";
            // 
            // tb_lieux_bug
            // 
            this.tb_lieux_bug.Location = new System.Drawing.Point(58, 115);
            this.tb_lieux_bug.Name = "tb_lieux_bug";
            this.tb_lieux_bug.Size = new System.Drawing.Size(426, 22);
            this.tb_lieux_bug.TabIndex = 35;
            // 
            // rt_description
            // 
            this.rt_description.Location = new System.Drawing.Point(55, 186);
            this.rt_description.Name = "rt_description";
            this.rt_description.Size = new System.Drawing.Size(429, 315);
            this.rt_description.TabIndex = 36;
            this.rt_description.Text = "";
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(58, 507);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(142, 49);
            this.bt_annuler.TabIndex = 37;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(332, 507);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(152, 49);
            this.bt_valider.TabIndex = 38;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(442, 562);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 43;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // bug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 589);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.rt_description);
            this.Controls.Add(this.tb_lieux_bug);
            this.Controls.Add(this.label2);
            this.Name = "bug";
            this.Text = "bug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_lieux_bug;
        private System.Windows.Forms.RichTextBox rt_description;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Button bt_bug;
    }
}