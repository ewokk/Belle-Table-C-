namespace ppe_valad
{
    partial class Refu
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
            this.rt_motif = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rt_motif
            // 
            this.rt_motif.Location = new System.Drawing.Point(95, 89);
            this.rt_motif.Name = "rt_motif";
            this.rt_motif.Size = new System.Drawing.Size(503, 292);
            this.rt_motif.TabIndex = 0;
            this.rt_motif.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(211, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 56;
            this.label3.Text = "Motif de refus  :";
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(216, 398);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(239, 40);
            this.bt_valider.TabIndex = 57;
            this.bt_valider.Text = "valider le refu";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // Refu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rt_motif);
            this.Name = "Refu";
            this.Text = "Refu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_motif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_valider;
    }
}