#[derive(Clone, Copy)]
struct Pixel {
    red: i32,
    green: i32,
    blue: i32,
    alpha: i32,
}

fn image_ramp_green(n: usize) -> Vec<Pixel> {
    let mut img = Vec::with_capacity(n);
    let f = 255.0 / (n - 1) as f64;
    for i in 0..n {
        img.push(Pixel {
            red: 0,
            green: (i as f64 * f) as i32,
            blue: 0,
            alpha: 255,
        });
    }
    img
}

fn image_to_gray(img: &mut [Pixel]) {
    for p in img.iter_mut() {
        let y = (0.3 * p.red as f64 + 0.59 * p.green as f64 + 0.11 * p.blue as f64) as i32;
        p.red = y;
        p.green = y;
        p.blue = y;
    }
}

fn main() {
    let n = 400 * 400;
    let mut img = image_ramp_green(n);
    for _ in 0..1000 {
        image_to_gray(&mut img);
    }
}
