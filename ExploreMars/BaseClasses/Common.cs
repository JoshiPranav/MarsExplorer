using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public static class Common
    {
        public static DirectionsEnum DirectionHelper(string direction)
        {
            switch (direction)
            { 
                case "N":
                    return DirectionsEnum.N;
                case "S":
                    return DirectionsEnum.S;
                case "W":
                    return DirectionsEnum.W;
                case "E":
                    return DirectionsEnum.E;
                default:
                    throw new Exception("Invalid direction");
            }
        }
    }

    public enum CommandsEnum { L, R, M };

    public enum DirectionsEnum { N, S, E, W };
}
