using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Repository;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using exaCore;

namespace MediPro
{
    public partial class frmClinicTimeByDoctor : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow drClinicTime;        

        public frmClinicTimeByDoctor()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClinicTimeByDoctor_Load(object sender, EventArgs e)
        {
            BindingDoctor();
            CTDBinding();
        }

        private void CTDBinding()
        {
            if (cboDoctor.Text.Length > 0)
            {
                grdClinicTime.Enabled = true;

                DataSet dsCTD = SqlDb.GetDataSet("SELECT ctdPK, doctorPK, clinicDay, ctdOption, toTime, fromTime FROM tblClinicTimeByDoctor " +
                                        "WHERE isDelete = 0 AND doctorPK = @DoctorPK AND clinicDay=@clinicDay",
                                        new SqlParameter("@clinicDay",cboDay.Text),
                                        new SqlParameter("@DoctorPK", cboDoctor.SelectedValue));

                grdClinicTime.DataSource = dsCTD.Tables[0];
            }
            else
            {
                DataSet dsCTD = SqlDb.GetDataSet("SELECT ctdPK, doctorPK, clinicDay, ctdOption, toTime, fromTime FROM tblClinicTimeByDoctor " +
                                        "WHERE isDelete = 0 AND DoctorPK = 0");


                grdClinicTime.DataSource = dsCTD.Tables[0];

                grdClinicTime.Enabled = false;
            }
        }

        private void BindingDoctor()
        {
            DataSet dsDoctor = SqlDb.GetDataSet("SELECT doctorPK, doctor FROM tblDoctor WHERE isDelete = 0 AND isActive = 1");

            try
            {
                cboDoctor.DataSource = dsDoctor.Tables[0];
                cboDoctor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (cboDoctor.Text.Length > 0 && grdViewClinicTime.RowCount > 0)
            {
                cmdSave.Focus();

                for (int i = 0; i < grdViewClinicTime.RowCount; i++)                
                {
                    if (grdViewClinicTime.GetRowCellDisplayText(i, "fromTime").ToString().Length > 0 && grdViewClinicTime.GetRowCellDisplayText(i, "toTime").ToString().Length > 0 && cboDay.Text.Length>0)
                    {
                        int timeCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblClinicTimeByDoctor WHERE doctorPK = @DoctorPK AND ctdPK = @CTDPK",
                                                                new SqlParameter("@DoctorPK", (grdViewClinicTime.GetRowCellDisplayText(i, "doctorPK") != null) ? grdViewClinicTime.GetRowCellDisplayText(i, "doctorPK") : "0"),
                                                                new SqlParameter("@CTDPK", (grdViewClinicTime.GetRowCellDisplayText(i, "ctdPK") != null) ? grdViewClinicTime.GetRowCellDisplayText(i, "ctdPK") : "0"));

                        if (timeCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblClinicTimeByDoctor SET ctdPK=@CTDPK, doctorPK=@DoctorPK, clinicDay=@ClinicDay, ctdOption=@CTDOption, fromTime=@FromTime, " +
                                                "toTime=@ToTime, updatePK=@UpdatePK, updateDate=SYSDATETIME() WHERE ctdPK = @CTDPK AND doctorPK = @DoctorPK",
                                                new SqlParameter("@CTDPK", grdViewClinicTime.GetRowCellDisplayText(i, "ctdPK").ToString()),
                                                new SqlParameter("@doctorPK", grdViewClinicTime.GetRowCellDisplayText(i, "doctorPK").ToString()),
                                                new SqlParameter("@ClinicDay", cboDay.Text),
                                                new SqlParameter("@CTDOption", grdViewClinicTime.GetRowCellDisplayText(i, "ctdOption").ToString()),
                                                new SqlParameter("@FromTime", grdViewClinicTime.GetRowCellDisplayText(i, "fromTime").ToString()),
                                                new SqlParameter("@ToTime", grdViewClinicTime.GetRowCellDisplayText(i, "toTime").ToString()),
                                                new SqlParameter("@UpdatePK", AppVariable.CURRENT_USER_PK));
                        }
                        else
                        {
                            int CTDPK = SqlDb.ExecuteScalar<int>("getID tblClinicTimeByDoctor");
                            SqlDb.ExecuteQuery("INSERT INTO tblClinicTimeByDoctor(ctdPK, doctorPK, clinicDay, ctdOption, fromTime, toTime, createPK, createDate)" +
                                                "VALUES(@CTDPK, @DoctorPK, @ClinicDay, @CTDOption, @FromTime, @ToTime, @CreatePK, SYSDATETIME())",
                                                new SqlParameter("@CTDPK", CTDPK),
                                                new SqlParameter("@doctorPK", cboDoctor.SelectedValue),
                                                new SqlParameter("@ClinicDay", cboDay.Text),
                                                new SqlParameter("@CTDOption", grdViewClinicTime.GetRowCellDisplayText(i, "ctdOption").ToString()),
                                                new SqlParameter("@FromTime", grdViewClinicTime.GetRowCellDisplayText(i, "fromTime").ToString()),
                                                new SqlParameter("@ToTime", grdViewClinicTime.GetRowCellDisplayText(i, "toTime").ToString()),
                                                new SqlParameter("@CreatePK", AppVariable.CURRENT_USER_PK));
                        }                        
                    }
                }

                MessageBox.Show("Save is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Clinic Time.");

                CTDBinding();
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (grdViewClinicTime.RowCount > 0)
            {
                DialogResult = MessageBox.Show("Are you sure? Do you want to delete it?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult == DialogResult.Yes)
                {
                    int timeCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblClinicTimeByDoctor WHERE doctorPK = @DoctorPK AND ctdPK = @CTDPK",
                                                                new SqlParameter("@DoctorPK", drClinicTime.ItemArray[1]),
                                                                new SqlParameter("@CTDPK", drClinicTime.ItemArray[0]));
                    if (timeCnt > 0)
                    {
                        SqlDb.ExecuteQuery("UPDATE tblClinicTimeByDoctor SET isDelete=@IsDelete, updatePK=@UpdatePK, updateDate=SYSDATETIME() WHERE ctdPK = @CTDPK AND doctorPK = @DoctorPK",
                                            new SqlParameter("@DoctorPK", drClinicTime.ItemArray[1]),
                                            new SqlParameter("@CTDPK", drClinicTime.ItemArray[0]),
                                            new SqlParameter("@IsDelete", 1),
                                            new SqlParameter("@UpdatePK", AppVariable.CURRENT_USER_PK));
                    }

                    MessageBox.Show("Delete is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Delete Clinic Time.");

                    CTDBinding();
                }
            }
        }

        private void cboDoctor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboDoctor.Text.Length > 0)
                CTDBinding();
        }

        private void grdViewClinicTime_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            getCurDataRow();
        }

        private void getCurDataRow()
        {
            if (grdViewClinicTime.RowCount > 0)
            {
                drClinicTime = grdViewClinicTime.GetDataRow(grdViewClinicTime.FocusedRowHandle);
            }
        }

        private void grdViewClinicTime_RowClick(object sender, RowClickEventArgs e)
        {
            getCurDataRow();
        }

        private void grdViewClinicTime_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


            //for (int i = 0; i < grdViewClinicTime.RowCount; i++)
            //{
            //    if (grdViewClinicTime.GetRowHandle(i) != e.RowHandle)
            //    {
            //        DateTime currentTime = Convert.ToDateTime(e.Value);
            //        DateTime fromTime = Convert.ToDateTime(grdViewClinicTime.GetDataRow(i)["fromTime"]);
            //        DateTime toTime = Convert.ToDateTime(grdViewClinicTime.GetDataRow(i)["toTime"]);
            //        if (currentTime.Ticks >= fromTime.Ticks && currentTime.Ticks <= toTime.Ticks)
            //        {
            //            MessageBox.Show("Sorry, The Time you choose is already defined !!!", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //}

        }

        private void grdViewClinicTime_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {

                DateTime fromTime = Convert.ToDateTime(grdViewClinicTime.GetRowCellValue(e.RowHandle, "fromTime"));
                DateTime toTime = Convert.ToDateTime(grdViewClinicTime.GetRowCellValue(e.RowHandle, "toTime"));
                if (fromTime.Ticks > toTime.Ticks)
                {
                    MessageBox.Show("Sorry, FromTime cannot be greater than ToTime !!!", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                    return;
                }
                for (int i = 0; i < grdViewClinicTime.RowCount; i++)
                {
                    
                    if (grdViewClinicTime.GetDataRow(i)!=null)
                    {
                        DateTime otherfromTime = Convert.ToDateTime(grdViewClinicTime.GetDataRow(i)["fromTime"]);
                        DateTime othertoTime = Convert.ToDateTime(grdViewClinicTime.GetDataRow(i)["toTime"]);
                        bool fromresult=(fromTime.Ticks >= otherfromTime.Ticks && fromTime.Ticks <=othertoTime.Ticks);
                        bool toresult=(toTime.Ticks>=otherfromTime.Ticks && toTime.Ticks <=othertoTime.Ticks);
                        if (fromresult ||  toresult)
                        {
                            MessageBox.Show("Sorry, The Time you choose is already defined !!!", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Valid = false;
                            return;
                        }
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Valid = false;
            }


           

        }


    }
}

