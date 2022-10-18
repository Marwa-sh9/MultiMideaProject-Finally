using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MultiMideaProject1
{
    class Edit_Photo
    {

        public static Image Edit_Red(Image img)
        {
            Bitmap normal_img = new Bitmap(img);
            Bitmap red_img = new Bitmap(img);

            int width = img.Width;
            int height = img.Height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color Pixel = normal_img.GetPixel(i, j);

                    red_img.SetPixel(i, j, Color.FromArgb(Pixel.A, Pixel.R, 0, 0));
                }
            }

            return red_img;
        }
        public static Image Edit_Green(Image img)
        {
            Bitmap normal_img = new Bitmap(img);
            Bitmap Green_img = new Bitmap(img);

            int width = img.Width;
            int height = img.Height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color Pixel = normal_img.GetPixel(i, j);

                    Green_img.SetPixel(i, j, Color.FromArgb(Pixel.A, 0, Pixel.G, 0));
                }
            }

            return Green_img;
        }
        public static Image Edit_Blue(Image img)
        {
            Bitmap normal_img = new Bitmap(img);
            Bitmap blue_img = new Bitmap(img);

            int width = img.Width;
            int height = img.Height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color Pixel = normal_img.GetPixel(i, j);

                    blue_img.SetPixel(i, j, Color.FromArgb(Pixel.A, 0, 0, Pixel.B));
                }
            }

            return blue_img;
        }
        public static Image Edit_White(Image img)
        {
            Bitmap normal_img = new Bitmap(img);
            Bitmap White_img = new Bitmap(img);

            int width = img.Width;
            int height = img.Height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color Pixel = normal_img.GetPixel(i, j);


                    int red = (Pixel.R + 255) / 2;
                    int green = (Pixel.G + 255) / 2;
                    int blue = (Pixel.B + 255) / 2;


                    White_img.SetPixel(i, j, Color.FromArgb(Pixel.A, red, green, blue));
                }
            }

            return White_img;
        }
        public static Image Edit_Black(Image img)
        {
            Bitmap normal_img = new Bitmap(img);
            Bitmap black_img = new Bitmap(img);

            int width = img.Width;
            int height = img.Height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color Pixel = normal_img.GetPixel(i, j);


                    int red = Pixel.R / 2;
                    int green = Pixel.G / 2;
                    int blue = Pixel.B / 2;


                    black_img.SetPixel(i, j, Color.FromArgb(Pixel.A, red, green, blue));
                }
            }

            return black_img;
        }
        public static Image Edit_Gray(Image img)
        {
            Bitmap normal_img = new Bitmap(img);
            Bitmap gray_img = new Bitmap(img);

            int width = img.Width;
            int height = img.Height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color Pixel = normal_img.GetPixel(i, j);

                    int red = Pixel.R;
                    int green = Pixel.G;
                    int blue = Pixel.B;

                    int Mix = red + green + blue;
                    int gray = Mix / 3;


                    gray_img.SetPixel(i, j, Color.FromArgb(Pixel.A, gray, gray, gray));
                }
            }

            return gray_img;
        }

        public static Image Edit_Magenta(Image img)
        {
            Bitmap normal_img = new Bitmap(img);
            Bitmap Magenta_img = new Bitmap(img);

            int width = img.Width;
            int height = img.Height;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color Pixel = normal_img.GetPixel(i, j);
                    int Magenta = (Pixel.R + Pixel.B) / 2;
                    Magenta_img.SetPixel(i, j, Color.FromArgb(Pixel.A, Magenta, 0, Magenta));

                }
            }
            return Magenta_img;

        }


        public static Image Edit_Reverse(Image img)
        {
            Bitmap normal_img = new Bitmap(img);
            Bitmap Edit_Rot = new Bitmap(img.Width, img.Height);

            int width = img.Width - 1;

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    Color Pixel = normal_img.GetPixel(j, i);

                    Edit_Rot.SetPixel(width, i, Pixel);
                    width--;
                }
                width = img.Width - 1;
            }
            return Edit_Rot;
        }
        public static Image Copy(Image img)
        {
            Bitmap normal_img = new Bitmap(img);
            Bitmap Edit_Copy = new Bitmap(img);

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    Color Pixel = normal_img.GetPixel(j, i);

                    Edit_Copy.SetPixel(j, i, Pixel);
                }
            }
            return Edit_Copy;
        }
        public static Image Cut(ref Image img)
        {
            Bitmap normal_img = new Bitmap(img);
            Bitmap Edit_Copy = new Bitmap(img);

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    Color Pixel = normal_img.GetPixel(j, i);

                    Edit_Copy.SetPixel(j, i, Pixel);
                }
            }
            img = null;
            return Edit_Copy;
        }
        public static Image Edit_Combine(Image img1, Image img2, byte Alpha)
        {
            Bitmap normal_img1 = new Bitmap(img1);
            Bitmap normal_img2 = new Bitmap(img2);

            Bitmap Edit_img1 = new Bitmap(img1);
            Bitmap Edit_img2 = new Bitmap(img2);

            Bitmap resute = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color Pixel1 = normal_img1.GetPixel(i, j);

                    Edit_img1.SetPixel(i, j, Color.FromArgb(Alpha, Pixel1.R, Pixel1.G, Pixel1.B));
                }
            }

            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    Color Pixel2 = normal_img2.GetPixel(i, j);

                    Edit_img2.SetPixel(i, j, Color.FromArgb(Alpha, Pixel2.R, Pixel2.G, Pixel2.B));
                }
            }


            Graphics g = Graphics.FromImage(resute);
            g.DrawImageUnscaled(Edit_img1, 0, 0);
            g.Flush();
            g.DrawImageUnscaled(Edit_img2, 0, 0);
            g.Flush();

            return resute;
        }
    }
}
