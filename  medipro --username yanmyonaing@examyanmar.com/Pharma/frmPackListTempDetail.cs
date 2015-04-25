using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using exaCore;
using MySql.Data.MySqlClient;

namespace Pharma
{
    public partial class frmPackListTempDetail : Form
    {
        clsSQL SqlDb = new clsSQL();
        private DataTable dtGridSource;

        public frmPackListTempDetail()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            bool IsValid = false;
            string strErrMsg = "";
            int intPackListID = int.Parse(txtPackListTempName.Tag.ToString());

            if (txtPackListTempName.Text.Length > 0)
            {
                int DupCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblPackListTemp WHERE isDelete=0 AND packListName='" + txtPackListTempName.Text + "' AND packListPK<>" + intPackListID.ToString());

                if (DupCnt > 0)
                {
                    IsValid = false;
                    strErrMsg += "Template name is already exist.\n\r";
                }
                else
                {
                    IsValid = true;
                }
            }
            else
            {
                IsValid = false;
                strErrMsg += "Template name must be filled.\n\r";
            }

            if (IsValid)
            {
                if (intPackListID == 0)
                {
                    intPackListID = SqlDb.ExecuteScalar<int>("getID 'tblPackListTemp'");

                    SqlDb.ExecuteQuery("INSERT INTO tblPackListTemp(packListPK,packListName,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@packListPK,@packListName,@isActive,NOW(),@updatePK,NOW(),@createPK)",
                                                new MySqlParameter("@packListPK", intPackListID),
                                                new MySqlParameter("@packListName", txtPackListTempName.Text.Trim()),
                                                new MySqlParameter("@isActive", chkIsActive.EditValue),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));



                    DialogResult dr = MessageBox.Show("The template has been saved successfully. Do you want to create other template?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        txtPackListTempName.Text = string.Empty;
                        txtPackListTempName.Tag = string.Empty;

                        chkIsActive.EditValue = true;

                        txtPackListTempName.Focus();
                    }
                    


                }
                else
                {
                    SqlDb.ExecuteQuery("UPDATE tblPackListTemp SET packListName=@packListName,isActive=@isActive,updateDate=NOW(),updatePK=@UpdatePK WHERE packListPK=@packListPK",
                                            new MySqlParameter("@packListPK", intPackListID.ToString()),
                                            new MySqlParameter("@packListName", txtPackListTempName.Text.Trim()),
                                            new MySqlParameter("@isActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                    MessageBox.Show("The template has been saved successfully.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

                SqlDb.ExecuteQuery("DELETE FROM tblPackListTempDetail WHERE packlistPK="+intPackListID.ToString());

                foreach (DataRow drSave in dtGridSource.Rows)
                {
                    if (drSave.RowState != DataRowState.Deleted)
                    {
                        int intFromUnit = int.Parse(drSave["fromUnitPK"].ToString());
                        int intToUnit = int.Parse(drSave["toUnitPK"].ToString());
                        if ((intFromUnit > 0) && (intToUnit > 0))
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblPackListTempDetail(packListPK,toUnitPK, fromUnitPK, fromValue)" +
                                            " VALUES(" + intPackListID.ToString() + "," + drSave["toUnitPK"].ToString() + "," + drSave["fromUnitPK"].ToString() + "," +
                                            drSave["fromValue"].ToString() + ")");
                        }    
                    }
                    

                }



               
            }
            else
            {
                MessageBox.Show(strErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (txtPackListTempName.Text.Length < 1)
            {
                MessageBox.Show("Please enter diagnosis.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtPackListTempName.Focus();
            }
            return value;
        }

        private void frmPackListTempDetail_Load(object sender, EventArgs e)
        {
            dtGridSource = SqlDb.GetDataSet("SELECT fromUnitPK, fromValue, toUnitPK, 1 toValue FROM  tblPackListTempDetail WHERE packListPK=" + txtPackListTempName.Tag.ToString()).Tables[0];
            DataSet dsUnitFrom = SqlDb.GetDataSet("SELECT medUnitPK, medUnitName FROM  tblMedUnit  WHERE isDelete=0 ORDER BY medUnitName");
            DataSet dsUnitTo = SqlDb.GetDataSet("SELECT medUnitPK, medUnitName FROM  tblMedUnit  WHERE isDelete=0  ORDER BY medUnitName");


            gridPackList.DataSource = dtGridSource;
            resLookupFromUnit.DataSource = dsUnitFrom.Tables[0];
            resLookupToUnit.DataSource = dsUnitTo.Tables[0];
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void btnDeletUnit_Click(object sender, EventArgs e)
        {
            grdViewPackList.DeleteRow(grdViewPackList.FocusedRowHandle);
            DataView dvSource = (DataView)grdViewPackList.DataSource;
            DataTable dtSource = dvSource.Table;
            dtGridSource = dtSource;
        }
    }
}
