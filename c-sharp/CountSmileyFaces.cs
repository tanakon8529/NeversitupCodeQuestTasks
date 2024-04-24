using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class SmileyFaces {
    public static int CountSmileys(string[] smileys) {
        int count = 0;
        Regex smileyPattern = new Regex(@"(:|;)(-|~)?(\)|D)");

        foreach (string smiley in smileys) {
            if (smileyPattern.IsMatch(smiley)) {
                count++;
            }
        }
        
        return count;
    }

    public static void Main() {
        string[] faces = { ":)", ";(", ";}", ":-D" };
        Console.WriteLine(CountSmileys(faces));
    }
}
