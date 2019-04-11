namespace ppe_valad
{
    partial class convocation
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dg_session = new System.Windows.Forms.DataGridView();
            this.dg_participant = new System.Windows.Forms.DataGridView();
            this.bt_bug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_session)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(584, 461);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(583, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "telecharger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_session
            // 
            this.dg_session.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_session.Location = new System.Drawing.Point(656, 37);
            this.dg_session.Name = "dg_session";
            this.dg_session.RowTemplate.Height = 24;
            this.dg_session.Size = new System.Drawing.Size(481, 214);
            this.dg_session.TabIndex = 2;
            this.dg_session.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_session_CellContentClick);
            // 
            // dg_participant
            // 
            this.dg_participant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_participant.Location = new System.Drawing.Point(656, 278);
            this.dg_participant.Name = "dg_participant";
            this.dg_participant.RowTemplate.Height = 24;
            this.dg_participant.Size = new System.Drawing.Size(481, 214);
            this.dg_participant.TabIndex = 3;
            this.dg_participant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_participant_CellContentClick);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(1076, 503);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 43;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // convocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 538);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.dg_participant);
            this.Controls.Add(this.dg_session);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "convocation";
            this.Text = "convocation";
            ((System.ComponentModel.ISupportInitialize)(this.dg_session)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_participant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_session;
        private System.Windows.Forms.DataGridView dg_participant;
        private System.Windows.Forms.Button bt_bug;
    }
}