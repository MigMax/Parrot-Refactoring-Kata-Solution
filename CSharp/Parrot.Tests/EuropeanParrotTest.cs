using Xunit;

namespace Parrot.Tests;

public class EuropeanParrotTest
{
    [Fact]
    public void GetSpeedOfEuropeanParrot()
    {
        var parrot = new EuropeanParrot();
        Assert.Equal(12.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetCryOfEuropeanParrot()
    {
        var parrot = new EuropeanParrot();
        Assert.Equal("Sqoork!", parrot.Cry());
    }
}