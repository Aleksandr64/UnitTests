using UnitTests.App.Validation.Interface;

namespace UnitTests.App.Validation;

public class StubExtensionManager : IExtensionManager
{
    private bool _shouldExtensionBeValid = false;

    public bool ShouldExtensionBeValid
    {
        get => _shouldExtensionBeValid;
        set => _shouldExtensionBeValid = value;
    }
    
    public bool IsValid(string fileName)
    {
        return true;
    }
}