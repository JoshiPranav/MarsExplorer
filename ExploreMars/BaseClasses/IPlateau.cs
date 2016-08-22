using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public interface IPlateau
    {
        int Height { get; set; }
        int Width { get; set; }
        Position GetRoverPosition(int Xpos, int Ypos);
    }
}
