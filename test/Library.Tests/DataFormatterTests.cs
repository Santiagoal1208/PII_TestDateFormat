using TestDateFormat;
namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void EstaBien()
    {
        string testDate = "10/11/1997";
        string expected = "1997-11-10";
        string resultado=DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual(expected,resultado);

    }
    [Test]
    public void EstaMal()
    {
        string expected = "1997-11-10";
        string testDate2 = "1997-11-10";
        string resultado2=DateFormatter.ChangeFormat(testDate2);
        Assert.AreEqual(expected,resultado2);

    }
    [Test]
    public void EstaVacio()
    {
        string testDate3 = "";
        string expected3 = "";
        string resultado3=DateFormatter.ChangeFormat(testDate3);
        Assert.AreEqual(expected3,resultado3);
    }
}