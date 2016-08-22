using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public class EastRover : IRoverDirection
    {
        public DirectionsEnum Direction = DirectionsEnum.E;

        public void TurnRight(Rover rover)
        {
            IRoverDirection nextDirection = new SouthRover();
            rover.RoverDirection = nextDirection;
        }

        public void TurnLeft(Rover rover)
        {
            IRoverDirection nextDirection = new NorthRover();
            rover.RoverDirection = nextDirection;
        }

        public void Move(Rover rover)
        {
            rover.MoveRight();
        }

        public DirectionsEnum getRoverDirection()
        {
            return Direction;
        }
    }
}
