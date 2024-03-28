package main

import (
	"fmt"
	"strings"
	"unicode"
)

func main() {
	fmt.Printf("Введите строку\n")
	var stroka string
	fmt.Scanln(&stroka)

	lookFor1 := "_"
	contain1 := strings.Contains(stroka, lookFor1)
	fmt.Printf("The \"%s\" contains \"%s\": %t \n", stroka, lookFor1, contain1)

	lookFor2 := "-"
	contain2 := strings.Contains(stroka, lookFor2)
	fmt.Printf("The \"%s\" contains \"%s\": %t \n", stroka, lookFor2, contain2)

	if contain1 == true || contain2 == true {
		var output []rune
		isWord := true
		for _, val := range stroka {
			if isWord && unicode.IsLetter(val) {
				output = append(output, unicode.ToUpper(val))
				isWord = false
			} else if !unicode.IsLetter(val) {
				isWord = true
				output = append(output, val)
			} else {
				output = append(output, val)
			}
		}

		fmt.Println("The string after its capitalization is:")
		replacer := strings.NewReplacer("-", " ", "_", " ")
		out := replacer.Replace(string(output))
		fmt.Println(out)
	}
}
