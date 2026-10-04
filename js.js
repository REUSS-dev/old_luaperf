class Pixel {
    constructor(red, green, blue, alpha) {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }
}

function imageRampGreen(n) {
    const img = new Array(n);
    const f = 255.0 / (n - 1);
    for (let i = 0; i < n; i++) {
        img[i] = new Pixel(0, Math.floor(i * f), 0, 255);
    }
    return img;
}

function imageToGray(img, n) {
    for (let i = 0; i < n; i++) {
        const p = img[i];
        const y = Math.floor(0.3 * p.red + 0.59 * p.green + 0.11 * p.blue);
        p.red = y;
        p.green = y;
        p.blue = y;
    }
}

const N = 400 * 400;
const img = imageRampGreen(N);
for (let i = 0; i < 1000; i++) {
    imageToGray(img, N);
}
