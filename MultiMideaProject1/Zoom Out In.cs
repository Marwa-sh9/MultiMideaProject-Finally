using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMideaProject1
{
    public partial class Zoom_Out_In : Form
    {
        public Zoom_Out_In()
        {
            InitializeComponent();
        }
        private Image img;

        private void Zoom_Out_In_Load(object sender, EventArgs e)
        {
            // set Slider Attributes
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 30;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

            // reduce flickering
            this.DoubleBuffered = true;

        }
        public Image PictureBoxZoom(Image img, Size size)
        {
            //img = Image.FromFile(openFileDialog1.FileName);
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics grap = Graphics.FromImage(bm);
            //grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bm;
        }
        string imgPath = @"C:\Users\Marwa\Desktop\SRSlogin.jpg";
        private void AddPic_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            ////DialogResult res = MessageBox.Show("Message", "Try", MessageBoxButtons.YesNo);
            ////if (res == DialogResult.Yes)
            ////{
            //string imagepath = openFileDialog1.FileName;
            //pictureBox1.ImageLocation = imagepath;
            //// }


            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                img = Image.FromFile(ofd.FileName);
            // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = img;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = PictureBoxZoom(img, new Size(trackBar1.Value, trackBar1.Value));
            }

            ////no  Bitmap orgImage = new Bitmap(img);

            //Size size = new Size(img.Width, img.Height);

            //Size newSize = new Size();
            //newSize.Width = img.Width + (img.Width * trackBar1.Value / 100);
            //newSize.Height = img.Height + (img.Height * trackBar1.Value / 100);


            //Bitmap bitM = new Bitmap(img, newSize);

            //pictureBox1.Image = bitM;
        }


        private void back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
