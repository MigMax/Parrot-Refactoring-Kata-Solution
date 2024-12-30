using System;

namespace Parrot;

public abstract class Parrot
{
    protected const double BaseSpeed = 12.0;

    public abstract double GetSpeed();
    public abstract string GetCry();
}