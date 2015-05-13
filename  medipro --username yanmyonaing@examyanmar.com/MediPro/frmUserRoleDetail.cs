using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using exaCore;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace MediPro
{
    public partial class frmUserRoleDetail : Form
    {
        clsSQL SqlDb = new clsSQL();
        public static int intRolePK = 0;
        private DataTable dtGridSource;

        public frmUserRoleDetail()
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

            if (txtRoleName.Text.Length > 0)
            {
                int DupCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysRoles WHERE isDelete=0 AND roleName='" + txtRoleName.Text + "' AND rolePK<>" + intRolePK.ToString());

                if (DupCnt > 0)
                {
                    IsValid = false;
                    strErrMsg += "Role name is already exist.\n\r";
                }
                else
                {
                    IsValid = true;
                }
            }
            else
            {
                IsValid = false;
                strErrMsg += "Role name must be filled.\n\r";
            }

            if (IsValid)
            {
                if (intRolePK == 0)
                {
                    intRolePK = SqlDb.ExecuteScalar<int>("getID 'sysRoles'");

                    SqlDb.ExecuteQuery("INSERT INTO sysroles(rolePK,roleName,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@rolePK,@roleName,@isActive,NOW(),@updatePK,NOW(),@createPK)",
                                                new MySqlParameter("@rolePK", intRolePK),
                                                new MySqlParameter("@roleName", txtRoleName.Text.Trim()),
                                                new MySqlParameter("@isActive", chkIsActive.EditValue),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));


                }
                else
                {
                    SqlDb.ExecuteQuery("UPDATE sysroles SET roleName=@roleName,isActive=@isActive,updateDate=NOW(),updatePK=@UpdatePK WHERE rolePK=@rolePK",
                                            new MySqlParameter("@rolePK", intRolePK.ToString()),
                                            new MySqlParameter("@roleName", txtRoleName.Text.Trim()),
                                            new MySqlParameter("@isActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                    
                    
                }

                SqlDb.ExecuteQuery("DELETE FROM sysrolepolicy WHERE rolePK="+intRolePK.ToString());

                foreach (DataRow drSave in dtGridSource.Rows)
                {
                    if (drSave.RowState != DataRowState.Deleted)
                    {
                        int intPolicyPK = int.Parse(drSave["policyPK"].ToString());
                        bool booIsAllow = bool.Parse(drSave["isAllowed"].ToString());
                        
                        if (booIsAllow)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO sysrolepolicy (policyPK,rolePK)" +
                                            " VALUES(" + intPolicyPK.ToString() + "," + intRolePK.ToString() + ")");
                        }    
                    }
                    

                }


                MessageBox.Show("The role has been saved successfully.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);



               
            }
            else
            {
                MessageBox.Show(strErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void frmUserRoleDetail_Load(object sender, EventArgs e)
        {
            if (intRolePK>0)
            {
                string strRoleName = "";
                strRoleName = SqlDb.ExecuteScalar<string>("SELECT roleName FROM sysroles WHERE rolePK=" + intRolePK.ToString());
                txtRoleName.Text = strRoleName;

                bool booIsActive = true;
                booIsActive = SqlDb.ExecuteScalar<bool>("SELECT isActive FROM sysroles WHERE rolePK=" + intRolePK.ToString());
                chkIsActive.Checked = booIsActive;    
            }
            

            dtGridSource = SqlDb.GetDataSet("SELECT policyPK, policyText FROM syspolicies").Tables[0];

            dtGridSource.Columns.Add("isAllowed",typeof(Boolean));

            for (int iloop = 0; iloop < dtGridSource.Rows.Count; iloop++)
            {
                int intPolicyPK = int.Parse(dtGridSource.Rows[iloop]["policyPK"].ToString());

                int intPolicyCnt  = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysrolepolicy WHERE rolePK = " + intRolePK.ToString() + " AND policyPK = " + intPolicyPK.ToString());

                if (intPolicyCnt > 0)
                {
                    dtGridSource.Rows[iloop]["isAllowed"] = true;    
                }
                else
                {
                    dtGridSource.Rows[iloop]["isAllowed"] = false;    
                }

                
            }            


            gridRole.DataSource = dtGridSource;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }
    }
}
