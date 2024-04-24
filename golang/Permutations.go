package main

import (
	"fmt"
)

func permute(s []rune, start int, result *[]string) {
	if start == len(s) {
		*result = append(*result, string(s))
		return
	}
	for i := start; i < len(s); i++ {
		s[start], s[i] = s[i], s[start]
		permute(s, start+1, result)
		s[start], s[i] = s[i], s[start] // backtrack
	}
}

func permutations(input string) []string {
	var result []string
	permute([]rune(input), 0, &result)
	return result
}

func main() {
	input := "abc"
	result := permutations(input)
	fmt.Println(result)
}
