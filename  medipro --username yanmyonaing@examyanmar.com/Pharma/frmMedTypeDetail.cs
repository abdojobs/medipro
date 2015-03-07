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

namespace Pharma
{
    public partial class frmMedTypeDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmMedTypeDetail()
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
                int Cnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblMedType WHERE medTypeName=@MedTypeName AND isDelete=0", new SqlParameter("@MedTypeName", txtName.Text.Trim()));

                if (Cnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your Medicine Type Name is already exit. Please check your Medicine Type Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    if (txtName.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblMedType WHERE medTypePK=@MedTypePK AND isDelete=0", new SqlParameter("@MedTypePK", txtName.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblMedType SET medTypeName=@MedTypeName,isActive=@IsActive,updateDate=SYSDATETIME(),updatePK=@UpdatePK WHERE medTypePK=@MedTypePK",
                                            new SqlParameter("@MedTypePK", int.Parse(txtName.Tag.ToString())),
                                            new SqlParameter("@medTypeName", txtName.Text.Trim()),
                                            new SqlParameter("@IsActive", chkIsActive.EditValue),
                                            new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Test Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int LabID = SqlDb.ExecuteScalar<int>("getID tblMedType");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblMedType WHERE medTypePK=@MedTypePK AND isDelete=0", new SqlParameter("@MedTypePK", LabID));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblMedType(medTypePK,medTypeName,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@MedTypePK,@MedTypeName,@IsActive,SYSDATETIME(),@updatePK,SYSDATETIME(),@createPK)",
                                                new SqlParameter("@MedTypePK", LabID),
                                                new SqlParameter("@MedTypeName", txtName.Text.Trim()),
                                                new SqlParameter("@IsActive", chkIsActive.EditValue),
                                                new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new SqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Medicine Type Name.");

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
                MessageBox.Show("Please enter Medicine Type name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtName.Focus();
            }
            return value;
        }
    }
}
