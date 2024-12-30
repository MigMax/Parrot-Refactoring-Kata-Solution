using Xunit;

namespace Parrot.Tests;

public class NorwegianParrotTest
{
    [Fact]
    public void GetSpeedNorwegianBlueParrot_nailed()
    {
        var parrot = new NorwegianBlueParrot(0, true);
        Assert.Equal(0.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedNorwegianBlueParrot_nailed_with_voltage()
    {
        var parrot = new NorwegianBlueParrot(1.5, true);
        Assert.Equal(0.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedNorwegianBlueParrot_not_nailed()
    {
        var parrot = new NorwegianBlueParrot(1.5, false);
        Assert.Equal(18.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedNorwegianBlueParrot_not_nailed_high_voltage()
    {
        var parrot = new NorwegianBlueParrot(4, false);
        Assert.Equal(24.0, parrot.GetSpeed());
    }
    
    [Fact]
    public void GetCryNorwegianBlueParrot_high_voltage()
    {
        var parrot = new NorwegianBlueParrot(4, false);
        Assert.Equal("Bzzzzzz", parrot.Cry());
    }
}