import array


def image_ramp_green(n):
    img = array.array('i', bytes(4 * n * 4))
    f = 255.0 / (n - 1)
    for i in range(n):
        img[i * 4 + 0] = 0              # red
        img[i * 4 + 1] = int(i * f)     # green
        img[i * 4 + 2] = 0              # blue
        img[i * 4 + 3] = 255            # alpha
    return img


def image_to_gray(img, n):
    for i in range(n):
        base = i * 4
        y = int(0.3 * img[base] + 0.59 * img[base + 1] + 0.11 * img[base + 2])
        img[base] = y
        img[base + 1] = y
        img[base + 2] = y


def main():
    n = 400 * 400
    img = image_ramp_green(n)
    for _ in range(1000):
        image_to_gray(img, n)


if __name__ == "__main__":
    main()
