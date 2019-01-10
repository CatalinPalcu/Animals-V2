using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface IFlying
    {
        double MaxFlyingSpeed { get; set; }
        void Fly();
    }
}
