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
    public partial class frmMedicines : Form
    {
        clsSQL SqlDb = new clsSQL();

        public DataRow drMedicine;

        public int curIndex;
        
        public frmMedicines()
        {
            InitializeComponent();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            curIndex = grdViewMedicine.RowCount;

            frmMedicineDetail fMedicineDetail = new frmMedicineDetail();
            frmMedicineDetail.intMedPK = 0;
            fMedicineDetail.ShowDialog();

            BindingMedicine();

            if (grdViewMedicine.RowCount > 0)
            {
                drMedicine = grdViewMedicine.GetDataRow(grdViewMedicine.FocusedRowHandle);
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMedicines_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingMedicine();
        }

        private void BindingMedicine()
        {
            DataSet dsPatients = SqlDb.GetDataSet("SELECT m.medPK, m.medName, "+
                                "mtype.medTypeName,cname.chemName, bsys.systemName, "+
                                "manu.manuName, manu.manuCountry, m.isActive "+
                                "FROM tblMedicine m  "+
                                "JOIN tblMedType mtype ON m.medTypePK = mtype.medTypePK "+
                                "JOIN tblChemName cname ON m.chemNamePK = cname.chemNamePK "+
                                "JOIN tblBodySystem bsys ON m.systemPK = bsys.systemPK "+
                                "JOIN tblManufacturer manu ON m.manuPK = manu.manuPK " +
                                "WHERE m.isDelete = 0");

            grdMedicine.DataSource = dsPatients.Tables[0];

            grdViewMedicine.FocusedRowHandle = curIndex;
        }

        private void grdViewMedicine_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grdViewMedicine.RowCount > 0)
            {
                drMedicine = grdViewMedicine.GetDataRow(grdViewMedicine.FocusedRowHandle);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (grdViewMedicine.RowCount>0)
            {
                curIndex = grdViewMedicine.GetDataSourceRowIndex(grdViewMedicine.FocusedRowHandle);

                frmMedicineDetail fMedicineDetail = new frmMedicineDetail();
                frmMedicineDetail.intMedPK = int.Parse(drMedicine.ItemArray[0].ToString());

                fMedicineDetail.ShowDialog();

                BindingMedicine();

                if (grdViewMedicine.RowCount > 0)
                {
                    drMedicine = grdViewMedicine.GetDataRow(grdViewMedicine.FocusedRowHandle);
                }    
            }
            
        }


        private void grdViewPatient_DoubleClick(object sender, EventArgs e)
        {
                curIndex = grdViewMedicine.GetDataSourceRowIndex(grdViewMedicine.FocusedRowHandle);

                frmMedicineDetail fMedicineDetail = new frmMedicineDetail();
                frmMedicineDetail.intMedPK = int.Parse(drMedicine.ItemArray[0].ToString());

                fMedicineDetail.ShowDialog();

                BindingMedicine();

                if (grdViewMedicine.RowCount > 0)
                {
                    drMedicine = grdViewMedicine.GetDataRow(grdViewMedicine.FocusedRowHandle);
                }
        }

        private void grdViewMedicine_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdViewMedicine.RowCount > 0)
            {
                drMedicine = grdViewMedicine.GetDataRow(grdViewMedicine.FocusedRowHandle);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdViewMedicine.RowCount > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this medicine?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (dr == DialogResult.Yes)
                {
                    SqlDb.ExecuteQuery("DELETE FROM tblPackList WHERE medPK=" + drMedicine.ItemArray[0].ToString());
                    SqlDb.ExecuteQuery("UPDATE tblMedicine SET isDelete=1 WHERE medPK=" + drMedicine.ItemArray[0].ToString());
                    
                    BindingMedicine();
                    if (grdViewMedicine.RowCount > 0)
                    {
                        drMedicine = grdViewMedicine.GetDataRow(grdViewMedicine.FocusedRowHandle);
                    }
                }
            }

        }
    }
}
