﻿using System;

namespace Parrot;

public class NorwegianBlueParrot(double voltage, bool isNailed) : Parrot
{
    public override double GetSpeed()
    {
        return isNailed ? 0 : GetBaseSpeed();
    }

    private double GetBaseSpeed()
    {
        return Math.Min(24.0, voltage * BaseSpeed);
    }

    public override string Cry()
    {
        return voltage > 0 ? "Bzzzzzz" : "...";
    }
}