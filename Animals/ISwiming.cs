using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface ISwiming
    {
        double MaxSwimingSpeed { get; set; }
        void Swim();
    }
}
