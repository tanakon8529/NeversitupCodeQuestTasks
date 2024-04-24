package main

import (
	"testing"
)

func TestFindOddInt(t *testing.T) {
	testCases := []struct {
		input    []int
		expected int
	}{
		{[]int{20, 1, 1, 2, 2, 3, 3, 5, 5, 4, 20, 4, 5}, 5},
		{[]int{1, 2, 3, 1, 3, 2, 3}, 3},
		{[]int{1, 1, 2, -2, 5, 2, 4, 4, -1, -2, 5}, -1},
	}

	for _, tc := range testCases {
		actual := findOddInt(tc.input)
		if actual != tc.expected {
			t.Errorf("findOddInt(%v) = %d, expected %d", tc.input, actual, tc.expected)
		}
	}
}
