using Xunit;

namespace Parrot.Tests;

public class AfricanParrotTest
{
    [Fact]
    public void GetSpeedOfAfricanParrot_With_No_Coconuts()
    {
        var parrot = new AfricanParrot(0);
        Assert.Equal(12.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedOfAfricanParrot_With_One_Coconut()
    {
        var parrot = new AfricanParrot(1);
        Assert.Equal(3.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedOfAfricanParrot_With_Two_Coconuts()
    {
        var parrot = new AfricanParrot(2);
        Assert.Equal(0.0, parrot.GetSpeed());
    }
    
    [Fact]
    public void GetCryOfAfricanParrot()
    {
        var parrot = new AfricanParrot(2);
        Assert.Equal("Sqaark!", parrot.Cry());
    }
}