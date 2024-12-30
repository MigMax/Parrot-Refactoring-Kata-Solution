﻿using System;

namespace Parrot;

public class AfricanParrot(int numberOfCoconuts, double voltage, bool isNailed) : Parrot(ParrotTypeEnum.AFRICAN, voltage, isNailed)
{
    public override double GetSpeed()
    {
        return Math.Max(0, BaseSpeed - LoadFactor * numberOfCoconuts);
    }
    
    public override string GetCry()
    {
        return "Sqaark!";
    }
}