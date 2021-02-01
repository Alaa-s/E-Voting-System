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
    public partial class Search_Admin_Election : Form
    {
        public Search_Admin_Election()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl ; user ID = hr ; password = hr;";
            string cmdstr = @"select  e.ENAME , e.STARTDATE , e.ENDDATE 
                            from ELECTION e 
                            where  e.ADMINID = :n ";
            OracleDataAdapter adapter3 = new OracleDataAdapter(cmdstr, constr);
            adapter3.SelectCommand.Parameters.Add("n", textBox1.Text);
            DataSet ds3 = new DataSet();
            adapter3.Fill(ds3);
            dataGridView1.DataSource = ds3.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl ; user ID = hr ; password = hr;";
            string cmdstr = @"select e.ENAME 
                            from ELECTION e , PARTICIPATE pa, CANDIDTAE c 
                            where e.ELECTIONID = pa.ELECTIONID
                            and c.CANID = pa.CANID 
                            and c.CNAME = :n ";
            OracleDataAdapter adapter3 = new OracleDataAdapter(cmdstr, constr);
            adapter3.SelectCommand.Parameters.Add("n", textBox2.Text);
            DataSet ds3 = new DataSet();
            adapter3.Fill(ds3);
            dataGridView2.DataSource = ds3.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr4 = "Data Source = orcl ; user ID = hr ; password = hr;";
            string cmdstr4 = @"select  *from CANDIDTAE   ";                 
                          
            OracleDataAdapter adapter4 = new OracleDataAdapter(cmdstr4, constr4);
            DataSet ds4 = new DataSet();
            adapter4.Fill(ds4);
            dataGridView3.DataSource = ds4.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr4 = "Data Source = orcl ; user ID = hr ; password = hr;";
            string cmdstr4 = @"select  *from ADMEN   ";

            OracleDataAdapter adapter4 = new OracleDataAdapter(cmdstr4, constr4);
            DataSet ds4 = new DataSet();
            adapter4.Fill(ds4);
            dataGridView3.DataSource = ds4.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string constr4 = "Data Source = orcl ; user ID = hr ; password = hr;";
            string cmdstr4 = @"select  *from ELECTION  ";

            OracleDataAdapter adapter4 = new OracleDataAdapter(cmdstr4, constr4);
            DataSet ds4 = new DataSet();
            adapter4.Fill(ds4);
            dataGridView3.DataSource = ds4.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string constr4 = "Data Source = orcl ; user ID = hr ; password = hr;";
            string cmdstr4 = @"select  *from VOTER  ";

            OracleDataAdapter adapter4 = new OracleDataAdapter(cmdstr4, constr4);
            DataSet ds4 = new DataSet();
            adapter4.Fill(ds4);
            dataGridView3.DataSource = ds4.Tables[0];
        }
    }
}
