package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
	"strconv"
)

func main() {
	sw := 1
	switch sw {
	case 1:
		// 1) Определение и вызов метода
		var name string
		fmt.Println("Введите имя: ")
		PrintGreeting(name)
	case 2:
		// 2) Метод с возвращаемым значением
		var a int
		fmt.Println("Input first number")
		fmt.Scan(&a)
		var b int
		fmt.Println("Input second number")
		fmt.Scan(&b)
		CalculateSum(a, b)
	case 3:
		// 3) Перегрузка методов, только тут их нет, а используем интерфейсы и тип interface{}
		DisplayInfo("This is stroka")
		DisplayInfo(12345)
	case 4:
		// 4) Лямбда, только здесь анонимная функция
		scanner := bufio.NewScanner(os.Stdin)

		fmt.Println("Введите первое число:")
		scanner.Scan()
		firstInput := scanner.Text()
		firstNumber, err := strconv.Atoi(firstInput)
		if err != nil {
			log.Fatal("Ошибка при конвертации первого числа", err)
		}

		fmt.Println("Введите второе число:")
		scanner.Scan()
		secondInput := scanner.Text()
		secondNumber, err := strconv.Atoi(secondInput)
		if err != nil {
			log.Fatal("Ошибка при конвертации первого числа", err)
		}

		// Анонимная функция, аналог лямбда-выражению C#
		GetMax := func(x, y int) int {
			if x > y {
				return x
			}
			return y
		}

		maxNumber := GetMax(firstNumber, secondNumber)
		fmt.Printf("Большее число: %d\n", maxNumber)
	default:
		fmt.Println("None of cases")
	}

}

// PrintGreeting Метод для 1 задачи
func PrintGreeting(name string) {
	fmt.Scan(&name)
	fmt.Println("Hi", name)
}

// CalculateSum Метод для 2 задачи
func CalculateSum(a, b int) {
	c := a + b
	fmt.Println("Sum is", c)
}

// DisplayInfo Метод для 3 задачи
func DisplayInfo(i interface{}) {
	switch v := i.(type) {
	case string:
		fmt.Println("This is stroka:", v)
	case int:
		fmt.Println("This is chislo:", v)
	default:
		fmt.Println("What is this ?..", v)
	}
}

// GetMax Метод для 4 задачи

func WheretoGo() {
	fmt.Printf("\nChoose the task\n\n" +
		"1 Задача \n" +
		"2 Задача \n" +
		"3 Задача \n" +
		"4 Задача \n" +
		"5 Задача \n" +
		"6 Задача \n" +
		"7 Задача \n" + "\nВЫБОР: ")
	var command string
	fmt.Scanf()
}
