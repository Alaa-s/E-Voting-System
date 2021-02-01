namespace proj
{
    partial class VOTING
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_voter_id = new System.Windows.Forms.ComboBox();
            this.cmb_elections = new System.Windows.Forms.ComboBox();
            this.cmb_candidate_ID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VOTER ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ELECTION ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CANDIDATE ID";
            // 
            // cmb_voter_id
            // 
            this.cmb_voter_id.FormattingEnabled = true;
            this.cmb_voter_id.Location = new System.Drawing.Point(120, 39);
            this.cmb_voter_id.Name = "cmb_voter_id";
            this.cmb_voter_id.Size = new System.Drawing.Size(121, 21);
            this.cmb_voter_id.TabIndex = 3;
            this.cmb_voter_id.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmb_elections
            // 
            this.cmb_elections.FormattingEnabled = true;
            this.cmb_elections.Location = new System.Drawing.Point(120, 70);
            this.cmb_elections.Name = "cmb_elections";
            this.cmb_elections.Size = new System.Drawing.Size(121, 21);
            this.cmb_elections.TabIndex = 4;
            this.cmb_elections.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmb_candidate_ID
            // 
            this.cmb_candidate_ID.FormattingEnabled = true;
            this.cmb_candidate_ID.Location = new System.Drawing.Point(120, 102);
            this.cmb_candidate_ID.Name = "cmb_candidate_ID";
            this.cmb_candidate_ID.Size = new System.Drawing.Size(121, 21);
            this.cmb_candidate_ID.TabIndex = 5;
            this.cmb_candidate_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "VOTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VOTING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_candidate_ID);
            this.Controls.Add(this.cmb_elections);
            this.Controls.Add(this.cmb_voter_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VOTING";
            this.Text = "VOTING";
            this.Load += new System.EventHandler(this.VOTING_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_voter_id;
        private System.Windows.Forms.ComboBox cmb_elections;
        private System.Windows.Forms.ComboBox cmb_candidate_ID;
        private System.Windows.Forms.Button button1;
    }
}