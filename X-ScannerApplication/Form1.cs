using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using OpenCvSharp;

namespace X_ScannerApplication
{
    public partial class Form1 : Form
    {
        int formMinWidth = 0;
        int formMinHeight = 0;
        string version = "v0.1.1";
        string usingversion = "v0.25.5";
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Width = 1000;
            pictureBox1.Height = Convert.ToInt32( 1000.0 / 1280.0 * 800.0);
            formMinHeight = tableLayoutPanel1.Height + tableLayoutPanel1.Location.Y;

            label_version.Text = "Version: " + version + "using:" + usingversion;

            Form1_SizeChanged(null, null);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mat source = Cv2.ImRead("C:\\Users\\Smore\\Desktop\\1.png", ImreadModes.Grayscale);
            //pictureBoxIpl1.
            //Cv2.ImShow("image", source);
            //Cv2.WaitKey();
            Bitmap bitmap = BitmapConverter.ToBitmap(source);
            //Image image = Image.FromHbitmap(bitmap.GetHbitmap());
            pictureBox1.Image = bitmap;
            


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //if (this.Width <= formMinWidth)
            //{ this.Width = formMinWidth; }
            if (this.Height <= formMinHeight)
            { this.Height = formMinHeight;}

            int x =0, y =0;
            if ((panel_pictureBox.Width - pictureBox1.Width)>0)
            {
                x = (panel_pictureBox.Width - pictureBox1.Width)/2;
            }
            else
            {
                x = 0;
            }
            if ((panel_pictureBox.Height - pictureBox1.Height) > 0)
            {
                y = (panel_pictureBox.Height - pictureBox1.Height) / 2;
            }
            else
            {
                y = 0;
            }
            pictureBox1.Location = new System.Drawing.Point(x, y);

            int labelversionX = panel_version.Size.Width - label_version.Size.Width - 2;
            int labelversionY = (panel_version.Size.Height - label_version.Size.Height)/2;
            label_version.Location = new System.Drawing.Point(labelversionX, labelversionY);
        }

        
   
    }
}
