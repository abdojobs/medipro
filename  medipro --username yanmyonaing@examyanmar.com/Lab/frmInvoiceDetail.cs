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
    public partial class frmDoctorDetail : Form
    {
        clsSQL SqlDb = new clsSQL();
        string loginID = string.Empty;
        int CurUserID;

        public frmDoctorDetail()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHomePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChar = "0123456789-,()";

            if ((allowedChar.IndexOf(e.KeyChar) == -1) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtMobilePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChar = "0123456789-,()";

            if ((allowedChar.IndexOf(e.KeyChar) == -1) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void BindingTitle()
        {
            DataSet dsTitle = SqlDb.GetDataSet("SELECT titlePK, TitleName FROM tblTitle WHERE isActive = 1");

            try
            {
                cboTitle.DataSource = dsTitle.Tables[0];
                cboTitle.DisplayMember = "TitleName";
                cboTitle.ValueMember = "titlePK";
                cboTitle.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindingSpecialize()
        {
            DataSet dsSpec = SqlDb.GetDataSet("SELECT specializePK, specialize FROM tblSpecialize WHERE isActive = 1");

            try
            {
                cboSpecialize.DataSource = dsSpec.Tables[0];
                cboSpecialize.DisplayMember = "specialize";
                cboSpecialize.ValueMember = "specializePK";
                cboSpecialize.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindingPosition()
        {
            DataSet dsPos = SqlDb.GetDataSet("SELECT positionPK, position FROM tblPosition WHERE isActive = 1");

            try
            {
                cboPosition.DataSource = dsPos.Tables[0];
                cboPosition.DisplayMember = "position";
                cboPosition.ValueMember = "positionPK";
                cboPosition.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDoctorDetail_Load(object sender, EventArgs e)
        {
            BindingTitle();
            BindingSpecialize();
            BindingPosition();

            if (cmdSave.Tag.ToString() == "Add")
                FormClean("Add");

            if (cmdSave.Tag.ToString() == "View")
            {
                cboTitle.SelectedValue = cboTitle.Tag.ToString();
                cboSpecialize.SelectedValue = cboSpecialize.Tag.ToString();
                cboPosition.SelectedValue = cboPosition.Tag.ToString();
                FormClean("View");
            }

            if (cmdSave.Tag.ToString() == "Edit")
            {
                FormClean("Edit");
                cboTitle.SelectedValue = cboTitle.Tag.ToString();
                cboSpecialize.SelectedValue = cboSpecialize.Tag.ToString();
                cboPosition.SelectedValue = cboPosition.Tag.ToString();
            } 
        }

        private void FormClean(string Status)
        {
            if (Status == "Add")
            {
                txtName.Text = string.Empty;
                cboSpecialize.SelectedIndex = -1;
                cboTitle.SelectedIndex = -1;
                cboGender.SelectedIndex = -1;
                cboPosition.SelectedIndex = -1;
                txtSAMA.Text = string.Empty;
                txtHomePhone.Text = string.Empty;
                txtMobilePhone.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtAddress.Text = string.Empty;
                chkIsActive.Checked = true;                
            }
            else if (Status == "View")
            {
                txtName.Enabled = false;
                cboSpecialize.Enabled = false;
                cboTitle.Enabled = false;
                cboGender.Enabled = false;
                cboPosition.Enabled = false;
                txtSAMA.Enabled = false;
                txtHomePhone.Enabled = false;
                txtMobilePhone.Enabled = false;
                txtEmail.Enabled = false;
                txtAddress.Enabled = false;
                chkIsActive.Enabled = false;  
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int DocCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblDoctor WHERE doctor=@Doctor AND isDelete=0", new MySqlParameter("@Doctor", txtName.Text.Trim()));

                if (DocCnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your doctor name is already exit. Please check your title.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    if (txtName.Tag.ToString().Length > 0)
                    {
                        int DocIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblDoctor WHERE doctorPK=@DoctorPK AND isDelete=0", new MySqlParameter("@DoctorPK", txtName.Tag.ToString()));

                        if (DocIDCnt > 0)
                        {
                            if (DublicateSAMA() == true)
                            {
                                SqlDb.ExecuteQuery("UPDATE tblDoctor SET doctor=@Doctor,titlePK=@TitlePK,specializePK=@SpecializePK,gender=@Gender,positionPK=@PositionPK," +
                                                "samaNo=@SamaNo,homePhone=@HomePhone,mobilePhone=@MobilePhone,email=@Email,address=@Address,isActive=@IsActive," +
                                                "updateDate=SYSDATETIME(),updatePK=@UpdatePK WHERE doctorPK=@DoctorPK",
                                                new MySqlParameter("@DoctorPK", int.Parse(txtName.Tag.ToString())),
                                                new MySqlParameter("@Doctor", txtName.Text.Trim()),
                                                new MySqlParameter("@TitlePK", cboTitle.SelectedValue),
                                                new MySqlParameter("@SpecializePK", cboSpecialize.SelectedValue),
                                                new MySqlParameter("@Gender", cboGender.Text),
                                                new MySqlParameter("@PositionPK", cboPosition.SelectedValue),
                                                new MySqlParameter("@SamaNo", txtSAMA.Text.Trim()),
                                                new MySqlParameter("@HomePhone", txtHomePhone.Text.Trim()),
                                                new MySqlParameter("@MobilePhone", txtMobilePhone.Text.Trim()),
                                                new MySqlParameter("@Email", txtEmail.Text.Trim()),
                                                new MySqlParameter("@Address", txtAddress.Text.Trim()),
                                                new MySqlParameter("@IsActive", chkIsActive.EditValue), 
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK));

                                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Doctor.");

                                MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        if (DublicateSAMA() == true)
                        {
                            int DocID = SqlDb.ExecuteScalar<int>("getID tblDoctor");

                            int DcoIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblDoctor WHERE doctorPK=@DoctorPK AND isDelete=0", new MySqlParameter("@DoctorPK", DocID));

                            if (DcoIDCnt < 1)
                            {
                                SqlDb.ExecuteQuery("INSERT INTO tblDoctor(doctorPK,doctor,titlePK,specializePK,gender,positionPK,samaNo,homePhone,mobilePhone,email,address,isActive,createPK,createDate,updatePK,updateDate) " +
                                                    "VALUES(@DoctorPK,@Doctor,@TitlePK,@SpecializePK,@Gender,@PositionPK,@SamaNo,@HomePhone,@MobilePhone,@Email,@Address,@IsActive,@CreatePK,SYSDATETIME(),@UpdatePK,SYSDATETIME())",
                                                    new MySqlParameter("@DoctorPK", DocID),
                                                    new MySqlParameter("@Doctor", txtName.Text.Trim()),
                                                    new MySqlParameter("@TitlePK", cboTitle.SelectedValue),
                                                    new MySqlParameter("@SpecializePK", cboSpecialize.SelectedValue),
                                                    new MySqlParameter("@Gender", cboGender.Text),
                                                    new MySqlParameter("@PositionPK", cboPosition.SelectedValue),
                                                    new MySqlParameter("@SamaNo", txtSAMA.Text.Trim()),
                                                    new MySqlParameter("@HomePhone", txtHomePhone.Text.Trim()),
                                                    new MySqlParameter("@MobilePhone", txtMobilePhone.Text.Trim()),
                                                    new MySqlParameter("@Email", txtEmail.Text.Trim()),
                                                    new MySqlParameter("@Address", txtAddress.Text.Trim()),
                                                    new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                                    new MySqlParameter("@CreatePK", AppVariable.CURRENT_USER_PK),
                                                    new MySqlParameter("@UpdatePK", AppVariable.CURRENT_USER_PK));

                                CreateUser();

                                SqlDb.ExecuteQuery("UPDATE tblDoctor SET userPK=@UserPK WHERE doctorPK=@DoctorPK",
                                                new MySqlParameter("@DoctorPK", DocID),
                                                new MySqlParameter("@UserPK", CurUserID));

                                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Doctor.");

                                DialogResult = MessageBox.Show("Save is successful. " + System.Environment.NewLine + "Login ID : " + loginID + System.Environment.NewLine + "Password : passw0rd" + System.Environment.NewLine + "Do you want to create new doctor?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                if (DialogResult == DialogResult.Yes)
                                {
                                    txtName.Text = string.Empty;
                                    txtName.Tag = string.Empty;

                                    chkIsActive.EditValue = true;

                                    cboTitle.Focus();
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
        }

        void CreateUser()
        {
            loginID = txtName.Text.ToLower().Trim();
            loginID = loginID.Replace(" ", "");

            int UIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUser WHERE login=@Login AND isDelete=0", new MySqlParameter("@Login", loginID));
            
            if (UIDCnt > 0)
            {
                int n = 1;
                while (n < 999)
                {
                    UIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUser WHERE login=@Login AND isDelete=0", new MySqlParameter("@Login", loginID + n));

                    if (UIDCnt > 0)
                        n++;

                    if (UIDCnt < 1)
                    {
                        loginID = loginID + n;
                        n = 1000;
                    }
                }
            }

            CurUserID = SqlDb.ExecuteScalar<int>("getID sysUser");

            int UserIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUser WHERE PK=@UserID AND isDelete=0", new MySqlParameter("@UserID", CurUserID));

            if (UserIDCnt < 1)
            {
                string pwd = Crypto.Encrypt("passw0rd");

                SqlDb.ExecuteQuery("INSERT INTO sysUser(PK,name,login,passw,levelPK,IsActive,updateDate,createDate) " +
                                    "VALUES(@UserID,@FullName,@LoginID,@PSW,@LevelPK,@IsActive,SYSDATETIME(),SYSDATETIME())",
                                    new MySqlParameter("@UserID", CurUserID),
                                    new MySqlParameter("@FullName", txtName.Text.Trim()),
                                    new MySqlParameter("@LoginID", loginID),
                                    new MySqlParameter("@LevelPK", 5),
                                    new MySqlParameter("@PSW", pwd),
                                    new MySqlParameter("@IsActive", chkIsActive.EditValue));

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New User");
            }
        }

        private bool DublicateSAMA()
        {
            bool value = true;
            int SAMACnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblDoctor WHERE samaNo=@SamaNo AND doctorPK<>@DoctorPK AND isDelete=0", 
                                                new MySqlParameter("@SamaNo", txtSAMA.Text.Trim()),
                                                new MySqlParameter("@DoctorPK",txtName.Tag.ToString()));

            if (SAMACnt > 0)
            {
                MessageBox.Show("Your SAMA Number is dublicate. Please check your SAMA No.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtSAMA.Focus();
            }

            return value;
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (txtName.Text.Length < 1)
            {
                MessageBox.Show("Please enter Doctor's Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtName.Focus();
            }
            else if (cboTitle.Text.Length < 1)
            {
                MessageBox.Show("Please select Title.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                cboTitle.Focus();
            }
            else if (cboGender.Text.Length < 1)
            {
                MessageBox.Show("Please select Gender.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                cboGender.Focus();
            }
            else if (cboSpecialize.Text.Length < 1)
            {
                MessageBox.Show("Please select Specialize.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                cboSpecialize.Focus();
            }
            else if (cboPosition.Text.Length < 1)
            {
                MessageBox.Show("Please select Position.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                cboPosition.Focus();
            }
            else if (txtSAMA.Text.Length < 1)
            {
                MessageBox.Show("Please enter SAMA No.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtSAMA.Focus();
            }
            return value;
        }
    }
}
