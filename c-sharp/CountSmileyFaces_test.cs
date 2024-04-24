using NUnit.Framework;

[TestFixture]
public class CountSmileyFacesTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(4, SmileyFaces.CountSmileys(new[] { ":D", ":~)", ";~D", ":)" }));
        Assert.AreEqual(2, SmileyFaces.CountSmileys(new[] { ":)", ":(", ":D", ":O", ":;" }));
        Assert.AreEqual(0, SmileyFaces.CountSmileys(new[] { ";", ")", ";*", ":$", ";-D" }));
    }
}
