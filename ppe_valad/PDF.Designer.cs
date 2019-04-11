namespace ppe_valad
{
    partial class PDF
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
            this.button1 = new System.Windows.Forms.Button();
            this.lb_log = new System.Windows.Forms.Label();
            this.dg_session = new System.Windows.Forms.DataGridView();
            this.dg_participant = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_bug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_session)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(746, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_log
            // 
            this.lb_log.AutoSize = true;
            this.lb_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.lb_log.Location = new System.Drawing.Point(20, 9);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(131, 29);
            this.lb_log.TabIndex = 4;
            this.lb_log.Text = "Sessions :";
            // 
            // dg_session
            // 
            this.dg_session.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_session.Location = new System.Drawing.Point(25, 61);
            this.dg_session.Name = "dg_session";
            this.dg_session.RowTemplate.Height = 24;
            this.dg_session.Size = new System.Drawing.Size(746, 206);
            this.dg_session.TabIndex = 5;
            this.dg_session.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_session_CellContentClick_1);
            // 
            // dg_participant
            // 
            this.dg_participant.AllowUserToAddRows = false;
            this.dg_participant.AllowUserToDeleteRows = false;
            this.dg_participant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_participant.Location = new System.Drawing.Point(25, 355);
            this.dg_participant.Name = "dg_participant";
            this.dg_participant.ReadOnly = true;
            this.dg_participant.RowTemplate.Height = 24;
            this.dg_participant.Size = new System.Drawing.Size(746, 191);
            this.dg_participant.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(20, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Emargement :";
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(696, 637);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 43;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_participant);
            this.Controls.Add(this.dg_session);
            this.Controls.Add(this.lb_log);
            this.Controls.Add(this.button1);
            this.Name = "PDF";
            this.Text = "PDF";
            ((System.ComponentModel.ISupportInitialize)(this.dg_session)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_log;
        private System.Windows.Forms.DataGridView dg_session;
        private System.Windows.Forms.DataGridView dg_participant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_bug;
    }
}