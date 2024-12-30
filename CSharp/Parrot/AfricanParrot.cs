using System;

namespace Parrot;

public class AfricanParrot(int numberOfCoconuts, double voltage, bool isNailed) : Parrot
{
    private const double LoadFactor = 9.0;
    
    public override double GetSpeed()
    {
        return Math.Max(0, BaseSpeed - LoadFactor * numberOfCoconuts);
    }
    
    public override string GetCry()
    {
        return "Sqaark!";
    }
}