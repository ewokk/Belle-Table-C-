namespace ppe_valad
{
    partial class panneau_user
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
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_bug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(45, 101);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(709, 40);
            this.bt_4.TabIndex = 26;
            this.bt_4.Text = "Calendrier ";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(45, 37);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(709, 40);
            this.bt_3.TabIndex = 25;
            this.bt_3.Text = "Mes Sessions";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_bug
            // 
            this.bt_bug.Location = new System.Drawing.Point(713, 171);
            this.bt_bug.Name = "bt_bug";
            this.bt_bug.Size = new System.Drawing.Size(75, 23);
            this.bt_bug.TabIndex = 43;
            this.bt_bug.Text = "BUG";
            this.bt_bug.UseVisualStyleBackColor = true;
            this.bt_bug.Click += new System.EventHandler(this.bt_bug_Click);
            // 
            // panneau_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 206);
            this.Controls.Add(this.bt_bug);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_3);
            this.Name = "panneau_user";
            this.Text = "panneau_user";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_bug;
    }
}