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
        //----------Define Fileds----------------
        private bool CloseFactor = false;
        private Image refimg;
        private Image caseimg;
        private Bitmap resultImage;
        private Bitmap gsImage;
        private Bitmap bnImage;
        private Bitmap MasImage;

        public ManualMonitor()
        {
            InitializeComponent();
            disp1.SizeMode = PictureBoxSizeMode.StretchImage;
            disp2.SizeMode = PictureBoxSizeMode.StretchImage;
            disp3.SizeMode = PictureBoxSizeMode.StretchImage;
            disp4.SizeMode = PictureBoxSizeMode.StretchImage;
            disp5.SizeMode = PictureBoxSizeMode.StretchImage;
            disp6.SizeMode = PictureBoxSizeMode.StretchImage;
            Start_show();
        }

        //----------Intialized the demo show------
        private void Start_show()
        {
            // Reading reference images
            refimg = Image.FromFile("C:\\Users\\MohammadAlCheikhSale\\Desktop\\Final Hackathon\\RefImg.jpg");
            caseimg = Image.FromFile("C:\\Users\\MohammadAlCheikhSale\\Desktop\\Final Hackathon\\CaseImg.jpg");
            disp1.Image = refimg;
            
            // create Grayscale filter
            Grayscale gsfilter = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter
            gsImage = gsfilter.Apply((Bitmap)caseimg);
            
            // create Threashold filter
            Threshold bnFilter = new Threshold(100);
            // apply the filter
            bnImage = bnFilter.Apply((Bitmap)gsImage);
           
            // create Mask filter
            MaskedFilter mask = new MaskedFilter(new Sepia(), bnImage);
            // apply the filter
            MasImage = mask.Apply((Bitmap)caseimg);
            
            // create Difference filter
            Difference filter = new Difference((Bitmap)refimg);
            // apply the filter
            resultImage = filter.Apply((Bitmap)caseimg);


        }

        private void disp1_MouseEnter(object sender, EventArgs e)
        {
            disp1.Image = refimg;
        }

        private void disp2_MouseEnter(object sender, EventArgs e)
        {
            disp2.Image = caseimg;
        }

        private void disp3_MouseEnter(object sender, EventArgs e)
        {
            disp3.Image = gsImage;
        }

        private void disp4_MouseEnter(object sender, EventArgs e)
        {
            disp4.Image = bnImage;
        }

        private void disp5_MouseEnter(object sender, EventArgs e)
        {
            disp5.Image = resultImage;
        }

        private void disp6_MouseEnter(object sender, EventArgs e)
        {
            disp6.Image = MasImage;
        }

        //----------Override Normal Closing Function-------
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (CloseFactor == true) return;
            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    GlobalVariables.RunPage.Dispose();
                    GlobalVariables.RunPage.Close();
                    break;
            }
        }

    }
}
