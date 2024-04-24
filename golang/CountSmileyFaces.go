package main

import (
	"regexp"
)

func countSmileys(arr []string) int {
	count := 0
	for _, face := range arr {
		matched, _ := regexp.MatchString(`(:|;)(-|~)?(\)|D)`, face)
		if matched {
			count++
		}
	}
	return count
}

// func main() {
// 	fmt.Println(countSmileys([]string{":)", ";(", ";}", ":-D"}))
// }
