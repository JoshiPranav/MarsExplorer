using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public class RoverFactory
    {
        /// <summary>
        /// Create the object based on DirectionEnumerator. Runtime polymorphism.
        /// </summary>
        /// <param name="targetDirection"></param>
        /// <returns></returns>
        public static IRoverDirection getRoverInstanceByDirection(DirectionsEnum targetDirection)
        {
            switch (targetDirection)
            { 
                case DirectionsEnum.E:
                    return new EastRover();
                case DirectionsEnum.N:
                    return new NorthRover();
                case DirectionsEnum.S:
                    return new SouthRover();
                case DirectionsEnum.W:
                    return new WestRover();
               default:
                    throw new Exception("Invalid rover direction");
            }
        }
    }
}
