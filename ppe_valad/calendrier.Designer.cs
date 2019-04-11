namespace ppe_valad
{
    partial class calendrier
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
            this.cb_formation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_Session = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_bug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Session)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_formation
            // 
            this.cb_formation.FormattingEnabled = true;
            this.cb_formation.Location = new System.Drawing.Point(21, 70);
            this.cb_formation.Name = "cb_formation";
            this.cb_formation.Size = new System.Drawing.Size(354, 24);
            this.cb_formation.TabIndex = 39;
            this.cb_formation.SelectedIndexChanged += new System.EventHandler(this.cb_formation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Formation :";
            // 
            // dg_Session
            // 
            this.dg_Session.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Session.Location = new System.Drawing.Point(21, 193);
            this.dg_Session.Name = "dg_Session";
            this.dg_Session.RowTemplate.Height = 24;
            this.dg_Session.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Session.Size = new System.Drawing.Size(578, 225);
            this.dg_Session.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Session :";
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(588, 437);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 42;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // calendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 461);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.dg_Session);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_formation);
            this.Controls.Add(this.label2);
            this.Name = "calendrier";
            this.Text = "calendrier";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Session)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_formation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_Session;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_bug;
    }
}