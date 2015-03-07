using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MediPro.Class;

namespace MediPro
{
    public partial class Main : Form
    {
        Class.clsSQL SqlDb = new Class.clsSQL();

        public Main()
        {
            InitializeComponent();

            Timer.Start();

            tsslDate.Text = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year; 
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmStartup StartupForm = new frmStartup();

            StartupForm.MdiParent = this;

            StartupForm.Show();

            this.WindowState = FormWindowState.Maximized;

            tsslCurrentUser.Text = AppVariable.CURRENT_USER_FULLNAME;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure? Do you want to exit from MediPro?", "MediPro Applicaton", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
