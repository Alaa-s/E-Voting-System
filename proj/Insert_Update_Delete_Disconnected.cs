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
    public partial class Insert_Update_Delete_Disconnected : Form
    {
    
        OracleCommandBuilder builder;

        public Insert_Update_Delete_Disconnected()
        {
            InitializeComponent();
        }

        private void cmb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl ; user ID = hr ; password = hr;";
            string cmdstr = @"Update ELECTION 
                            set enddate = add_months(enddate, 2) 
                            where ELECTIONID = :n ";

            OracleDataAdapter adapter3 = new OracleDataAdapter(cmdstr, constr);
            adapter3.SelectCommand.Parameters.Add("n", textBox6.Text);
            DataSet ds3 = new DataSet();
            adapter3.Fill(ds3);
            MessageBox.Show("Done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl ; user ID = hr ; password = hr;";
            string cmdstr = @"Delete from VOTER
                             where VOTERID= :n ";

            OracleDataAdapter adapter4 = new OracleDataAdapter(cmdstr, constr);
            adapter4.SelectCommand.Parameters.Add("n", textBox7.Text);
            DataSet ds4 = new DataSet();
            adapter4.Fill(ds4);
            MessageBox.Show("Done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl ; user ID = hr ; password = hr;";
            string cmdstr = @"insert into  VOTER
                              values (:id , :name , :address , :mobile , :email , :login) ";
                             

            OracleDataAdapter adapter5 = new OracleDataAdapter(cmdstr, constr);
            adapter5.SelectCommand.Parameters.Add("id", textBox1.Text);
            adapter5.SelectCommand.Parameters.Add("name", txt_Name.Text);
            adapter5.SelectCommand.Parameters.Add("address", textBox2.Text);
            adapter5.SelectCommand.Parameters.Add("mobile", textBox3.Text);
            adapter5.SelectCommand.Parameters.Add("email", textBox4.Text);
            adapter5.SelectCommand.Parameters.Add("login", textBox5.Text);
            DataSet ds5 = new DataSet();
            adapter5.Fill(ds5);
            MessageBox.Show("Done");
        }

        private void btn_update_voter_Click(object sender, EventArgs e)
        {
            string constr2 = "Data Source = orcl ; user ID = hr ; password = hr;";
            string cmdstr2 = @"Update VOTER 
                              set VNAME= :name , ADDRESS = :address , MOBILE = :mobile  ,EMAIL = :email ,LOGINID= :loginid  where VOTERID = :id  ";

            OracleDataAdapter adapter6 = new OracleDataAdapter(cmdstr2, constr2);
            adapter6.SelectCommand.Parameters.Add("id", textBox1.Text);
            adapter6.SelectCommand.Parameters.Add("name", txt_Name.Text);
            adapter6.SelectCommand.Parameters.Add("address", textBox2.Text);
            adapter6.SelectCommand.Parameters.Add("mobile", textBox3.Text);
            adapter6.SelectCommand.Parameters.Add("email", textBox4.Text);
            adapter6.SelectCommand.Parameters.Add("login", textBox5.Text);
            DataSet ds6 = new DataSet();
            adapter6.Fill(ds6);
            MessageBox.Show("Done");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
    }
}
