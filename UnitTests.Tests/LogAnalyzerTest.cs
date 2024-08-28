using UnitTests.App;
using UnitTests.App.Validation;
using UnitTests.App.Validation.Interface;

namespace UnitTests.Tests;

[TestFixture]
public class LogAnalyzerTest
{
    private LogAnalyzer _logAnalyzer = null;

    [SetUp]
    public void SetUp()
    {
        _logAnalyzer = new LogAnalyzer();
    }
    
    [Test]
    public void IsValidFileName_validFileLowerCased_Returns_True()
    {
        var result = _logAnalyzer.IsValidLogFileName("Filename.slf");
        
        Assert.IsTrue(result, "filename should be valid");
    }


    [Test]
    public void IsValidFileName_NameShorterThan6CharsButSupportedExtension_ReturnsFalse()
    {
        var myFakeManager = new StubExtensionManager();
        myFakeManager.ShouldExtensionBeValid = true;

        LogAnalyzer log = new LogAnalyzer(myFakeManager);

        bool result = log.IsValidLogFileName("short.ext");
        Assert.IsTrue(result, "File name with less than 5 chars should have failed the method, even if the extension is supported");
    }
    
    [TearDown]
    public void TearDown()
    {
        LogAnalyzer = null;
    }
}