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
    public partial class Master_Detail : Form
    {
        OracleDataAdapter adapter1 , adapter2 , adapter3 , adapter4;
        DataSet ds1 , ds2;
 
        public Master_Detail()
        {
            InitializeComponent();
        }

        private void Master_Detail_Load(object sender, EventArgs e)
        {
            /*string constr = "Data Source = orcl ; User ID = hr ; Password=hr;";
            adapter1 = new OracleDataAdapter("Select ELECTIONID , ENAME from ELECTION", constr);
            adapter2 = new OracleDataAdapter("Select * from PARTICIPATE", constr);
           
            ds1 = new DataSet();
            adapter1.Fill(ds1, "ELE");
            adapter2.Fill(ds1, "PA");

            DataRelation r = new DataRelation("fk", ds1.Tables[0].Columns["ELECTIONID"], ds1.Tables[1].Columns["ELECTIONID"]);
            ds1.Relations.Add(r);

            BindingSource bs_Master = new BindingSource(ds1, "ELE");
            BindingSource bs_Child = new BindingSource(bs_Master, "fk");

            
            dataGridView1.DataSource = bs_Master;
            dataGridView2.DataSource = bs_Child;
            /////////////////////////////////////////////////////////////////////////
            adapter3 = new OracleDataAdapter("Select CANID , CNAME from CANDIDTAE", constr);
            adapter4 = new OracleDataAdapter("Select * from PARTICIPATE", constr);

            ds2 = new DataSet();
            adapter3.Fill(ds2, "CAND");
            adapter4.Fill(ds2, "PAR");

            DataRelation r2 = new DataRelation("fk2", ds2.Tables[0].Columns["CANID"], ds2.Tables[1].Columns["CANID"]);
            ds2.Relations.Add(r2);

            BindingSource bs_Master2 = new BindingSource(ds2, "CAND");
            BindingSource bs_Child2 = new BindingSource(bs_Master2, "fk2");


            dataGridView3.DataSource = bs_Master2;
            dataGridView4.DataSource = bs_Child2;*/
            string constr = "Data Source = orcl ; User ID = hr ; Password=hr;";
            OracleDataAdapter ad1 = new OracleDataAdapter("select * from ADMEN", constr);
            OracleDataAdapter ad2 = new OracleDataAdapter("select * from ELECTION", constr);

            DataSet ds = new DataSet();
            ad1.Fill(ds, "AdminTable");
            ad2.Fill(ds , "ElectionTable");

            DataRelation r = new DataRelation("fk", ds.Tables[0].Columns["AID"], ds.Tables[1].Columns["ADMINID"]);
            ds.Relations.Add(r);

            BindingSource Master = new BindingSource(ds, "AdminTable");
            BindingSource Children = new BindingSource(Master , "fk");

            dataGridView7.DataSource = Master;
            dataGridView8.DataSource = Children;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
