using NUnit.Framework;

[TestFixture]
public class FindtheOddIntegerTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(5, FindOddInt.FindIt(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        Assert.AreEqual(-1, FindOddInt.FindIt(new[] { 1, 1, 2, -2, 5, 2, 4, 4, -1, -2, 5 }));
        Assert.AreEqual(5, FindOddInt.FindIt(new[] { 20, 1, 1, 2, 2, 3, 3, 5, 5, 4, 20, 4, 5 }));
        Assert.AreEqual(10, FindOddInt.FindIt(new[] { 10 }));
        Assert.AreEqual(10, FindOddInt.FindIt(new[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 }));
    }
}
