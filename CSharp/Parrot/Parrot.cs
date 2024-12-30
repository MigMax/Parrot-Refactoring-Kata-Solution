using System;

namespace Parrot;

public class Parrot(ParrotTypeEnum type, double voltage, bool isNailed)
{
    protected const double BaseSpeed = 12.0;
    
    public virtual double GetSpeed()
    {
        return type switch
        {
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    public virtual string GetCry()
    {
        return type switch
        {
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}