package main

import (
	"reflect"
	"sort"
	"testing"
)

func TestPermutations(t *testing.T) {
	testCases := []struct {
		input    string
		expected []string
	}{
		{"a", []string{"a"}},
		{"ab", []string{"ab", "ba"}},
		{"abc", []string{"abc", "acb", "bac", "bca", "cab", "cba"}},
	}

	for _, tc := range testCases {
		actual := permutations(tc.input)
		sort.Strings(actual)
		sort.Strings(tc.expected)
		if !reflect.DeepEqual(actual, tc.expected) {
			t.Errorf("permutations(%v) = %v, expected %v", tc.input, actual, tc.expected)
		}
	}
}
