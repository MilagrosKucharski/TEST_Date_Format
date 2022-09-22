using TestDateFormat;
namespace Library.Tests;
[TestFixture]
public class DateFormatterTests{
    [Test]
    
    public void TestCorrectDate()
    {
        const string expected = "1997-11-10";
        string testdate= DateFormatter.ChangeFormat("10/11/1997");
        Assert.AreEqual(expected,testdate);
    }

    [Test]
    public void TestIncorrectDate()
    {
        const string expected = "1997-11-10";
        string testDate2= DateFormatter.ChangeFormat("10-11-1997");
        Assert.AreEqual(expected,testDate2);
    }
    [Test]
    public void TestNullDate()
    {
        const string expected = "1997-11-10";
        string testDate2= DateFormatter.ChangeFormat(" ");
        Assert.AreEqual(expected,testDate2);
    }
}