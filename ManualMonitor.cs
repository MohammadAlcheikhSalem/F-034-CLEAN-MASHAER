using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarbageDetector
{
    public partial class ManualMonitor : Form
    {
        public ManualMonitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disp1.SizeMode = PictureBoxSizeMode.StretchImage;
            disp2.SizeMode = PictureBoxSizeMode.StretchImage;
            disp3.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Drawing.Image refimg = System.Drawing.Image.FromFile("C:\\Users\\MohammadAlCheikhSale\\Desktop\\Final Hackathon\\RefImg.jpg");
            System.Drawing.Image caseimg = System.Drawing.Image.FromFile("C:\\Users\\MohammadAlCheikhSale\\Desktop\\Final Hackathon\\CaseImg.jpg");
            // create filter
            Difference filter = new Difference((Bitmap)refimg);
            // apply the filter
            Bitmap resultImage = filter.Apply((Bitmap)caseimg);
            disp1.Image = refimg;
            //ResultImage.Image = resultImage;
            disp2.Image = caseimg;
            show_result(resultImage);
            System.Threading.Thread.Sleep(5000);

            Grayscale gsfilter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap gsImage = gsfilter.Apply((Bitmap)caseimg);
            //ResultImage.Image = gsImage;

            System.Threading.Thread.Sleep(5000);

            Threshold bnFilter = new Threshold(100);
            Bitmap bnImage = bnFilter.Apply((Bitmap)gsImage);
            disp3.Image = bnImage;

            System.Threading.Thread.Sleep(5000);

            MaskedFilter mask = new MaskedFilter(new Sepia(), bnImage);
            Bitmap MasImage = mask.Apply((Bitmap)caseimg);
            disp3.Image = MasImage;

            /*HSLFiltering filter = new HSLFiltering(
                new IntRange(330, 30),    // hue range
                new Range(0, 1),    // saturation range
                new Range(0, 1));    // luminance range

            filter.UpdateLuminance = false;
            filter.UpdateHue = false;
            // apply the filter
            filter.ApplyInPlace((Bitmap)proimg);*/

            /*Median filter = new Median();
            // apply the filter
            filter.ApplyInPlace((Bitmap)proimg);*/

            /*/ create grayscale filter (BT709)
            Grayscale filter1 = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter
            Bitmap grayImage = filter1.Apply((Bitmap)proimg);

            // create filter
            BlobsFiltering filter = new BlobsFiltering();
            // configure filter
            filter.CoupledSizeFiltering = true;
            filter.MinWidth = 70;
            filter.MinHeight = 70;
            // apply the filter
            filter.ApplyInPlace(grayImage);

            // create filter
            Difference filter2 = new Difference(overlayImage);
            // apply the filter
            Bitmap resultImage = filter2.Apply(sourceImage);
            procImage.Image = grayImage;*/



            /* BlobCounter bc = new BlobCounter();
             bc.ProcessImage((Bitmap)resultImage);
             Blob[] blobs = bc.GetObjectsInformation();
             */

        }

        private void show_result(Bitmap img)
        {
            disp3.Image = img;
        }
    }
}
