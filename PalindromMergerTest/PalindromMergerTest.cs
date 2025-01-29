using PalindromMergerPC;

namespace PalindromMergerTest;

public class PalindromMergerTest
{
    private PalindromMerger _PM;
    [SetUp]
    public void Setup()
    {
        _PM = new PalindromMerger();
    }

    [Test]
    [TestCase("otto", "hannah","hoatnntaoh")]
    [TestCase ("otto","anna","oatnntao")]
    [TestCase("otto","aba","oatbtao")]
    [TestCase("anna","abcdcba","aabncdcnbaa")]
    [TestCase("aba","cdc","")]
    public void PalindromMerger_Test(string Palindrom1, string Palindrom2, string expectedResult)
    {
        string result = _PM.Merge(Palindrom1, Palindrom2);
        Assert.That(_PM.Merge(Palindrom1, Palindrom2).Equals(expectedResult));
    }
}
