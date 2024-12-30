using System;

namespace Parrot;

public class Parrot(ParrotTypeEnum type, double voltage, bool isNailed)
{
    public virtual double GetSpeed()
    {
        return type switch
        {
            ParrotTypeEnum.NORWEGIAN_BLUE => isNailed ? 0 : GetBaseSpeed(voltage),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    private static double GetBaseSpeed(double voltage)
    {
        return Math.Min(24.0, voltage * BaseSpeed);
    }
    
    protected const double BaseSpeed = 12.0;
    
    public virtual string GetCry()
    {
        return type switch
        {
            ParrotTypeEnum.NORWEGIAN_BLUE => voltage > 0 ? "Bzzzzzz" : "...",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}