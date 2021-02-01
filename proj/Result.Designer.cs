namespace proj
{
    partial class Result
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
            this.cmb_election_ID = new System.Windows.Forms.ComboBox();
            this.Winner_Candidate = new System.Windows.Forms.Label();
            this.txt_Number_Of_Votes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Number_Of_Votes = new System.Windows.Forms.Label();
            this.txt_Candidate_id = new System.Windows.Forms.TextBox();
            this.txt_Candidate_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Election_ID";
            // 
            // cmb_election_ID
            // 
            this.cmb_election_ID.FormattingEnabled = true;
            this.cmb_election_ID.Location = new System.Drawing.Point(301, 64);
            this.cmb_election_ID.Name = "cmb_election_ID";
            this.cmb_election_ID.Size = new System.Drawing.Size(121, 21);
            this.cmb_election_ID.TabIndex = 1;
            this.cmb_election_ID.SelectedIndexChanged += new System.EventHandler(this.cmb_election_ID_SelectedIndexChanged);
            // 
            // Winner_Candidate
            // 
            this.Winner_Candidate.AutoSize = true;
            this.Winner_Candidate.Location = new System.Drawing.Point(200, 151);
            this.Winner_Candidate.Name = "Winner_Candidate";
            this.Winner_Candidate.Size = new System.Drawing.Size(95, 13);
            this.Winner_Candidate.TabIndex = 2;
            this.Winner_Candidate.Text = "Winner_Candidate";
            // 
            // txt_Number_Of_Votes
            // 
            this.txt_Number_Of_Votes.Location = new System.Drawing.Point(301, 91);
            this.txt_Number_Of_Votes.Name = "txt_Number_Of_Votes";
            this.txt_Number_Of_Votes.Size = new System.Drawing.Size(121, 20);
            this.txt_Number_Of_Votes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Candidate_id";
            // 
            // Number_Of_Votes
            // 
            this.Number_Of_Votes.AutoSize = true;
            this.Number_Of_Votes.Location = new System.Drawing.Point(201, 98);
            this.Number_Of_Votes.Name = "Number_Of_Votes";
            this.Number_Of_Votes.Size = new System.Drawing.Size(94, 13);
            this.Number_Of_Votes.TabIndex = 6;
            this.Number_Of_Votes.Text = "Number_Of_Votes";
            // 
            // txt_Candidate_id
            // 
            this.txt_Candidate_id.Location = new System.Drawing.Point(301, 117);
            this.txt_Candidate_id.Name = "txt_Candidate_id";
            this.txt_Candidate_id.Size = new System.Drawing.Size(121, 20);
            this.txt_Candidate_id.TabIndex = 7;
            // 
            // txt_Candidate_name
            // 
            this.txt_Candidate_name.Location = new System.Drawing.Point(301, 148);
            this.txt_Candidate_name.Name = "txt_Candidate_name";
            this.txt_Candidate_name.Size = new System.Drawing.Size(121, 20);
            this.txt_Candidate_name.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save In Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Candidate_name);
            this.Controls.Add(this.txt_Candidate_id);
            this.Controls.Add(this.Number_Of_Votes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Number_Of_Votes);
            this.Controls.Add(this.Winner_Candidate);
            this.Controls.Add(this.cmb_election_ID);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_election_ID;
        private System.Windows.Forms.Label Winner_Candidate;
        private System.Windows.Forms.TextBox txt_Number_Of_Votes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Number_Of_Votes;
        private System.Windows.Forms.TextBox txt_Candidate_id;
        private System.Windows.Forms.TextBox txt_Candidate_name;
        private System.Windows.Forms.Button button1;
    }
}