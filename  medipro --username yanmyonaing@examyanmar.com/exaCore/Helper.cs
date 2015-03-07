using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exaCore
{
    //Design by Pongsakorn Poosankam
    public class Helper
    {

        public static void SaveImageCapture(System.Drawing.Image image)
        {

            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Image";// Default file name
            s.DefaultExt = ".Jpg";// Default file extension
            s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

            // Show save file dialog box
            // Process save file dialog box results
            if (s.ShowDialog() == DialogResult.OK)
            {
                // Save Image
                string filename = s.FileName;
                FileStream fstream = new FileStream(filename, FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();

            }

        }

        public static string CalAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            string Age = Convert.ToString((a - b) / 10000);

            Age = Age + " Year";

            return Age;
        }

        public static void BMIResult(DevExpress.XtraEditors.TextEdit restxtBMI, System.Windows.Forms.Label reslblBMI, double weight, double height)
        {
            if (height.ToString().Length > 0 && weight.ToString().Length > 0)
            {
                double BMI;

                BMI = (weight * 703) / (height * height);
                
                if (BMI <= 18.5)
                {
                    restxtBMI.Text = string.Format("{0:0.00}", BMI);
                    restxtBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

                    reslblBMI.Text = "Underweight";
                    reslblBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                }
                else if (BMI > 18.5 && BMI <= 24.99)
                {
                    restxtBMI.Text = string.Format("{0:0.00}", BMI);
                    restxtBMI.ForeColor = System.Drawing.Color.Green;

                    reslblBMI.Text = "Normal Weight";
                    reslblBMI.ForeColor = System.Drawing.Color.Green;
                }
                else if (BMI > 24.99 && BMI <= 29.99)
                {
                    restxtBMI.Text = string.Format("{0:0.00}", BMI);
                    restxtBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));

                    reslblBMI.Text = "Over weight";
                    reslblBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
                }
                else if (BMI > 29.99 && BMI <= 34.99)
                {
                    restxtBMI.Text = string.Format("{0:0.00}", BMI);
                    restxtBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));

                    reslblBMI.Text = "Obesity (Class 1)";
                    reslblBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
                }
                else if (BMI > 34.99 && BMI <= 39.99)
                {
                    restxtBMI.Text = string.Format("{0:0.00}", BMI);
                    restxtBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));

                    reslblBMI.Text = "Obesity (Class 2)";
                    reslblBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
                }
                else if (BMI > 34.99)
                {
                    restxtBMI.Text = string.Format("{0:0.00}", BMI);
                    restxtBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));

                    reslblBMI.Text = "Obesity";
                    reslblBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
                }
            }
        }
    }
}
