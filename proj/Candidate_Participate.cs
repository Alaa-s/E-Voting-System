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
    public partial class Candidate_Participate : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;

        public Candidate_Participate()
        {
            InitializeComponent();
        }

        private void Candidate_Participate_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd_CANDIDATE = new OracleCommand();
            cmd_CANDIDATE.Connection = conn;
            cmd_CANDIDATE.CommandText = "select CANID from CANDIDTAE";
            cmd_CANDIDATE.CommandType = CommandType.Text;
            OracleDataReader d3 = cmd_CANDIDATE.ExecuteReader();
            while (d3.Read())
            {
                comboBox1.Items.Add(d3[0]);
            }
            d3.Close();
            //////////////////////////////
            OracleCommand cmd_ELECTION = new OracleCommand();
            cmd_ELECTION.Connection = conn;
            cmd_ELECTION.CommandText = "select ELECTIONID from ELECTION";
            cmd_ELECTION.CommandType = CommandType.Text;
            OracleDataReader d2 = cmd_ELECTION.ExecuteReader();
            while (d2.Read())
            {
                comboBox2.Items.Add(d2[0]);
            }
            d2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into PARTICIPATE values (:Cid, :Eid , 0  )";
            cmd.Parameters.Add("Cid", comboBox1.Text);
            cmd.Parameters.Add("Eid", comboBox2.Text);
            //cmd.Parameters.Add("c",0);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show(" successfully PARTICIPATED");
            }

           
           
        }
    }
}
