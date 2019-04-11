namespace ppe_valad
{
    partial class visu_incidents
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
            this.dg_incidents = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_fin = new System.Windows.Forms.Button();
            this.bt_bug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_incidents)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_incidents
            // 
            this.dg_incidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_incidents.Location = new System.Drawing.Point(41, 112);
            this.dg_incidents.Name = "dg_incidents";
            this.dg_incidents.RowTemplate.Height = 24;
            this.dg_incidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_incidents.Size = new System.Drawing.Size(578, 296);
            this.dg_incidents.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "tous les incidents  :";
            // 
            // bt_fin
            // 
            this.bt_fin.Location = new System.Drawing.Point(214, 424);
            this.bt_fin.Name = "bt_fin";
            this.bt_fin.Size = new System.Drawing.Size(249, 31);
            this.bt_fin.TabIndex = 39;
            this.bt_fin.Text = "Fermer";
            this.bt_fin.UseVisualStyleBackColor = true;
            this.bt_fin.Click += new System.EventHandler(this.bt_fin_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(569, 432);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 43;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // visu_incidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 467);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.bt_fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_incidents);
            this.Name = "visu_incidents";
            this.Text = "visu_incidents";
            this.Load += new System.EventHandler(this.visu_incidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_incidents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_incidents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_fin;
        private System.Windows.Forms.Button bt_bug;
    }
}