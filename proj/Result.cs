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
    public partial class Result : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn; 
        public Result()
        {
            InitializeComponent();
        }
       private void Result_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            /////////////////////////////////////////
            OracleCommand cmd_ELECTION = new OracleCommand();
            cmd_ELECTION.Connection = conn;
            cmd_ELECTION.CommandText = "select ELECTIONID from ELECTION";
            cmd_ELECTION.CommandType = CommandType.Text;
            OracleDataReader dr = cmd_ELECTION.ExecuteReader();
            while (dr.Read())
            {
                cmb_election_ID.Items.Add(dr[0]);
            }
            dr.Close();
        }
        private void cmb_election_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select MAX(COUNTER) from PARTICIPATE where ELECTIONID=:id ";
            c.Parameters.Add("id", cmb_election_ID.SelectedItem.ToString());

            OracleDataReader ddr = c.ExecuteReader();
            if (ddr.Read())
            {
                txt_Number_Of_Votes.Text = ddr[0].ToString();
            }
            ddr.Close();

            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "select CANID   from PARTICIPATE where ELECTIONID=:id and COUNTER=:x ";
            c2.Parameters.Add("id", cmb_election_ID.SelectedItem.ToString());
            c2.Parameters.Add("x", txt_Number_Of_Votes.Text);

            OracleDataReader ddr2 = c2.ExecuteReader();
            if (ddr2.Read())
            {
                txt_Candidate_id.Text = ddr2[0].ToString();
            
            }
            ddr2.Close();

            OracleCommand c3 = new OracleCommand();
            c3.Connection = conn;
            c3.CommandText = "select CNAME  from CANDIDTAE where CANID=:id  ";
            c3.Parameters.Add("id", txt_Candidate_id.Text);
          

            OracleDataReader ddr3 = c3.ExecuteReader();
            if (ddr3.Read())
            {
                txt_Candidate_name.Text = ddr3[0].ToString();

            }
            ddr3.Close();
        }

        private void Show_Result_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c4 = new OracleCommand();
            c4.Connection = conn;
            c4.CommandText = "insert into RESULT values (:cid, :eid, :x )";
            c4.Parameters.Add(":cid", txt_Candidate_id.Text);
            c4.Parameters.Add(":eid", cmb_election_ID.SelectedItem.ToString());
            c4.Parameters.Add(":x", txt_Number_Of_Votes.Text);
          

            int r4 = c4.ExecuteNonQuery();
            if (r4 != -1)
            {
               
                MessageBox.Show("New RESULT successfully added ");
            }
        }

      
    }
}
