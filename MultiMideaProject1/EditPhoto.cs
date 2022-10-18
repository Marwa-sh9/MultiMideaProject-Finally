using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Moalaa;
using Moalaa.Enums;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace MultiMideaProject1
{
    public partial class EditPhoto : Form
    {

        public EditPhoto()
        {
            InitializeComponent();
        }

        private Image img;
        int ImageID = 0;
        String strFilePath = "";
        Byte[] ImageByteArray;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Multimedia;Integrated Security=True");
        DataTable dtblImages;

        void Clear()
        {
            img = null;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            mirror.Enabled = false;
            ComboColor.Enabled = false;
            Rev.Enabled = false;
            ResizeB.Enabled = false;
            ResizeB.Enabled = false;
            resizeH.Enabled = false;
            resizeW.Enabled = false;
            Left_Rotate1.Enabled = false;
            Copy1.Enabled = false;
            combine.Enabled = false;
            
            Right_Rotate1.Enabled = false;
            Save_To_Device.Enabled = false;
            trackBar1.Enabled = false;
            trackBar2.Enabled = false;
            trackBar3.Enabled = false;

        }
        void RefreshImageGrid()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("ImageViewAll", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            dtblImages = new DataTable();
            sqlda.Fill(dtblImages);
            dgvImages.DataSource = dtblImages;
            dgvImages.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImages.Columns[2].Visible = false;
        }
        void Enable()
        {
            mirror.Enabled = true;
            ComboColor.Enabled = true;
            Rev.Enabled = true;
            ResizeB.Enabled = true;
            resizeH.Enabled = true;
            resizeW.Enabled = true;
            Left_Rotate1.Enabled = true;
            Right_Rotate1.Enabled = true;
            Save_To_Device.Enabled = true;
            combine.Enabled = true;
            trackBar1.Enabled = true;
            trackBar2.Enabled = true;
            Copy1.Enabled = true;
            pictureBox1.Image = img;
        }

        //zoom
        private void EditPhoto_Load(object sender, EventArgs e)
        {
            // set Slider Attributes
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 7;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

            // reduce flickering
            this.DoubleBuffered = true;
        }
        public Image PictureBoxZoom(Image img, Size size)
        {
            //img = Image.FromFile(openFileDialog1.FileName);
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width)
                , Convert.ToInt32(img.Height * size.Height));
            Graphics grap = Graphics.FromImage(bm);
            //grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bm;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = PictureBoxZoom(img, new Size(trackBar1.Value, trackBar1.Value));
            }
        }
        //end zoom

        private void ResizeB_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(resizeW.Value);
            int height = Convert.ToInt32(resizeH.Value);

            Size size = new Size(width, height);

            Bitmap orgImage = new Bitmap(pictureBox1.Image);
            Bitmap bitM = new Bitmap(orgImage, size);

            pictureBox1.Image = bitM;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Images(.jpg,.png,.gif,.bmp)|*.png;*.jpg;*.gif;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                    img = Image.FromFile(ofd.FileName);
                // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = img;
                resizeW.Value = pictureBox1.Image.Width;
                resizeH.Value = pictureBox1.Image.Height;
                strFilePath = ofd.FileName;
                pictureBox1.Image = new Bitmap(strFilePath);
                if (txtName.Text.Trim().Length == 0)//Auto-Fill Name if is empty
                    txtName.Text = System.IO.Path.GetFileName(strFilePath);
                Enable();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose Photo!");
            }
        }
        //Crop
        Rectangle rec;
        Point x;
        Point y;
        bool s = false;
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
                    pictureBox1.Image = cropimg;
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

        }
        //end crop



        //color
        private void ComboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap normal_img = new Bitmap(img);
            try
            {
                if (ComboColor.SelectedIndex == 0)
                    pictureBox1.Image = Edit_Photo.Edit_Red(img);
                else if (ComboColor.SelectedIndex == 1)
                    pictureBox1.Image = Edit_Photo.Edit_Green(img);
                else if (ComboColor.SelectedIndex == 2)
                    pictureBox1.Image = Edit_Photo.Edit_Blue(img);
                else if (ComboColor.SelectedIndex == 3)
                    pictureBox1.Image = Edit_Photo.Edit_Gray(img);
                else if (ComboColor.SelectedIndex == 4)
                    pictureBox1.Image = Edit_Photo.Edit_Black(img);
                else if (ComboColor.SelectedIndex == 5)
                    pictureBox1.Image = Edit_Photo.Edit_White(img);
                else if (ComboColor.SelectedIndex == 6)
                    pictureBox1.Image = Edit_Photo.Edit_Magenta(img);
                else if (ComboColor.SelectedIndex == 7)
                    pictureBox1.GetRGBImage(SetColor.Cyan);
                else if (ComboColor.SelectedIndex == 8)
                    pictureBox1.GetRGBImage(SetColor.Yellow);
                else if (ComboColor.SelectedIndex == 9)
                    pictureBox1.GetRGBImage(SetColor.Negative);
                else if (ComboColor.SelectedIndex == 10)
                    pictureBox1.Image = img;

            }
            catch (Exception)
            {
                MessageBox.Show("Add Photo First !!!!");
            }
        }
        //To Write and move:
        bool IsMouseDown = false;
        Point StartPoint;
        private void label1_MouseUp_1(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }
        private void label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                IsMouseDown = true;
                label1.BringToFront();
                StartPoint = e.Location;
            }
        }
        private void label1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                int left = e.X + label1.Left - StartPoint.X;
                int right = e.X + label1.Right - StartPoint.X;
                int top = e.Y + label1.Top - StartPoint.Y;
                int bottom = e.Y + label1.Bottom - StartPoint.Y;
                if (left > pictureBox1.Left && top > pictureBox1.Top && pictureBox1.Bottom >= bottom
                    && pictureBox1.Right >= right)
                {
                    label1.Left = left;
                    label1.Top = top;
                }
            }
        }
        private void Write_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 20);
            label1.ForeColor = Color.Red;
            label1.Text = textBox1.Text;
        }

        //Mirror
        private void mirror_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            int width = pictureBox1.Image.Width;
            int height = pictureBox1.Image.Height;
            pictureBox1.Image = pictureBox1.Image;
            Bitmap bitmap = new Bitmap(width * 2, height);
            for (int y = 0; y < height; y++)
            {
                for (int lx = 0, rx = width * 2 - 1; lx < width; lx++, rx--)
                {
                    Color p = b.GetPixel(lx, y);
                    bitmap.SetPixel(lx, y, p);
                    bitmap.SetPixel(rx, y, p);


                }
            }
            pictureBox1.Image = bitmap;

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Rev_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Edit_Photo.Edit_Reverse(pictureBox1.Image);

            Image image = pictureBox1.Image;
            image.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox1.Image = image;
        }

        //Transparency:
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = new Bitmap(img1.Width, img1.Height);

            byte[,] red = new byte[img1.Width, img1.Height];
            byte[,] green = new byte[img1.Width, img1.Height];
            byte[,] blue = new byte[img1.Width, img1.Height];
            byte[,] alpha = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color c = img1.GetPixel(i, j);
                    red[i, j] = c.R;
                    green[i, j] = c.G;
                    blue[i, j] = c.B;
                    alpha[i, j] = c.A;
                }
            }
            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    Color c = Color.FromArgb(trackBar2.Value,
                        red[i, j],
                        green[i, j],
                        blue[i, j]);
                    img2.SetPixel(i, j, c);
                }
            }
            pictureBox1.Image = img2;
        }

        private void Right_Rotate1_Click(object sender, EventArgs e)
        {
            pictureBox1.RightRotate();
        }
        private void Left_Rotate1_Click(object sender, EventArgs e)
        {
            pictureBox1.LeftRotate();
        }
        private void Save_To_Device_Click(object sender, EventArgs e)
        {
            if (radiopng.Checked)
            {
                pictureBox1.SaveImage(SaveFormat.Png);
                MessageBox.Show("image Saved", "hey user!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioBmp.Checked)
            {
                pictureBox1.SaveImage(SaveFormat.Bmp);
                MessageBox.Show("image Saved", "hey user!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radiogif.Checked)
            {
                pictureBox1.SaveImage(SaveFormat.Gif);
                MessageBox.Show("Saved", "message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                pictureBox1.SaveImage(SaveFormat.Jpeg);
            MessageBox.Show("Saved", "message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveText_Click(object sender, EventArgs e)
        {

        }


        private void Copy1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Edit_Photo.Copy(pictureBox1.Image);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvImages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvImages.CurrentRow.Cells[1].Value.ToString();
            byte[] ImageArray = (byte[])dgvImages.CurrentRow.Cells[2].Value;
            if (ImageArray.Length == 0)
                pictureBox1.Image = null;
            else
            {
                ImageByteArray = ImageArray;
                pictureBox1.Image = Image.FromStream(new MemoryStream(ImageArray));
            }
            ImageID = Convert.ToInt32(dgvImages.CurrentRow.Cells[0].Value);
            btnSaveToDB.Text = "Update";
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "")
            {

                if (strFilePath == "")
                {
                    if (ImageByteArray.Length != 0)
                        ImageByteArray = new byte[] { };
                }
                else
                {
                    Image temp = new Bitmap(strFilePath);
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ImageByteArray = strm.ToArray();
                }
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("ImageAddOrEdit", sqlcon) { CommandType = CommandType.StoredProcedure };
                sqlCmd.Parameters.Add("@ImageID", ImageID);
                sqlCmd.Parameters.Add("@Name", txtName.Text.Trim());
                sqlCmd.Parameters.Add("@Image", ImageByteArray);
                sqlCmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Saved successfuly!");
                dgvImages.Visible = true;
                Clear();
                RefreshImageGrid();
                txtName.Text = null;
            }
            else
            {
                MessageBox.Show("Please Enter Image Name!");
            }
        }

        private void ShowAllImages_Click(object sender, EventArgs e)
        {
            dgvImages.Visible = true;
            RefreshImageGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtblImages);
            DV.RowFilter = string.Format("Name LIKE '%{0}%'", txtSearch.Text);
            dgvImages.DataSource = DV;
        }

        //to combine
        private void combine_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = Edit_Photo.Edit_Combine(pictureBox1.Image, pictureBox2.Image, (byte)trackBar3.Value);

        }


        private void image2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png,.gif,.bmp)|*.png;*.jpg;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
                img = Image.FromFile(ofd.FileName);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = img;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = new Bitmap(img1.Width, img1.Height);

            byte[,] red = new byte[img1.Width, img1.Height];
            byte[,] green = new byte[img1.Width, img1.Height];
            byte[,] blue = new byte[img1.Width, img1.Height];
            byte[,] alpha = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color c = img1.GetPixel(i, j);
                    red[i, j] = c.R;
                    green[i, j] = c.G;
                    blue[i, j] = c.B;
                    alpha[i, j] = c.A;
                }
            }
            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    Color c = Color.FromArgb(trackBar3.Value,
                        red[i, j],
                        green[i, j],
                        blue[i, j]);
                    img2.SetPixel(i, j, c);
                }
            }
            pictureBox1.Image = img2;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
