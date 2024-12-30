using System;

namespace Parrot;

public class AfricanParrot(int numberOfCoconuts) : Parrot
{
    private const double LoadFactor = 9.0;
    
    public override double GetSpeed() => Math.Max(0, BaseSpeed - LoadFactor * numberOfCoconuts);

    public override string Cry() => "Sqaark!";
}