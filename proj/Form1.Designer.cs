namespace proj
{
    partial class Form1
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
            this.cmb_candidate_ID = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_insert_candidate = new System.Windows.Forms.Button();
            this.btn_update_candidate = new System.Windows.Forms.Button();
            this.btn_delete_candidate = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmb_elections = new System.Windows.Forms.ComboBox();
            this.btn_show_avail_elec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_AdminNum = new System.Windows.Forms.TextBox();
            this.btn_insert_election = new System.Windows.Forms.Button();
            this.txt_election_type = new System.Windows.Forms.TextBox();
            this.txt_election_startdate = new System.Windows.Forms.TextBox();
            this.txt_election_enddate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_election_name = new System.Windows.Forms.TextBox();
            this.btn_update_date = new System.Windows.Forms.Button();
            this.btn_delete_election = new System.Windows.Forms.Button();
            this.txt_election_id = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_voter_login_id = new System.Windows.Forms.TextBox();
            this.txt_voter_email = new System.Windows.Forms.TextBox();
            this.txt_voter_mobile = new System.Windows.Forms.TextBox();
            this.txt_voter_address = new System.Windows.Forms.TextBox();
            this.txt_voter_name = new System.Windows.Forms.TextBox();
            this.btn_delete_voter = new System.Windows.Forms.Button();
            this.btn_update_voter = new System.Windows.Forms.Button();
            this.btn_insert_voter = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_voter_id = new System.Windows.Forms.ComboBox();
            this.cmb_Admin_ID = new System.Windows.Forms.ComboBox();
            this.btn_delete_admin = new System.Windows.Forms.Button();
            this.btn_update_admin = new System.Windows.Forms.Button();
            this.btn_insert_admin = new System.Windows.Forms.Button();
            this.txt_Admin_Email = new System.Windows.Forms.TextBox();
            this.txt_Admin_Mobile = new System.Windows.Forms.TextBox();
            this.txt_Admin_Address = new System.Windows.Forms.TextBox();
            this.txt_Admin_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Candidate_name = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Admin_login_id = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_update_election = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidate ID";
            // 
            // cmb_candidate_ID
            // 
            this.cmb_candidate_ID.FormattingEnabled = true;
            this.cmb_candidate_ID.Location = new System.Drawing.Point(100, 11);
            this.cmb_candidate_ID.Name = "cmb_candidate_ID";
            this.cmb_candidate_ID.Size = new System.Drawing.Size(64, 21);
            this.cmb_candidate_ID.TabIndex = 1;
            this.cmb_candidate_ID.SelectedIndexChanged += new System.EventHandler(this.cmb_ID_SelectedIndexChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(100, 43);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(64, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Candidate Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Candidate Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Candidate Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Candidate Email";
            // 
            // btn_insert_candidate
            // 
            this.btn_insert_candidate.Location = new System.Drawing.Point(61, 206);
            this.btn_insert_candidate.Name = "btn_insert_candidate";
            this.btn_insert_candidate.Size = new System.Drawing.Size(59, 21);
            this.btn_insert_candidate.TabIndex = 10;
            this.btn_insert_candidate.Text = "Insert";
            this.btn_insert_candidate.UseVisualStyleBackColor = true;
            this.btn_insert_candidate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_update_candidate
            // 
            this.btn_update_candidate.Location = new System.Drawing.Point(61, 233);
            this.btn_update_candidate.Name = "btn_update_candidate";
            this.btn_update_candidate.Size = new System.Drawing.Size(59, 22);
            this.btn_update_candidate.TabIndex = 11;
            this.btn_update_candidate.Text = "Update";
            this.btn_update_candidate.UseVisualStyleBackColor = true;
            this.btn_update_candidate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_delete_candidate
            // 
            this.btn_delete_candidate.Location = new System.Drawing.Point(61, 261);
            this.btn_delete_candidate.Name = "btn_delete_candidate";
            this.btn_delete_candidate.Size = new System.Drawing.Size(59, 22);
            this.btn_delete_candidate.TabIndex = 12;
            this.btn_delete_candidate.Text = "Delete";
            this.btn_delete_candidate.UseVisualStyleBackColor = true;
            this.btn_delete_candidate.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(100, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(64, 20);
            this.textBox4.TabIndex = 13;
            // 
            // cmb_elections
            // 
            this.cmb_elections.FormattingEnabled = true;
            this.cmb_elections.Location = new System.Drawing.Point(645, 41);
            this.cmb_elections.Name = "cmb_elections";
            this.cmb_elections.Size = new System.Drawing.Size(162, 21);
            this.cmb_elections.TabIndex = 15;
            this.cmb_elections.SelectedIndexChanged += new System.EventHandler(this.cmb_elections_SelectedIndexChanged);
            // 
            // btn_show_avail_elec
            // 
            this.btn_show_avail_elec.Location = new System.Drawing.Point(502, 41);
            this.btn_show_avail_elec.Name = "btn_show_avail_elec";
            this.btn_show_avail_elec.Size = new System.Drawing.Size(137, 24);
            this.btn_show_avail_elec.TabIndex = 16;
            this.btn_show_avail_elec.Text = "Show Available Elections";
            this.btn_show_avail_elec.UseVisualStyleBackColor = true;
            this.btn_show_avail_elec.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Admin ID";
            // 
            // txt_AdminNum
            // 
            this.txt_AdminNum.Location = new System.Drawing.Point(645, 14);
            this.txt_AdminNum.Name = "txt_AdminNum";
            this.txt_AdminNum.Size = new System.Drawing.Size(74, 20);
            this.txt_AdminNum.TabIndex = 18;
            // 
            // btn_insert_election
            // 
            this.btn_insert_election.Location = new System.Drawing.Point(620, 281);
            this.btn_insert_election.Name = "btn_insert_election";
            this.btn_insert_election.Size = new System.Drawing.Size(68, 22);
            this.btn_insert_election.TabIndex = 19;
            this.btn_insert_election.Text = "INSERT";
            this.btn_insert_election.UseVisualStyleBackColor = true;
            this.btn_insert_election.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_election_type
            // 
            this.txt_election_type.Location = new System.Drawing.Point(613, 170);
            this.txt_election_type.Name = "txt_election_type";
            this.txt_election_type.Size = new System.Drawing.Size(146, 20);
            this.txt_election_type.TabIndex = 22;
            this.txt_election_type.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_election_startdate
            // 
            this.txt_election_startdate.Location = new System.Drawing.Point(613, 200);
            this.txt_election_startdate.Name = "txt_election_startdate";
            this.txt_election_startdate.Size = new System.Drawing.Size(145, 20);
            this.txt_election_startdate.TabIndex = 23;
            // 
            // txt_election_enddate
            // 
            this.txt_election_enddate.Location = new System.Drawing.Point(613, 230);
            this.txt_election_enddate.Name = "txt_election_enddate";
            this.txt_election_enddate.Size = new System.Drawing.Size(145, 20);
            this.txt_election_enddate.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "TYBE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "STARTDATE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(532, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "ENDDATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "ELECTIONAME";
            // 
            // txt_election_name
            // 
            this.txt_election_name.Location = new System.Drawing.Point(614, 144);
            this.txt_election_name.Name = "txt_election_name";
            this.txt_election_name.Size = new System.Drawing.Size(145, 20);
            this.txt_election_name.TabIndex = 31;
            // 
            // btn_update_date
            // 
            this.btn_update_date.Location = new System.Drawing.Point(725, 11);
            this.btn_update_date.Name = "btn_update_date";
            this.btn_update_date.Size = new System.Drawing.Size(129, 22);
            this.btn_update_date.TabIndex = 33;
            this.btn_update_date.Text = "UPDATE DATE";
            this.btn_update_date.UseVisualStyleBackColor = true;
            this.btn_update_date.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_delete_election
            // 
            this.btn_delete_election.Location = new System.Drawing.Point(739, 71);
            this.btn_delete_election.Name = "btn_delete_election";
            this.btn_delete_election.Size = new System.Drawing.Size(60, 22);
            this.btn_delete_election.TabIndex = 34;
            this.btn_delete_election.Text = "DELETE";
            this.btn_delete_election.UseVisualStyleBackColor = true;
            this.btn_delete_election.Click += new System.EventHandler(this.button7_Click);
            // 
            // txt_election_id
            // 
            this.txt_election_id.Location = new System.Drawing.Point(692, 71);
            this.txt_election_id.Name = "txt_election_id";
            this.txt_election_id.Size = new System.Drawing.Size(41, 20);
            this.txt_election_id.TabIndex = 36;
            this.txt_election_id.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(171, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Voter ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(171, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Voter Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(171, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Voter Address";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(171, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Voter Mobile";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(171, 145);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 42;
            this.label23.Text = "Voter Email";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(192, 167);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 43;
            this.label24.Text = "Login ID";
            // 
            // txt_voter_login_id
            // 
            this.txt_voter_login_id.Location = new System.Drawing.Point(246, 165);
            this.txt_voter_login_id.Name = "txt_voter_login_id";
            this.txt_voter_login_id.Size = new System.Drawing.Size(59, 20);
            this.txt_voter_login_id.TabIndex = 49;
            // 
            // txt_voter_email
            // 
            this.txt_voter_email.Location = new System.Drawing.Point(246, 139);
            this.txt_voter_email.Name = "txt_voter_email";
            this.txt_voter_email.Size = new System.Drawing.Size(59, 20);
            this.txt_voter_email.TabIndex = 48;
            // 
            // txt_voter_mobile
            // 
            this.txt_voter_mobile.Location = new System.Drawing.Point(246, 102);
            this.txt_voter_mobile.Name = "txt_voter_mobile";
            this.txt_voter_mobile.Size = new System.Drawing.Size(59, 20);
            this.txt_voter_mobile.TabIndex = 47;
            // 
            // txt_voter_address
            // 
            this.txt_voter_address.Location = new System.Drawing.Point(246, 76);
            this.txt_voter_address.Name = "txt_voter_address";
            this.txt_voter_address.Size = new System.Drawing.Size(59, 20);
            this.txt_voter_address.TabIndex = 46;
            // 
            // txt_voter_name
            // 
            this.txt_voter_name.Location = new System.Drawing.Point(246, 42);
            this.txt_voter_name.Name = "txt_voter_name";
            this.txt_voter_name.Size = new System.Drawing.Size(59, 20);
            this.txt_voter_name.TabIndex = 45;
            this.txt_voter_name.TextChanged += new System.EventHandler(this.txt_voter_name_TextChanged);
            // 
            // btn_delete_voter
            // 
            this.btn_delete_voter.Location = new System.Drawing.Point(220, 257);
            this.btn_delete_voter.Name = "btn_delete_voter";
            this.btn_delete_voter.Size = new System.Drawing.Size(59, 22);
            this.btn_delete_voter.TabIndex = 52;
            this.btn_delete_voter.Text = "Delete";
            this.btn_delete_voter.UseVisualStyleBackColor = true;
            this.btn_delete_voter.Click += new System.EventHandler(this.btn_delete_voter_Click);
            // 
            // btn_update_voter
            // 
            this.btn_update_voter.Location = new System.Drawing.Point(220, 229);
            this.btn_update_voter.Name = "btn_update_voter";
            this.btn_update_voter.Size = new System.Drawing.Size(59, 22);
            this.btn_update_voter.TabIndex = 51;
            this.btn_update_voter.Text = "Update";
            this.btn_update_voter.UseVisualStyleBackColor = true;
            this.btn_update_voter.Click += new System.EventHandler(this.btn_update_voter_Click);
            // 
            // btn_insert_voter
            // 
            this.btn_insert_voter.Location = new System.Drawing.Point(220, 202);
            this.btn_insert_voter.Name = "btn_insert_voter";
            this.btn_insert_voter.Size = new System.Drawing.Size(59, 21);
            this.btn_insert_voter.TabIndex = 50;
            this.btn_insert_voter.Text = "Insert";
            this.btn_insert_voter.UseVisualStyleBackColor = true;
            this.btn_insert_voter.Click += new System.EventHandler(this.btn_insert_voter_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Login ID";
            // 
            // cmb_voter_id
            // 
            this.cmb_voter_id.FormattingEnabled = true;
            this.cmb_voter_id.Location = new System.Drawing.Point(245, 10);
            this.cmb_voter_id.Name = "cmb_voter_id";
            this.cmb_voter_id.Size = new System.Drawing.Size(60, 21);
            this.cmb_voter_id.TabIndex = 54;
            this.cmb_voter_id.SelectedIndexChanged += new System.EventHandler(this.test_SelectedIndexChanged);
            // 
            // cmb_Admin_ID
            // 
            this.cmb_Admin_ID.FormattingEnabled = true;
            this.cmb_Admin_ID.Location = new System.Drawing.Point(403, 8);
            this.cmb_Admin_ID.Name = "cmb_Admin_ID";
            this.cmb_Admin_ID.Size = new System.Drawing.Size(60, 21);
            this.cmb_Admin_ID.TabIndex = 69;
            this.cmb_Admin_ID.SelectedIndexChanged += new System.EventHandler(this.cmb_Candidate_ID_SelectedIndexChanged);
            // 
            // btn_delete_admin
            // 
            this.btn_delete_admin.Location = new System.Drawing.Point(359, 255);
            this.btn_delete_admin.Name = "btn_delete_admin";
            this.btn_delete_admin.Size = new System.Drawing.Size(59, 22);
            this.btn_delete_admin.TabIndex = 68;
            this.btn_delete_admin.Text = "Delete";
            this.btn_delete_admin.UseVisualStyleBackColor = true;
            this.btn_delete_admin.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_update_admin
            // 
            this.btn_update_admin.Location = new System.Drawing.Point(359, 227);
            this.btn_update_admin.Name = "btn_update_admin";
            this.btn_update_admin.Size = new System.Drawing.Size(59, 22);
            this.btn_update_admin.TabIndex = 67;
            this.btn_update_admin.Text = "Update";
            this.btn_update_admin.UseVisualStyleBackColor = true;
            this.btn_update_admin.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_insert_admin
            // 
            this.btn_insert_admin.Location = new System.Drawing.Point(359, 200);
            this.btn_insert_admin.Name = "btn_insert_admin";
            this.btn_insert_admin.Size = new System.Drawing.Size(59, 21);
            this.btn_insert_admin.TabIndex = 66;
            this.btn_insert_admin.Text = "Insert";
            this.btn_insert_admin.UseVisualStyleBackColor = true;
            this.btn_insert_admin.Click += new System.EventHandler(this.button10_Click);
            // 
            // txt_Admin_Email
            // 
            this.txt_Admin_Email.Location = new System.Drawing.Point(404, 137);
            this.txt_Admin_Email.Name = "txt_Admin_Email";
            this.txt_Admin_Email.Size = new System.Drawing.Size(59, 20);
            this.txt_Admin_Email.TabIndex = 64;
            // 
            // txt_Admin_Mobile
            // 
            this.txt_Admin_Mobile.Location = new System.Drawing.Point(404, 100);
            this.txt_Admin_Mobile.Name = "txt_Admin_Mobile";
            this.txt_Admin_Mobile.Size = new System.Drawing.Size(59, 20);
            this.txt_Admin_Mobile.TabIndex = 63;
            // 
            // txt_Admin_Address
            // 
            this.txt_Admin_Address.Location = new System.Drawing.Point(403, 74);
            this.txt_Admin_Address.Name = "txt_Admin_Address";
            this.txt_Admin_Address.Size = new System.Drawing.Size(59, 20);
            this.txt_Admin_Address.TabIndex = 62;
            // 
            // txt_Admin_name
            // 
            this.txt_Admin_name.Location = new System.Drawing.Point(404, 40);
            this.txt_Admin_name.Name = "txt_Admin_name";
            this.txt_Admin_name.Size = new System.Drawing.Size(59, 20);
            this.txt_Admin_name.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(310, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Admin Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(310, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Admin Mobile";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(310, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 57;
            this.label16.Text = "Admin Address";
            // 
            // Candidate_name
            // 
            this.Candidate_name.AutoSize = true;
            this.Candidate_name.Location = new System.Drawing.Point(310, 42);
            this.Candidate_name.Name = "Candidate_name";
            this.Candidate_name.Size = new System.Drawing.Size(67, 13);
            this.Candidate_name.TabIndex = 56;
            this.Candidate_name.Text = "Admin Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(310, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Admin ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Login ID";
            // 
            // txt_Admin_login_id
            // 
            this.txt_Admin_login_id.Location = new System.Drawing.Point(403, 164);
            this.txt_Admin_login_id.Name = "txt_Admin_login_id";
            this.txt_Admin_login_id.Size = new System.Drawing.Size(59, 20);
            this.txt_Admin_login_id.TabIndex = 71;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(554, 67);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(55, 23);
            this.btn_clear.TabIndex = 72;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(615, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "ELECTIONID";
            // 
            // btn_update_election
            // 
            this.btn_update_election.Location = new System.Drawing.Point(618, 256);
            this.btn_update_election.Name = "btn_update_election";
            this.btn_update_election.Size = new System.Drawing.Size(69, 22);
            this.btn_update_election.TabIndex = 74;
            this.btn_update_election.Text = "UPDATE:(";
            this.btn_update_election.UseVisualStyleBackColor = true;
            this.btn_update_election.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 311);
            this.Controls.Add(this.btn_update_election);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_Admin_login_id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_Admin_ID);
            this.Controls.Add(this.btn_delete_admin);
            this.Controls.Add(this.btn_update_admin);
            this.Controls.Add(this.btn_insert_admin);
            this.Controls.Add(this.txt_Admin_Email);
            this.Controls.Add(this.txt_Admin_Mobile);
            this.Controls.Add(this.txt_Admin_Address);
            this.Controls.Add(this.txt_Admin_name);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Candidate_name);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmb_voter_id);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_delete_voter);
            this.Controls.Add(this.btn_update_voter);
            this.Controls.Add(this.btn_insert_voter);
            this.Controls.Add(this.txt_voter_login_id);
            this.Controls.Add(this.txt_voter_email);
            this.Controls.Add(this.txt_voter_mobile);
            this.Controls.Add(this.txt_voter_address);
            this.Controls.Add(this.txt_voter_name);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_election_id);
            this.Controls.Add(this.btn_delete_election);
            this.Controls.Add(this.btn_update_date);
            this.Controls.Add(this.txt_election_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_election_enddate);
            this.Controls.Add(this.txt_election_startdate);
            this.Controls.Add(this.txt_election_type);
            this.Controls.Add(this.btn_insert_election);
            this.Controls.Add(this.txt_AdminNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_show_avail_elec);
            this.Controls.Add(this.cmb_elections);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btn_delete_candidate);
            this.Controls.Add(this.btn_update_candidate);
            this.Controls.Add(this.btn_insert_candidate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.cmb_candidate_ID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_candidate_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_insert_candidate;
        private System.Windows.Forms.Button btn_update_candidate;
        private System.Windows.Forms.Button btn_delete_candidate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cmb_elections;
        private System.Windows.Forms.Button btn_show_avail_elec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_AdminNum;
        private System.Windows.Forms.Button btn_insert_election;
        private System.Windows.Forms.TextBox txt_election_type;
        private System.Windows.Forms.TextBox txt_election_startdate;
        private System.Windows.Forms.TextBox txt_election_enddate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_election_name;
        private System.Windows.Forms.Button btn_update_date;
        private System.Windows.Forms.Button btn_delete_election;
        private System.Windows.Forms.TextBox txt_election_id;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_voter_login_id;
        private System.Windows.Forms.TextBox txt_voter_email;
        private System.Windows.Forms.TextBox txt_voter_mobile;
        private System.Windows.Forms.TextBox txt_voter_address;
        private System.Windows.Forms.TextBox txt_voter_name;
        private System.Windows.Forms.Button btn_delete_voter;
        private System.Windows.Forms.Button btn_update_voter;
        private System.Windows.Forms.Button btn_insert_voter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_voter_id;
        private System.Windows.Forms.ComboBox cmb_Admin_ID;
        private System.Windows.Forms.Button btn_delete_admin;
        private System.Windows.Forms.Button btn_update_admin;
        private System.Windows.Forms.Button btn_insert_admin;
        private System.Windows.Forms.TextBox txt_Admin_Email;
        private System.Windows.Forms.TextBox txt_Admin_Mobile;
        private System.Windows.Forms.TextBox txt_Admin_Address;
        private System.Windows.Forms.TextBox txt_Admin_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Candidate_name;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Admin_login_id;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_update_election;
    }
}

