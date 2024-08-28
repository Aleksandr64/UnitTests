using UnitTests.App.Validation.Interface;

namespace UnitTests.App.Validation;

public class LogAnalyzer
{
    private IExtensionManager manager;

    public LogAnalyzer()
    {
        manager = new FileExtensionManager();
    }

    public LogAnalyzer(IExtensionManager mgr)
    {
        manager = mgr;
    }
    
    public bool IsValidLogFileName(string fileName)
    {
        return manager.IsValid(fileName);
    }
}