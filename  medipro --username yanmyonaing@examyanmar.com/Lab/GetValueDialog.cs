using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab
{
    public partial class GetValueDialog : Form
    {
        public object data = null;
        public GetValueDialog(ref object value)
        {
            InitializeComponent();
            value = data;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }


        private void cmdOK_Click(object sender, EventArgs e)
        {
            data = txtValue.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
