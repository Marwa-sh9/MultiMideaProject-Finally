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
    public partial class CopyPast : Form
    {
        public CopyPast()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Visible = false;
        }
        Image img1 = null;
        Image img2 = null;

        private void AddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
                img1 = Image.FromFile(ofd.FileName);
            pictureBox1.Image = img1;
        }

        private void CutPast_Click(object sender, EventArgs e)
        {

            pictureBox2.Image = Edit_Photo.Cut(ref img1);
            pictureBox1.Image = img1;
        }
        private void CutPast_Click_1(object sender, EventArgs e)
        {

            //pictureBox2.Image = Edit_Photo.Cut(ref img1);
            //pictureBox1.Image = img1;
        }
        private void Copy_Click(object sender, EventArgs e)
        {

            pictureBox3.Image = Edit_Photo.Copy(pictureBox1.Image);

        }

        private void pic2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
                img2 = Image.FromFile(ofd.FileName);
            pictureBox3.Image = img2;
        }

        private void Merge1_Click(object sender, EventArgs e)
        {
            //  if (img1 != null && img2 != null)
            {
                pictureBox2.Image = Edit_Photo.Edit_Combine(pictureBox1.Image, pictureBox3.Image, (byte)trackBar1.Value);
            }
        }
    }
}
