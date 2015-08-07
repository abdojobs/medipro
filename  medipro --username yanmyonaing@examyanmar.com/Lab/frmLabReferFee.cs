using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using exaCore;

namespace Lab
{
    public partial class frmLabReferFee : Form
    {
        clsSQL sqldb;
        public frmLabReferFee()
        {
            InitializeComponent();
            sqldb = new clsSQL();
            grd.DataSource = sqldb.GetDataSet("select * from tbllabreferfee as rf inner join tbllabtest as lt on lt.labTestPK= rf.testPK").Tables[0];
            lueLabTest.DataSource = sqldb.GetDataSet("Select * from tbllabtest").Tables[0];
        }

        private void chkSameForAll_Click(object sender, EventArgs e)
        {
            if (chkSameForAll.Checked)
            {
                object value=null;
                if( new GetValueDialog(ref value).ShowDialog()!=DialogResult.Cancel)
                {
                    foreach (DataRow dr in ((DataView)grdView.DataSource).Table.Rows)
                    {
                        dr["referPercent"] = value;
                    }
                }
                
            }
        }
    }
}
