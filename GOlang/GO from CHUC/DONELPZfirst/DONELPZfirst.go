package main

import (
	"fmt"
	"math"
)

func main() {
	var zadacha string
	fmt.Printf("enter the number of case\n")
	fmt.Scanln(&zadacha)
	switch zadacha {
	case "1":
		fmt.Printf("Упражнение 1 Налоги и чаевые\n")
		fmt.Printf("enter the sum of the order\n")
		var sum float64
		fmt.Scanln(&sum)
		nalog := sum * 0.18
		chai := sum * 0.2
		itog := sum + nalog + chai

		fmt.Printf("sum of the order: %.2f\n", sum)
		fmt.Printf("nalog: %.2f\n", nalog)
		fmt.Printf("chai: %.2f\n", chai)
		fmt.Printf("itog: %.2f\n", itog)
	case "2":
		fmt.Printf("Упражнение 2 Сложные проценты\n")
		var sber float64
		fmt.Printf("input the deposit\n")
		fmt.Scanln(&sber)
		sberafterfirstyear := sber*0.04 + sber
		sberaftersecondyear := sberafterfirstyear*0.04 + sberafterfirstyear
		sberafterthirdyear := sberaftersecondyear*0.04 + sberaftersecondyear
		fmt.Printf("Sber: %f\n", sber)
		fmt.Printf("Sber after first year: %f\n", sberafterfirstyear)
		fmt.Printf("Sber after second year: %f\n", sberaftersecondyear)
		fmt.Printf("Sber after third year: %f\n", sberafterthirdyear)
	case "3":
		fmt.Printf("Упражнение 3 Арифметика\n")
		fmt.Printf("input the a\n")
		var a float64
		fmt.Scanln(&a)
		fmt.Printf("input the b\n")
		var b float64
		fmt.Scanln(&b)
		summa := a + b
		raznitsa := a - b
		proizvedenie := a * b
		delenienormalnoe := a / b
		deleniesostatkom := math.Mod(a, b)
		pow := math.Pow(a, b)
		fmt.Printf("summa: %f\nranitsa: %f\nproizvedenie: %f\ndelenienormalnoe: %f\ndeleniesostatkom: %f\npow: %f\n", summa, raznitsa, proizvedenie, delenienormalnoe, deleniesostatkom, pow)
	case "4":
		fmt.Printf("Упражнение 4 Чет или нечет?\n")
		fmt.Printf("input the number\n")
		var chetilinechet int
		fmt.Scanln(&chetilinechet)
		if chetilinechet%2 == 0 {
			fmt.Printf("chislo chetnoe")
		} else {
			fmt.Printf("chislo nechetnoe")
		}
	case "5":
		fmt.Printf("Упражнение 5 Портреты на банкнотах\n")
		portraits := map[int]string{
			1:   "Джордж Вашингтон",
			2:   "Томас Джефферсон",
			5:   "Авраам Линкольн",
			10:  "Александр Гамильтон",
			20:  "Эндрю Джексон",
			50:  "Улисс Грант",
			100: "Бенджамин Франклин",
		}
		fmt.Printf("input $ of banknot\n")
		var denomination int
		fmt.Scanln(&denomination)
		if name, exists := portraits[denomination]; exists {
			fmt.Printf("На банкноте номиналом $%d изображён %s\n", denomination, name)
		} else {
			fmt.Printf("None")
		}
	case "6":
		fmt.Printf("Упражнение 6 Собачий возраст\n")
		dogfirsttwoyears := 10.5
		doganotheryears := 4.0
		var dogage float64
		fmt.Printf("Введите возраст собаки\n")
		fmt.Scanln(&dogage)
		if dogage == 1 || dogage == 2 {
			fmt.Printf("Возраст собаки %.1f в человеческих годах - %.1f\n", dogage, dogfirsttwoyears*dogage)
		} else if dogage >= 2 {
			fmt.Printf("Возраст собаки %.1f в человеческих годах - %.1f\n", dogage,
				(dogage-2)*doganotheryears+dogfirsttwoyears*2)
		} else {
			fmt.Printf("Неверное число, попробуйте снова")
		}
	default:
		fmt.Printf("Incorrect number of case, try again")
	}
}
