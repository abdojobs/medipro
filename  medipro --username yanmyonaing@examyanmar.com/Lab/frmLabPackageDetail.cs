using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using exaCore;

namespace Lab
{
    public partial class frmLabPackageDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmLabPackageDetail()
        {
            InitializeComponent();
            DataTable dt = SqlDb.GetDataSet("Select labTestPK,labTestName from tblLabTest").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                dgv.Rows.Add(dr.ItemArray);
            }

            cboLab.DataSource = SqlDb.GetDataSet("Select * from tblLaboratory").Tables[0];
            cboLab.DisplayMember = "labName";
            cboLab.ValueMember = "labPK";
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int LabCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabPackage WHERE labPackName=@labPackName AND isDelete=0 AND labPackPK <>@labPackPK", new MySqlParameter("@labPackName", txtName.Text.Trim()), new MySqlParameter("@labPackPK",txtName.Tag));

                if (LabCnt > 0)
                {
                    MessageBox.Show("Your Lab Package name is already exit. Please check your Lab Package name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    if (txtName.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabPackage WHERE labPackPK=@labPackPK AND isDelete=0", new MySqlParameter("@labPackPK", txtName.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblLabPackage SET labPackName=@labPackName,labPK=@labPK,isActive=@IsActive,updateDate=NOW(),updatePK=@UpdatePK WHERE labPackPK=@labPackPK",
                                            new MySqlParameter("@labPackPK", int.Parse(txtName.Tag.ToString())),
                                            new MySqlParameter("@labPK",cboLab.SelectedValue),
                                            new MySqlParameter("@labPackName", txtName.Text.Trim()),
                                            new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            SqlDb.ExecuteNonQuery("Delete from tblLabPackageDetail where labPackPK=@labPackPK", new MySqlParameter("@labPackPK", txtName.Tag));
                            for (int i = 0; i < dgvPicked.Rows.Count; i++)
                            {
                                SqlDb.ExecuteQuery("Insert into tblLabPackageDetail(labPackPK,labTestPK,createPK,createDate,updatePK,updateDate)"+
                                            "values(@labPackPK,@labTestPK,@createPK,NOW(),@updatePK,NOW())",
                                            new MySqlParameter("@labPackPK",txtName.Tag),
                                            new MySqlParameter("@labTestPK", dgvPicked.Rows[i].Cells[0].Value),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                            new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK)
                                            );
                            }

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Test Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int LabID = SqlDb.ExecuteScalar<int>("Call getID ('tblLabPackage')");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabPackage WHERE labPackPK=@labPackPK AND isDelete=0", new MySqlParameter("@labPackPK", LabID));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblLabPackage(labPackPK,labPackName,labPK,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@labPackPK,@labPackName,@labPK,@IsActive,NOW(),@updatePK,NOW(),@createPK)",
                                                new MySqlParameter("@labPackPK", LabID),
                                                new MySqlParameter("@labPackName", txtName.Text.Trim()),
                                                new MySqlParameter("@labPK", cboLab.SelectedValue),
                                                new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            for (int i = 0; i < dgvPicked.Rows.Count; i++)
                            {
                                SqlDb.ExecuteQuery("Insert into tblLabPackageDetail(labPackPK,labTestPK,createPK,createDate,updatePK,updateDate)" +
                                                "values(@labPackPK,@labTestPK,@createPK,NOW(),@updatePK,NOW())",
                                                new MySqlParameter("@labPackPK", LabID),
                                                new MySqlParameter("@labTestPK", dgvPicked.Rows[i].Cells[0].Value),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK)
                                                );
                            }

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Lab Package.");

                            DialogResult dr = MessageBox.Show("Save is successful. Do you want to create other Package?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtName.Text = string.Empty;
                                txtName.Tag = string.Empty;
                                cboLab.SelectedIndex = -1;
                                dgv.Rows.Clear();
                                dgvPicked.Rows.Clear();
                                DataTable dt = SqlDb.GetDataSet("Select labTestPK,labTestName from tblLabTest").Tables[0];
                                foreach (DataRow ddr in dt.Rows)
                                {
                                    dgv.Rows.Add(ddr.ItemArray);
                                }

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
                MessageBox.Show("Please enter Lab name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtName.Focus();
            }
            return value;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dgvPicked.Rows.Add(new object[] { dgv.CurrentRow.Cells[0].Value, dgv.CurrentRow.Cells[1].Value });
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            dgv.Rows.Add(new object[] { dgvPicked.CurrentRow.Cells[0].Value, dgvPicked.CurrentRow.Cells[1].Value });
            dgvPicked.Rows.RemoveAt(dgvPicked.CurrentRow.Index);
        }

        private void cmdRemoveAll_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            dgvPicked.Rows.Clear();
            DataTable dt = SqlDb.GetDataSet("Select labTestPK,labTestName from tblLabTest").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                dgv.Rows.Add(dr.ItemArray);
            }
        }

        private void frmLabPackageDetail_Load(object sender, EventArgs e)
        {
            if (txtName.Tag != null)
            {
                DataTable dt= new DataTable();
                dt= SqlDb.GetDataSet("select labTestPK,labTestName from tblLabTest except select tblLabPackageDetail.labTestPK,tblLabTest.labTestName from tblLabPackageDetail inner join tblLabTest on tblLabPackageDetail.labTestPK=tblLabTest.labTestPK where tblLabPackageDetail.labPackPK=@labPackPK", new MySqlParameter("@labPackPK", txtName.Tag)).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    dgv.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgv.Rows.Add(new object[] {dr["labTestPK"],dr["labTestName"] });
                    }
                    
                }
                cboLab.SelectedValue = SqlDb.ExecuteScalar<int>("Select labPK from tblLabPackage where labPackPK=@labPackPK", new MySqlParameter("@labPackPK", txtName.Tag));
                dt = new DataTable();
                dt = SqlDb.GetDataSet("select tblLabPackageDetail.labTestPK,tblLabTest.labTestName from tblLabPackageDetail inner join tblLabTest on tblLabPackageDetail.labTestPK=tblLabTest.labTestPK where tblLabPackageDetail.labPackPK=@labPackPK", new MySqlParameter("@labPackPK", txtName.Tag)).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvPicked.Rows.Add(new object[] { dr["labTestPK"], dr["labTestName"] });
                    }
                }
            }
        }
    }
}
