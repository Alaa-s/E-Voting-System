namespace proj
{
    partial class Shows_Info
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_voters = new System.Windows.Forms.RadioButton();
            this.rdo_candidate = new System.Windows.Forms.RadioButton();
            this.rdo_election = new System.Windows.Forms.RadioButton();
            this.rdo_admin = new System.Windows.Forms.RadioButton();
            this.rdo_position = new System.Windows.Forms.RadioButton();
            this.rdo_result = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_result);
            this.groupBox1.Controls.Add(this.rdo_position);
            this.groupBox1.Controls.Add(this.rdo_admin);
            this.groupBox1.Controls.Add(this.rdo_election);
            this.groupBox1.Controls.Add(this.rdo_candidate);
            this.groupBox1.Controls.Add(this.rdo_voters);
            this.groupBox1.Location = new System.Drawing.Point(139, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdo_voters
            // 
            this.rdo_voters.AutoSize = true;
            this.rdo_voters.Location = new System.Drawing.Point(6, 19);
            this.rdo_voters.Name = "rdo_voters";
            this.rdo_voters.Size = new System.Drawing.Size(77, 17);
            this.rdo_voters.TabIndex = 1;
            this.rdo_voters.TabStop = true;
            this.rdo_voters.Text = "Voter_Info.";
            this.rdo_voters.UseVisualStyleBackColor = true;
            // 
            // rdo_candidate
            // 
            this.rdo_candidate.AutoSize = true;
            this.rdo_candidate.Location = new System.Drawing.Point(6, 42);
            this.rdo_candidate.Name = "rdo_candidate";
            this.rdo_candidate.Size = new System.Drawing.Size(100, 17);
            this.rdo_candidate.TabIndex = 2;
            this.rdo_candidate.TabStop = true;
            this.rdo_candidate.Text = "Candidate_Info.";
            this.rdo_candidate.UseVisualStyleBackColor = true;
            // 
            // rdo_election
            // 
            this.rdo_election.AutoSize = true;
            this.rdo_election.Location = new System.Drawing.Point(6, 65);
            this.rdo_election.Name = "rdo_election";
            this.rdo_election.Size = new System.Drawing.Size(90, 17);
            this.rdo_election.TabIndex = 3;
            this.rdo_election.TabStop = true;
            this.rdo_election.Text = "Election_Info.";
            this.rdo_election.UseVisualStyleBackColor = true;
            // 
            // rdo_admin
            // 
            this.rdo_admin.AutoSize = true;
            this.rdo_admin.Location = new System.Drawing.Point(169, 19);
            this.rdo_admin.Name = "rdo_admin";
            this.rdo_admin.Size = new System.Drawing.Size(81, 17);
            this.rdo_admin.TabIndex = 4;
            this.rdo_admin.TabStop = true;
            this.rdo_admin.Text = "Admin_Info.";
            this.rdo_admin.UseVisualStyleBackColor = true;
            // 
            // rdo_position
            // 
            this.rdo_position.AutoSize = true;
            this.rdo_position.Location = new System.Drawing.Point(169, 42);
            this.rdo_position.Name = "rdo_position";
            this.rdo_position.Size = new System.Drawing.Size(89, 17);
            this.rdo_position.TabIndex = 5;
            this.rdo_position.TabStop = true;
            this.rdo_position.Text = "Position_Info.";
            this.rdo_position.UseVisualStyleBackColor = true;
            // 
            // rdo_result
            // 
            this.rdo_result.AutoSize = true;
            this.rdo_result.Location = new System.Drawing.Point(169, 65);
            this.rdo_result.Name = "rdo_result";
            this.rdo_result.Size = new System.Drawing.Size(82, 17);
            this.rdo_result.TabIndex = 6;
            this.rdo_result.TabStop = true;
            this.rdo_result.Text = "Result_Info.";
            this.rdo_result.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 154);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Shows_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Shows_Info";
            this.Text = "Shows_Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_voters;
        private System.Windows.Forms.RadioButton rdo_result;
        private System.Windows.Forms.RadioButton rdo_position;
        private System.Windows.Forms.RadioButton rdo_admin;
        private System.Windows.Forms.RadioButton rdo_election;
        private System.Windows.Forms.RadioButton rdo_candidate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}