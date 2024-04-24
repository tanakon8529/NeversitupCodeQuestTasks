using System;
using System.Collections.Generic;

public class Permutations {
    private void Swap(ref char a, ref char b) {
        if (a == b) return;
        a ^= b;
        b ^= a;
        a ^= b;
    }

    private void GetPermutations(char[] list, int recursionDepth, ref List<string> result) {
        if (recursionDepth == list.Length) {
            result.Add(new string(list));
            return;
        }

        for (var i = recursionDepth; i < list.Length; i++) {
            Swap(ref list[recursionDepth], ref list[i]);
            GetPermutations(list, recursionDepth + 1, ref result);
            Swap(ref list[recursionDepth], ref list[i]);
        }
    }

    public List<string> Permute(string s) {
        var result = new List<string>();
        GetPermutations(s.ToCharArray(), 0, ref result);
        return result;
    }
    
    public static void Main() {
        var permutations = new Permutations();
        var result = permutations.Permute("abc");
        Console.WriteLine(string.Join(", ", result));
    }
}
