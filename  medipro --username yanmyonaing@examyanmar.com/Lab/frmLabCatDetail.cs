using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using exaCore;

namespace Lab
{
    public partial class frmLabCatDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmLabCatDetail()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int Cnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabCat WHERE labCatName=@LabCatName and labCatPK <>@labCatPK AND isDelete=0", new SqlParameter("@LabCatName", txtName.Text.Trim()), new SqlParameter("@labCatPK",txtName.Tag));

                if (Cnt > 0)
                {
                    MessageBox.Show("Your Lab Category Name is already exit. Please check your Lab Category Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
            
                else
                {
                    if (txtName.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabCat WHERE labCatPK=@labCatPK AND isDelete=0", new SqlParameter("@labCatPK", txtName.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblLabCat SET labCatName=@LabCatName,isActive=@IsActive,updateDate=SYSDATETIME(),updatePK=@UpdatePK WHERE labCatPK=@labCatPK",
                                            new SqlParameter("@labCatPK", int.Parse(txtName.Tag.ToString())),
                                            new SqlParameter("@labCatName", txtName.Text.Trim()),
                                            new SqlParameter("@IsActive", chkIsActive.EditValue),
                                            new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Test Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int LabID = SqlDb.ExecuteScalar<int>("getID tblLabCat");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabCat WHERE labCatPK=@labCatPK AND isDelete=0", new SqlParameter("@labCatPK", LabID));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblLabCat(labCatPK,labCatName,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@labCatPK,@LabCatName,@IsActive,SYSDATETIME(),@updatePK,SYSDATETIME(),@createPK)",
                                                new SqlParameter("@labCatPK", LabID),
                                                new SqlParameter("@LabCatName", txtName.Text.Trim()),
                                                new SqlParameter("@IsActive", chkIsActive.EditValue),
                                                new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new SqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Lab Category Name.");

                             DialogResult dr = MessageBox.Show("Save is successful. Do you want to create another record?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtName.Text = string.Empty;
                                txtName.Tag = string.Empty;

                                chkIsActive.EditValue = true;

                                txtName.Focus();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (txtName.Text.Length < 1)
            {
                MessageBox.Show("Please enter Lab Category name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtName.Focus();
            }
            return value;
        }
    }
}
