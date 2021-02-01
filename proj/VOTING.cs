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
    public partial class VOTING : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn; 

        public VOTING()
        {
            InitializeComponent();
        }

        private void VOTING_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            /////////////////////////////////
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
            //////////////////////////
            OracleCommand cmd_ELECTION = new OracleCommand();
            cmd_ELECTION.Connection = conn;
            cmd_ELECTION.CommandText = "select ELECTIONID from ELECTION";
            cmd_ELECTION.CommandType = CommandType.Text;
            OracleDataReader d2 = cmd_ELECTION.ExecuteReader();
            while (d2.Read())
            {
                cmb_elections.Items.Add(d2[0]);
            }
            d2.Close();
            ////////////////////////////
            OracleCommand cmd_CANDIDATE = new OracleCommand();
            cmd_CANDIDATE.Connection = conn;
            cmd_CANDIDATE.CommandText = "select CANID from CANDIDTAE";
            cmd_CANDIDATE.CommandType = CommandType.Text;
            OracleDataReader d3 = cmd_CANDIDATE.ExecuteReader();
            while (d3.Read())
            {
                cmb_candidate_ID.Items.Add(d3[0]);
            }
            d3.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;
            c1.CommandText = "select * from VOTER where VOTERID=:id ";
            c1.Parameters.Add("id", cmb_voter_id.SelectedItem.ToString());*/

            /*OracleDataReader ddr1 = c1.ExecuteReader();
            if (ddr1.Read())
            {
                txt_voter_name.Text = ddr1[1].ToString();
                txt_voter_address.Text = ddr1[2].ToString();
                txt_voter_mobile.Text = ddr1[3].ToString();
                txt_voter_email.Text = ddr1[4].ToString();
                txt_voter_login_id.Text = ddr1[5].ToString();

            }
            ddr1.Close();*/
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;
            c1.CommandText = "select * from ELECTION where EID=:x ";
            c1.Parameters.Add("x", cmb_elections.SelectedItem.ToString());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into VOTE values (:idv, :ide, :idc  )";
            cmd.Parameters.Add(":idv", cmb_voter_id.Text);
            cmd.Parameters.Add(":ide", cmb_elections.Text);
            cmd.Parameters.Add(":idc", cmb_candidate_ID.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show(" successfully voted");
            }//افرض عمل vote لناس مشتركتش
            //طب لو ضاف حاجة أصلّا موجودة
            int maxCounter, newCounter;
            OracleCommand cmdt = new OracleCommand();
            cmdt.Connection = conn;
            cmdt.CommandText = "GETCOUNTER";
            cmdt.CommandType = CommandType.StoredProcedure;
            cmdt.Parameters.Add("x", OracleDbType.Int32, ParameterDirection.Output);
            cmdt.Parameters.Add("idc", cmb_candidate_ID.Text);
            cmdt.Parameters.Add("ide", cmb_elections.Text);
            cmdt.ExecuteNonQuery();
            MessageBox.Show(" successfully 111updated in participate");
            try
            {
                maxCounter = Convert.ToInt32(cmdt.Parameters["x"].Value.ToString());
                newCounter = maxCounter + 1;
            }
            catch
            {
                newCounter = 1;
            }
            MessageBox.Show(" done");
      
            
            OracleCommand ccmd = new OracleCommand();
            ccmd.Connection = conn;
           //ccmd.CommandText = "insert into  PARTICIPATE values ( :idc , :ide ,   :x  ) ";
            ccmd.CommandText = "update PARTICIPATE set COUNTER=:x where CANID =:idc and ELECTIONID=:ide  ";
            ccmd.Parameters.Add("x", newCounter);
            ccmd.Parameters.Add("idc", cmb_candidate_ID.Text);
            ccmd.Parameters.Add("ide", cmb_elections.Text);
            
            int r2 = ccmd.ExecuteNonQuery();
            if (r2 != -1)
            {

                MessageBox.Show(" successfully 2223updated in participate");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
