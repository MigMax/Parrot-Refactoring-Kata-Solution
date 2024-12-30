using System;

namespace Parrot;

public class EuropeanParrot(double voltage, bool isNailed) : Parrot
{
    public override double GetSpeed() => BaseSpeed;

    public override string Cry() => "Sqoork!";
}