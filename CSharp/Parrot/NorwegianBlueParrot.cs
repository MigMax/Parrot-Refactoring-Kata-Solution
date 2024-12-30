using System;

namespace Parrot;

public class NorwegianBlueParrot(double voltage, bool isNailed) : Parrot
{
    public override double GetSpeed() => isNailed ? 0 : GetSpeedBasedOnVoltage();

    private double GetSpeedBasedOnVoltage() => Math.Min(24.0, voltage * BaseSpeed);

    public override string Cry() => voltage > 0 ? "Bzzzzzz" : "...";
}