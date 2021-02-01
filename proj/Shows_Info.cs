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
    public partial class Shows_Info : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Shows_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
       
           
            MessageBox.Show("Info has been saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdstr = "";
            string constr = "Data Source = orcl ; User ID = hr ; Password=hr;";

            if (rdo_voters.Checked)
                cmdstr = "select * from VOTER";
            else if (rdo_candidate.Checked)
                cmdstr = "select * from CANDIDTAE";
            else if (rdo_election.Checked)
                cmdstr = "select * from ELECTION";
            else if (rdo_admin.Checked)
                cmdstr = "select * from ADMEN";
            else if (rdo_position.Checked)
                cmdstr = "select * from POSTION";
            else if (rdo_result.Checked)
                cmdstr = "select * from RESULT";

            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
