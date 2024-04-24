package main

func findOddInt(seq []int) int {
	nums := make(map[int]int)
	for _, num := range seq {
		nums[num]++
	}
	for num, count := range nums {
		if count%2 != 0 {
			return num
		}
	}
	return 0
}
