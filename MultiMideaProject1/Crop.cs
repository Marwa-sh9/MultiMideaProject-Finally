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
    public partial class Crop : Form
    {
        public Crop()
        {
            InitializeComponent();
        }
        Image img;
        Rectangle rec;
        Point x;
        Point y;
        bool s = false;

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                    img = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = img;

            }
            catch (Exception)
            {
                MessageBox.Show("Choice Photo !!!");
            }
        }
        private Rectangle GetRect()
        {
            rec = new Rectangle();
            rec.X = Math.Min(x.X, y.Y);
            rec.Y = Math.Min(x.Y, y.Y);
            rec.Width = Math.Abs(x.X - y.X);
            rec.Height = Math.Abs(x.Y - y.Y);
            return rec;

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (rec != null)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (s == true)
            {
                y = e.Location;
                s = false;

                if (rec != null)
                {
                    Bitmap bit = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
                    Bitmap cropimg = new Bitmap(rec.Width, rec.Height);
                    Graphics gr = Graphics.FromImage(cropimg);
                    gr.DrawImage(bit, 0, 0, rec, GraphicsUnit.Pixel);
                    pictureBox2.Image = cropimg;

                }

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (s == true)
            {
                y = e.Location;
                Refresh();

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            s = true;
            x = e.Location;
            Refresh();
        }

        private void save_Click(object sender, EventArgs e)
        {


        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Visible = false;

        }

        private void Crop1_Click(object sender, EventArgs e)
        {

        }

        private void Crop_Load(object sender, EventArgs e)
        {

        }
    }
}
