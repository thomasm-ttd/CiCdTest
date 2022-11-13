namespace CiCdTestLibrary.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SayHelloTest()
    {
        var sut = new SampleClass();
        var result = sut.SayHello("from a test");
        Assert.That(result, Is.EqualTo("Hello: from a test"));
    }
}
