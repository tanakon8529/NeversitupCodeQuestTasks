package main

import (
	"testing"
)

func TestCountSmileyFaces(t *testing.T) {
	testCases := []struct {
		input    []string
		expected int
	}{
		{[]string{":)", ":(", ":D", ":O", ":;"}, 2},
		{[]string{":D", ":~)", ";~D", ":)"}, 4},
		{[]string{";]", ":[", ";*", ":$", ";-D"}, 1},
	}

	for _, tc := range testCases {
		actual := countSmileys(tc.input)
		if actual != tc.expected {
			t.Errorf("countSmileys(%v) = %d, expected %d", tc.input, actual, tc.expected)
		}
	}
}
