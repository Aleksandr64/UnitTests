using UnitTests.App.Validation.Interface;

namespace UnitTests.App.Validation;

public class FileExtensionManager : IExtensionManager
{
    private bool wasLastFileNameValid;

    public bool WasLastFileNameValid
    {
        get => wasLastFileNameValid; 
        set => wasLastFileNameValid = value;
    }
    
    public bool IsValid(string fileName)
    {
        if (!fileName.ToLower().EndsWith(".slf"))
        {
            wasLastFileNameValid = false;
            return false;
        }

        wasLastFileNameValid = true;
        return true;
    }
}