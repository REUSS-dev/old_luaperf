public class java {

    static class Pixel {
        int red;
        int green;
        int blue;
        int alpha;

        Pixel(int red, int green, int blue, int alpha) {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
    }

    static Pixel[] imageRampGreen(int n) {
        Pixel[] img = new Pixel[n];
        double f = 255.0 / (n - 1);
        for (int i = 0; i < n; i++) {
            img[i] = new Pixel(0, (int)(i * f), 0, 255);
        }
        return img;
    }

    static void imageToGray(Pixel[] img) {
        for (int i = 0; i < img.length; i++) {
            int y = (int)(0.3 * img[i].red + 0.59 * img[i].green + 0.11 * img[i].blue);
            img[i].red = y;
            img[i].green = y;
            img[i].blue = y;
        }
    }

    public static void main(String[] args) {
        int n = 400 * 400;
        Pixel[] img = imageRampGreen(n);
        for (int i = 0; i < 1000; i++) {
            imageToGray(img);
        }
    }
}
