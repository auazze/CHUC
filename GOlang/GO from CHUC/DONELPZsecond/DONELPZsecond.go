package main

import (
	"fmt"
	"math"
)

// S=L2/(4*pi)
func main() {
	fmt.Printf("Введите длину сраной окружности\n")
	var dlina float64
	fmt.Scanln(&dlina)
	ploschad := math.Pow(dlina, 2) / (4 * math.Pi)
	fmt.Printf("Площадь круга: %.2f", ploschad)
}
