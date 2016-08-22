using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public class SouthRover : IRoverDirection
    {
        public DirectionsEnum Direction = DirectionsEnum.S;

        public void TurnLeft(Rover rover)
        {
            IRoverDirection nextDirection = new EastRover();
            rover.RoverDirection = nextDirection;
        }

        public void TurnRight(Rover rover)
        {
            IRoverDirection nextDirection = new WestRover();
            rover.RoverDirection = nextDirection;
        }

        public void Move(Rover rover)
        {
            rover.MoveDown();
        }

        public DirectionsEnum getRoverDirection()
        {
            return Direction;
        }
    }
}
