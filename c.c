#include <stdlib.h>

typedef struct {
    int red;
    int green;
    int blue;
    int alpha;
} Pixel;

Pixel* image_ramp_green(int n) {
    Pixel* img = (Pixel*)malloc(n * sizeof(Pixel));
    double f = 255.0 / (n - 1);
    for (int i = 0; i < n; i++) {
        img[i].red = 0;
        img[i].green = (int)(i * f);
        img[i].blue = 0;
        img[i].alpha = 255;
    }
    return img;
}

void image_to_gray(Pixel* img, int n) {
    for (int i = 0; i < n; i++) {
        int y = (int)(0.3 * img[i].red + 0.59 * img[i].green + 0.11 * img[i].blue);
        img[i].red = y;
        img[i].green = y;
        img[i].blue = y;
    }
}

int main(void) {
    int N = 400 * 400;
    Pixel* img = image_ramp_green(N);
    for (int i = 0; i < 1000; i++) {
        image_to_gray(img, N);
    }
    free(img);
    return 0;
}
