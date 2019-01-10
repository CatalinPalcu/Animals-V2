using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface IWalking
    {
        double MaxWalkingSpeed { get; set; }
        void Walk();
    }
}
