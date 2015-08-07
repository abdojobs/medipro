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

namespace exaCore
{
    public class WebCam
    {
        public System.Windows.Forms.PictureBox ImgControl;
        private CameraFrameSource _frameSource;
        private static Bitmap _latestFrame;

        public void Start()
        {
            if (_frameSource != null)
                return;

            thrashOldCamera();
            startCapturing();
        }

        public void Stop()
        {
            thrashOldCamera();
        }

        public void startCapturing()
        {
            try
            {
                bool camStatus = false;
                string camName = ConfigurationManager.AppSettings["defaultcam"].ToString();

                foreach (Camera cam in CameraService.AvailableCameras)
                {
                    if (cam.Name == camName)
                    {
                        setFrameSource(new CameraFrameSource(cam));
                        camStatus = true;
                    }
                }

                if (camStatus == true)
                {
                    _frameSource.Camera.CaptureWidth = this.ImgControl.Width;
                    _frameSource.Camera.CaptureHeight = this.ImgControl.Height;
                    _frameSource.Camera.Fps = 50;
                    _frameSource.NewFrame += OnImageCaptured;

                    ImgControl.Paint += new PaintEventHandler(drawLatestImage);
                    _frameSource.StartFrameCapture();
                }
                else
                {
                    MessageBox.Show("Please chech your camera connection.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void drawLatestImage(object sender, PaintEventArgs e)
        {
            if (_latestFrame != null)
            {
                // Draw the latest image from the active camera
                e.Graphics.DrawImage(_latestFrame, 0, 0, ImgControl.Width, ImgControl.Height);
                //e.Graphics.DrawImage(_latestFrame, 0, 0, _latestFrame.Width, _latestFrame.Height);
            }
        }

        public void OnImageCaptured(Touchless.Vision.Contracts.IFrameSource frameSource, Touchless.Vision.Contracts.Frame frame, double fps)
        {

            //Image img = frame.Image.Clone(new RectangleF(0, 0, this.ImgControl.Width, this.ImgControl.Height), System.Drawing.Imaging.PixelFormat.Undefined);
            //_latestFrame = img as Bitmap;
            _latestFrame = frame.Image;
            ImgControl.Invalidate();
        }

        public void setFrameSource(CameraFrameSource cameraFrameSource)
        {
            if (_frameSource == cameraFrameSource)
                return;

            _frameSource = cameraFrameSource;
        }

        public void thrashOldCamera()
        {
            // Trash the old camera
            if (_frameSource != null)
            {
                //Graphics g= ImgControl.CreateGraphics();
                //g.DrawImage(_latestFrame, 0, 0, ImgControl.Width, ImgControl.Height);
                ImgControl.Image = new Bitmap(_latestFrame, ImgControl.Width, ImgControl.Height);
                //ImgControl.Image = ImgControl.Image;
                 //ImgControl.Image = (Bitmap)_latestFrame.Clone();
                _frameSource.NewFrame -= OnImageCaptured;
                _frameSource.Camera.Dispose();
                setFrameSource(null);
                ImgControl.Paint -= new PaintEventHandler(drawLatestImage);
            }
        }
    }
}
