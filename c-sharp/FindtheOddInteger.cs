using System;
using System.Collections.Generic;

public class FindOddInt {
    public static int FindIt(int[] seq) {
        var counts = new Dictionary<int, int>();
        foreach (int num in seq) {
            if (counts.ContainsKey(num)) {
                counts[num]++;
            } else {
                counts[num] = 1;
            }
        }

        foreach (var pair in counts) {
            if (pair.Value % 2 != 0) {
                return pair.Key;
            }
        }
        
        return 0;
    }

    public static void Main() {
        Console.WriteLine(FindIt(new int[] { 1, 2, 3, 1, 3, 2, 3 }));
    }
}
