using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace MediPro
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer(ReportClass rpt)
        {
            InitializeComponent();
            crptViewer.ReportSource = rpt;
            crptViewer.Show();

        }
    }
}
