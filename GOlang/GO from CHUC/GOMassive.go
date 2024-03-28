// Массив, среднее, максимальное и минимальное значения
package main

import (
	"fmt"
	"math/rand"
	"sort"
)

func main() {
	Grades := []int{5, 4, 5, 3, 5, 4, 5, 3, 3, 4, 5, 4}
	sum := 0
	for _, num := range Grades {
		sum += num
	}
	S := sum / len(Grades)
	sort.Ints(Grades)
	fmt.Println("Максимальная оценка:", Grades[len(Grades)-1])
	fmt.Println("Минимальная оценка:", Grades[0])
	fmt.Println("Средняя оценка:", S)

	// Lea
	length := 20
	GradesGPT := make([]int, length)
	for i := range GradesGPT {
		GradesGPT[i] = rand.Intn(3) + 3
	}
	fmt.Println("Длина массива:", len(GradesGPT))
	fmt.Println("Массив оценок:", GradesGPT)

	positive()
}

// Массив с поиском положительных чисел (должны быть и отрицательные), суммой положительных чисел и срез пол. чисел.
func positive() {
	lenghht := 20
	posnums := make([]int, lenghht)
	for j := range posnums {
		posnums[j] = rand.Intn(20 - -20) + -20 //rand.Intn(max - min) + min
	}
	sumPos := 0
	for _, numm := range posnums {
		if numm > 0 {
			fmt.Println("Это число", numm, "положительное")
			sumPos += numm
		}
	}
	fmt.Println("Сумма положительных чисел:", sumPos)

	srezPosNums := []int{}
	positiveCount := 0
	for _, numsfromposnums := range posnums {
		if numsfromposnums > 0 {
			positiveCount++
			srezPosNums = append(srezPosNums, numsfromposnums)
		}

	}
	fmt.Println("Срез из положительных чисел:", positiveCount)

}
