using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public interface IRoverDirection
    {
        /// <summary>
        /// to be implemented in derived class to instantiate new object based on current direction. Eg: if current derived class is north then TurnLeft will create new West()
        /// </summary>
        /// <param name="rover"></param>
        void TurnLeft(Rover rover);
        
        /// <summary>
        /// to be implemented in derived class to instantiate new object based on current direction. Eg: if current derived class is north then TurnRight will create new East()
        /// </summary>
        /// <param name="rover"></param>
        void TurnRight(Rover rover);
        
        /// <summary>
        /// to be implemented in derived class to instantiate new object based on current direction. Eg: if current derived class is north then Move will add 1 to YCo-ordinates 
        /// of the position object
        /// </summary>
        /// <param name="rover"></param>
        void Move(Rover rover);

        /// <summary>
        /// To get the direction sensor when displaying the output.
        /// </summary>
        /// <returns></returns>
        DirectionsEnum getRoverDirection();
    }
}
