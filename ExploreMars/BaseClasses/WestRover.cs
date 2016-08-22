using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public class WestRover : IRoverDirection
    {
        public DirectionsEnum Direction = DirectionsEnum.W;

        public void TurnLeft(Rover rover)
        {
            IRoverDirection nextDirection = new SouthRover();
            rover.RoverDirection = nextDirection;
        }

        public void TurnRight(Rover rover)
        {
            IRoverDirection nextDirection = new NorthRover();
            rover.RoverDirection = nextDirection;
        }

        public void Move(Rover rover)
        {
            rover.MoveLeft();
        }

        public DirectionsEnum getRoverDirection()
        {
            return Direction;
        }
    }
}
