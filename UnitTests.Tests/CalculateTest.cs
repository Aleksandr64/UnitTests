using UnitTests.App;

namespace UnitTests.Tests;

[TestFixture]
public class CalculateTest
{
    private Calculate calc = null;
    
    [SetUp]
    public void SetUp()
    {
        calc = new Calculate();
    }

    [Test]
    public void Sum_NoAddCalls_DefaultsToZero()
    {
        int lastSum = calc.Sum();
        Assert.AreEqual(0, lastSum);
    }

    [Test]
    public void Add_CalledOnce_SavesNumberForSum()
    {
        calc.Add(1);
        int lastSum = calc.Sum();
        Assert.AreEqual(1, lastSum);
    }
}