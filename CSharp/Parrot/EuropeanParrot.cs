using System;

namespace Parrot;

public class EuropeanParrot : Parrot
{
    public override double GetSpeed() => BaseSpeed;

    public override string Cry() => "Sqoork!";
}