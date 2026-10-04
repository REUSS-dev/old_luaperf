package main

type Pixel struct {
	Red   int
	Green int
	Blue  int
	Alpha int
}

func imageRampGreen(n int) []Pixel {
	img := make([]Pixel, n)
	f := 255.0 / float64(n-1)
	for i := 0; i < n; i++ {
		img[i] = Pixel{
			Red:   0,
			Green: int(float64(i) * f),
			Blue:  0,
			Alpha: 255,
		}
	}
	return img
}

func imageToGray(img []Pixel) {
	for i := range img {
		y := int(0.3*float64(img[i].Red) + 0.59*float64(img[i].Green) + 0.11*float64(img[i].Blue))
		img[i].Red = y
		img[i].Green = y
		img[i].Blue = y
	}
}

func main() {
	n := 400 * 400
	img := imageRampGreen(n)
	for i := 0; i < 1000; i++ {
		imageToGray(img)
	}
}
