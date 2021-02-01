using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace proj
{
    public partial class Form1 : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            /////////////////////////////////////////
            OracleCommand cmd_CANDIDATE = new OracleCommand();
            cmd_CANDIDATE.Connection = conn;
            cmd_CANDIDATE.CommandText = "select CANID from CANDIDTAE";
            cmd_CANDIDATE.CommandType = CommandType.Text;
            OracleDataReader dr = cmd_CANDIDATE.ExecuteReader();
            while (dr.Read())
            {
                cmb_candidate_ID.Items.Add(dr[0]);
            }
            dr.Close();
            //////////////////////////////////////////
            OracleCommand cmd_VOTERS = new OracleCommand();
            cmd_VOTERS.Connection = conn;
            cmd_VOTERS.CommandText = "select VOTERID from VOTER";
            cmd_VOTERS.CommandType = CommandType.Text;
            OracleDataReader d = cmd_VOTERS.ExecuteReader();
            while (d.Read())
            {
                cmb_voter_id.Items.Add(d[0]);
            }
            d.Close();
            ////////////////////////////////////////
            OracleCommand cmd_ADMEN = new OracleCommand();
            cmd_ADMEN.Connection = conn;
            cmd_ADMEN.CommandText = "select AID from ADMEN";
            cmd_ADMEN.CommandType = CommandType.Text;
            OracleDataReader d3 = cmd_ADMEN.ExecuteReader();
            while (d3.Read())
            {
                cmb_Admin_ID.Items.Add(d3[0]);
            }
            d3.Close();

        }

        private void cmb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from CANDIDTAE where CANID=:id ";
            c.Parameters.Add("id", cmb_candidate_ID.SelectedItem.ToString());

            OracleDataReader ddr = c.ExecuteReader();
            if (ddr.Read())
            {
                txt_Name.Text = ddr[1].ToString();
                textBox1.Text = ddr[2].ToString();
                textBox2.Text = ddr[3].ToString();
                textBox3.Text = ddr[4].ToString();
               // textBox4.Text = ddr[5].ToString();              
            }
            ddr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand ccmd = new OracleCommand();
            ccmd.Connection = conn;
            ccmd.CommandText = "insert into CANDIDTAE values (:id, :name, :address , :mobile , :email  )";
            ccmd.Parameters.Add(":id", cmb_candidate_ID.Text);
            ccmd.Parameters.Add(":name", txt_Name.Text);
            ccmd.Parameters.Add(":address", textBox1.Text);
            ccmd.Parameters.Add(":mobile", textBox2.Text);
            ccmd.Parameters.Add(":email", textBox3.Text);
            //ccmd.Parameters.Add(":loginid", textBox4.Text);
            
            int r = ccmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_candidate_ID.Items.Add(cmb_candidate_ID.Text);
                MessageBox.Show("New CANDIDTAE successfully added ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cccmd = new OracleCommand();
            cccmd.Connection = conn;
            cccmd.CommandText = "Update CANDIDTAE set CNAME= :name , ADDRESS = :address , MOBILE = :mobile  ,EMAIL = :email where CANID = :id ";

            
            cccmd.Parameters.Add("name", txt_Name.Text);
            cccmd.Parameters.Add(":address", textBox1.Text);
            cccmd.Parameters.Add(":mobile", textBox2.Text);
            cccmd.Parameters.Add(":email", textBox3.Text);
            //cccmd.Parameters.Add(":loginid", textBox4.Text);

            cccmd.Parameters.Add("id", cmb_candidate_ID.SelectedItem.ToString());
            int r2 = cccmd.ExecuteNonQuery();
            if (r2 != -1)
            {
                MessageBox.Show("Successfully Updated");

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //conn.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand ccccmd = new OracleCommand();
            ccccmd.Connection = conn;
            ccccmd.CommandText = "Delete from CANDIDTAE  where CANID = :id ";

            ccccmd.Parameters.Add("id", cmb_candidate_ID.Text);
            int r3 = ccccmd.ExecuteNonQuery();
            if (r3 != -1)
            {
                MessageBox.Show("Successfully Deleted");
                cmb_candidate_ID.Items.RemoveAt(cmb_candidate_ID.SelectedIndex);
                txt_Name.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
               // textBox4.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand c3 = new OracleCommand();
            c3.Connection = conn;
            c3.CommandText = "GETELECTIONSNAME";
            c3.CommandType = CommandType.StoredProcedure;
            c3.Parameters.Add("ADMINNUM", txt_AdminNum.Text);
            c3.Parameters.Add("ENAME", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = c3.ExecuteReader();
            while (dr.Read())
            {

                cmb_elections.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int maxID, newID;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetElecID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("EID", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();

            try
            {
                maxID = Convert.ToInt32(cmd.Parameters["EID"].Value.ToString());
                newID = maxID + 1;
            }
            catch
            {
                newID = 1;
            }
            
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "INSERT_ELECTION";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("EID", newID);
            //c.Parameters.Add("ENAME", cmb_elections.SelectedIndex.ToString());
            c.Parameters.Add("ENAME", txt_election_name.Text);
            c.Parameters.Add("ETYPE", txt_election_type.Text);
            c.Parameters.Add(" ESTARTDATE", Convert.ToDateTime(txt_election_startdate.Text));
            c.Parameters.Add("EENDDATE", Convert.ToDateTime(txt_election_enddate.Text));
            c.Parameters.Add("ADMINID", txt_AdminNum.Text);
            c.ExecuteNonQuery();
            MessageBox.Show("successfully inserted");

            

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "UPDATE_DATE";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("AID", txt_AdminNum.Text);
            c2.ExecuteNonQuery();
            MessageBox.Show("ELECTION DATE Updated");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OracleCommand c4 = new OracleCommand();
            c4.Connection = conn;
            c4.CommandText = "delete_election";
            c4.CommandType = CommandType.StoredProcedure;
            c4.Parameters.Add("AID", txt_AdminNum.Text);
            c4.ExecuteNonQuery();
            MessageBox.Show("ELECTIONS DELETED");
            //cmb_elections.Items.RemoveAt(cmb_elections.SelectedIndex);
        }

        private void btn_insert_voter_Click(object sender, EventArgs e)
        {
            OracleCommand ccmd = new OracleCommand();
            ccmd.Connection = conn;
            ccmd.CommandText = "insert into voter values (:id, :name, :address , :mobile , :email )";
            ccmd.Parameters.Add(":id", cmb_voter_id.Text);
            ccmd.Parameters.Add(":name", txt_voter_name.Text);
            ccmd.Parameters.Add(":address", txt_voter_address.Text);
            ccmd.Parameters.Add(":mobile", txt_voter_mobile.Text);
            ccmd.Parameters.Add(":email", txt_voter_email.Text);
            //ccmd.Parameters.Add(":loginid", txt_voter_login_id.Text);

            int r = ccmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_candidate_ID.Items.Add(cmb_candidate_ID.Text);
                MessageBox.Show("New VOTER successfully added ");
            }
        }

        private void cmb_voter_id_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_voter_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void test_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;
            c1.CommandText = "select * from VOTER where VOTERID=:id ";
            c1.Parameters.Add("id", cmb_voter_id.SelectedItem.ToString());

            OracleDataReader ddr1 = c1.ExecuteReader();
            if (ddr1.Read())
            {
                txt_voter_name.Text = ddr1[1].ToString();
                txt_voter_address.Text = ddr1[2].ToString();
                txt_voter_mobile.Text = ddr1[3].ToString();
                txt_voter_email.Text = ddr1[4].ToString();
                //txt_voter_login_id.Text = ddr1[5].ToString();

            }
            ddr1.Close();
        }

        private void btn_update_voter_Click(object sender, EventArgs e)
        {
            OracleCommand cccmd = new OracleCommand();
            cccmd.Connection = conn;
            cccmd.CommandText = "Update VOTER set VNAME= :name , ADDRESS = :address , MOBILE = :mobile  ,EMAIL = :email where VOTERID = :id ";


            cccmd.Parameters.Add("name", txt_voter_name.Text);
            cccmd.Parameters.Add(":address", txt_voter_address.Text);
            cccmd.Parameters.Add(":mobile", txt_voter_mobile.Text);
            cccmd.Parameters.Add(":email", txt_voter_email.Text);
           // cccmd.Parameters.Add(":loginid", txt_voter_login_id.Text);

            cccmd.Parameters.Add("id", cmb_voter_id.SelectedItem.ToString());
            int r3 = cccmd.ExecuteNonQuery();
            if (r3 != -1)
            {
                MessageBox.Show("Successfully Updated");

            }
        }

        private void btn_delete_voter_Click(object sender, EventArgs e)
        {
            OracleCommand ccccmd = new OracleCommand();
            ccccmd.Connection = conn;
            ccccmd.CommandText = "Delete from VOTER  where VOTERID = :id ";

            ccccmd.Parameters.Add("id", cmb_voter_id.Text);
            int r3 = ccccmd.ExecuteNonQuery();
            if (r3 != -1)
            {
                MessageBox.Show("Successfully Deleted");
                cmb_candidate_ID.Items.RemoveAt(cmb_voter_id.SelectedIndex);
                txt_voter_name.Text = "";
                txt_voter_address.Text = "";
                txt_voter_mobile.Text = "";
                txt_voter_email.Text = "";
               // txt_voter_login_id.Text = "";
            }
        }

        private void cmb_Candidate_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c3 = new OracleCommand();
            c3.Connection = conn;
            c3.CommandText = "select * from ADMEN where AID=:id ";
            c3.Parameters.Add("id", cmb_Admin_ID.SelectedItem.ToString());

            OracleDataReader ddr3 = c3.ExecuteReader();
            if (ddr3.Read())
            {
                txt_Admin_name.Text = ddr3[1].ToString();
                txt_Admin_Address.Text = ddr3[2].ToString();
                txt_Admin_Mobile.Text = ddr3[3].ToString();
                txt_Admin_Email.Text = ddr3[4].ToString();
                //txt_Admin_login_id.Text = ddr3[5].ToString();

            }
            ddr3.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OracleCommand ccmd = new OracleCommand();
            ccmd.Connection = conn;
            ccmd.CommandText = "insert into ADMEN values (:id, :name, :address , :mobile , :email  )";
            ccmd.Parameters.Add(":id", cmb_Admin_ID.Text);
            ccmd.Parameters.Add(":name", txt_Admin_name.Text);
            ccmd.Parameters.Add(":address", txt_Admin_Address.Text);
            ccmd.Parameters.Add(":mobile", txt_Admin_Mobile.Text);
            ccmd.Parameters.Add(":email", txt_Admin_Email.Text);
            //ccmd.Parameters.Add(":loginid", txt_Admin_login_id.Text);

            int r = ccmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_candidate_ID.Items.Add(cmb_Admin_ID.Text);
                MessageBox.Show("New Admin successfully added ");
            }
        }

        private void cmb_elections_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c4= new OracleCommand();
            c4.Connection = conn;
            c4.CommandText = "select * from ELECTION where ENAME=:name ";
            c4.Parameters.Add("name", cmb_elections.SelectedItem.ToString());

            OracleDataReader ddr4 = c4.ExecuteReader();
            if (ddr4.Read())
            {
                txt_election_id.Text = ddr4[0].ToString();
                txt_election_name.Text = ddr4[1].ToString();
                txt_election_type.Text = ddr4[2].ToString();
                txt_election_startdate.Text = ddr4[3].ToString();
                txt_election_enddate.Text = ddr4[4].ToString();
                //textBox5.Text = ddr4[5].ToString();

            }
            ddr4.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cmb_elections.Items.Clear();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OracleCommand cccmd = new OracleCommand();
            cccmd.Connection = conn;
            cccmd.CommandText = "Update ADMEN set ANAME= :name , ADDRESS = :address , MOBILE = :mobile  ,EMAIL = :email  where AID = :id ";


            cccmd.Parameters.Add(":name", txt_Admin_name.Text);
            cccmd.Parameters.Add(":address", txt_Admin_Address.Text);
            cccmd.Parameters.Add(":mobile", txt_Admin_Mobile.Text);
            cccmd.Parameters.Add(":email", txt_Admin_Email.Text);
            //cccmd.Parameters.Add(":loginid", txt_Admin_login_id.Text);

            cccmd.Parameters.Add("id", cmb_Admin_ID.SelectedItem.ToString());
            int r3 = cccmd.ExecuteNonQuery();
            if (r3 != -1)
            {
                MessageBox.Show("Successfully Admin Updated");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OracleCommand ccccmd = new OracleCommand();
            ccccmd.Connection = conn;
            ccccmd.CommandText = "Delete from ADMEN  where AID = :id ";

            ccccmd.Parameters.Add("id", cmb_Admin_ID.Text);
            int r3 = ccccmd.ExecuteNonQuery();
            if (r3 != -1)
            {
                MessageBox.Show("Successfully Admin Deleted");
                cmb_candidate_ID.Items.RemoveAt(cmb_Admin_ID.SelectedIndex);
                txt_Admin_name.Text = "";
                txt_Admin_Address.Text = "";
                txt_Admin_Mobile.Text = "";
                txt_Admin_Email.Text = "";
               // txt_Admin_login_id.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OracleCommand cccmd = new OracleCommand();
            cccmd.Connection = conn;
            cccmd.CommandText = "Update ELECTION set ENAME= :name , TYBE = :type ,STARTDATE = :stdate  ,ENDDATE = :edate ,ADMINID= :adminid where ELECTIONID = :id ";

            cccmd.Parameters.Add(":name", cmb_elections.SelectedItem.ToString());
            
            cccmd.Parameters.Add(":type", txt_election_type.Text);
            cccmd.Parameters.Add(":stdate", Convert.ToDateTime(txt_election_startdate.Text));
            cccmd.Parameters.Add(":edate", Convert.ToDateTime(txt_election_enddate.Text));
            cccmd.Parameters.Add(":adminid", txt_AdminNum.Text);
            cccmd.Parameters.Add(":id", txt_election_id.Text);
            
            int r3 = cccmd.ExecuteNonQuery();
            if (r3 != -1)
            {
                MessageBox.Show("Successfully Election Updated");

            }

            /*OracleCommand cccmd = new OracleCommand();
            cccmd.Connection = conn;
            cccmd.CommandText = "UPDATE_ELECTION";
            cccmd.Parameters.Add("aid", txt_AdminNum.Text);
            cccmd.Parameters.Add("eid", txt_election_id.Text);
            cccmd.Parameters.Add("ename", cmb_elections.SelectedItem.ToString());
            cccmd.Parameters.Add("etype", txt_election_type.Text);
            cccmd.Parameters.Add("e_start_date", Convert.ToDateTime(txt_election_startdate.Text));
            cccmd.Parameters.Add("e_end_date", Convert.ToDateTime(txt_election_enddate.Text));
            
            
            
            int r3 = cccmd.ExecuteNonQuery();
            if(r3 != -1)
            {
                MessageBox.Show("Successfully Election Updated");

            }*/
        }
    }
}
