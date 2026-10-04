using System;

class Program
{
    struct Pixel
    {
        public int Red;
        public int Green;
        public int Blue;
        public int Alpha;

        public Pixel(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
    }

    static Pixel[] ImageRampGreen(int n)
    {
        Pixel[] img = new Pixel[n];
        double f = 255.0 / (n - 1);
        for (int i = 0; i < n; i++)
        {
            img[i] = new Pixel(0, (int)(i * f), 0, 255);
        }
        return img;
    }

    static void ImageToGray(Pixel[] img)
    {
        for (int i = 0; i < img.Length; i++)
        {
            int y = (int)(0.3 * img[i].Red + 0.59 * img[i].Green + 0.11 * img[i].Blue);
            img[i].Red = y;
            img[i].Green = y;
            img[i].Blue = y;
        }
    }

    static void Main()
    {
        int n = 400 * 400;
        Pixel[] img = ImageRampGreen(n);
        for (int i = 0; i < 1000; i++)
        {
            ImageToGray(img);
        }
    }
}
