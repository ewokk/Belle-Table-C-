namespace ppe_valad
{
    partial class update_incident
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
            this.bt_fin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_incidents = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_bug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_incidents)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_fin
            // 
            this.bt_fin.Location = new System.Drawing.Point(25, 407);
            this.bt_fin.Name = "bt_fin";
            this.bt_fin.Size = new System.Drawing.Size(249, 31);
            this.bt_fin.TabIndex = 42;
            this.bt_fin.Text = "Fermer";
            this.bt_fin.UseVisualStyleBackColor = true;
            this.bt_fin.Click += new System.EventHandler(this.bt_fin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "tous les incidents  :";
            // 
            // dg_incidents
            // 
            this.dg_incidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_incidents.Location = new System.Drawing.Point(25, 82);
            this.dg_incidents.Name = "dg_incidents";
            this.dg_incidents.RowTemplate.Height = 24;
            this.dg_incidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_incidents.Size = new System.Drawing.Size(578, 296);
            this.dg_incidents.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "valider la tâche ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 22);
            this.textBox1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(662, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Date de la résolution de l\'incidents  :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(779, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "aujourd\'hui";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(1035, 415);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 47;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // update_incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_incidents);
            this.Name = "update_incident";
            this.Text = "update_incident";
            ((System.ComponentModel.ISupportInitialize)(this.dg_incidents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_incidents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_bug;
    }
}