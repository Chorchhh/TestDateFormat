using TestDateFormat;

namespace TestDateFormat;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Formato_Correcto()
    {
        const string input = "11/09/2003";
        const string expected = "2003-09-11";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void Formato_Incorrecto()
    {
        const string input = "11/09/200";
        const string expected = "";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void Formate_Vacio()
    {
        const string input = "";
        const string expected = "";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
