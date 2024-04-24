using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class PermutationsTests
{
    [Test]
    public void BasicTests()
    {
        var permutations = new Permutations();
        var result = permutations.Permute("a");
        CollectionAssert.AreEquivalent(new List<string> { "a" }, result);

        result = permutations.Permute("ab");
        CollectionAssert.AreEquivalent(new List<string> { "ab", "ba" }, result);

        result = permutations.Permute("aabb");
        CollectionAssert.AreEquivalent(new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" }, result);
    }
}
