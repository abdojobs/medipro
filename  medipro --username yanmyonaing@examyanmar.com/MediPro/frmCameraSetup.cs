using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Touchless.Vision.Camera;
using System.Configuration;

namespace MediPro
{
    public partial class frmCameraSetup : Form
    {
        public frmCameraSetup()
        {
            InitializeComponent();
        }

        private void frmCameraSetup_Load(object sender, EventArgs e)
        {
            try
            {
                // Refresh the list of available cameras
                cboCameras.Items.Clear();
                foreach (Camera cam in CameraService.AvailableCameras)
                    cboCameras.Items.Add(cam);

                if (cboCameras.Items.Count > 0)
                    cboCameras.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (cboCameras.Text.Length > 0)
            {
                Camera camName = (Camera)cboCameras.SelectedItem;

                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["defaultcam"].Value = camName.Name;
                config.Save(ConfigurationSaveMode.Modified);

                MessageBox.Show("Thanks for your configuration.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select your camera.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
