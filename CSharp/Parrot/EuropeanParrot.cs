using System;

namespace Parrot;

public class EuropeanParrot(double voltage, bool isNailed) : Parrot
{
    public override double GetSpeed()
    {
        return BaseSpeed;
    }
    
    public override string GetCry()
    {
        return "Sqoork!";
    }
}