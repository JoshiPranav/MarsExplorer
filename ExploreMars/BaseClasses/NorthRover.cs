using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public class NorthRover : IRoverDirection
    {
        public DirectionsEnum Direction = DirectionsEnum.N;

        public void TurnLeft(Rover rover)
        {
            IRoverDirection nextDirection = new WestRover();
            rover.RoverDirection = nextDirection;
        }

        public void TurnRight(Rover rover)
        {
            IRoverDirection nextDirection = new EastRover();
            rover.RoverDirection = nextDirection;
        }

        public void Move(Rover rover)
        {
            rover.MoveUp();
        }

        public DirectionsEnum getRoverDirection()
        {
            return Direction;
        }
    }
}
