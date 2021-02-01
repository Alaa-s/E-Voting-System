using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using CrystalDecisions.Shared;

namespace proj
{
    public partial class crystal : Form
    {
        GroupedColumns cr; 
        public crystal()
        {
            InitializeComponent();
        }

        private void crystal_Load(object sender, EventArgs e)
        {
            cr = new GroupedColumns();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                Admin_comboBox.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0 , Admin_comboBox.Text);
            cr.SetParameterValue(1, Convert.ToDateTime(txtStartDate.Text));
            cr.SetParameterValue(2, Convert.ToDateTime (txtEndDate.Text));
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
