using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public class Rover
    {
        private IPlateau _associatedPlateau;
        private IRoverDirection _roverDirection;
        private Position _roverPosition;
        
        /// <summary>
        /// Constructor called from Program.Main, when a new rover object is created.
        /// </summary>
        /// <param name="associatedPlateau"></param>
        /// <param name="startingPosition"></param>
        /// <param name="initialDirection"></param>
        public Rover(IPlateau associatedPlateau, Position startingPosition, DirectionsEnum initialDirection)
        {
            this.RoverPosition = startingPosition;
            this.AssociatedPlateau = associatedPlateau;
            this.RoverDirection = RoverFactory.getRoverInstanceByDirection(initialDirection);
        }

        /// <summary>
        /// Rover GETTER's and SETTER's
        /// </summary>
        #region Public Properties

        public IPlateau AssociatedPlateau
        {
            get
            {
                return _associatedPlateau;
            }
            set
            {
                _associatedPlateau = value;
            }
        }

        public IRoverDirection RoverDirection
        {
            get
            {
                return _roverDirection;
            }
            set
            {
                _roverDirection = value;
            }
        }

        public Position RoverPosition
        {
            get
            {
                return _roverPosition;
            }
            set
            {
                _roverPosition = value;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// This is called from individual direction classes. InShort IRoverDirection now points to new direction concrete class... hence in execute routine when next command is 
        /// execuited, IRoverDirection points to correct direction object.
        /// </summary>
        /// <param name="nextDirection"></param>
        /// <returns></returns>
        public IRoverDirection NextDirectionIs(IRoverDirection nextDirection)
        {
            this.RoverDirection = nextDirection;
            return this.RoverDirection;
        }

        /// <summary>
        /// Changes the position. Called from direction concrete classes
        /// </summary>
        public void MoveUp()
        {
            this.RoverPosition = AssociatedPlateau.GetRoverPosition(this.RoverPosition.XPoisition, this.RoverPosition.YPosition + 1);
        }

        /// <summary>
        /// Changes the position. Called from direction concrete classes
        /// </summary>
        public void MoveDown()
        {
            this.RoverPosition = AssociatedPlateau.GetRoverPosition(this.RoverPosition.XPoisition, this.RoverPosition.YPosition - 1);
        }

        /// <summary>
        /// Changes the position. Called from direction concrete classes
        /// </summary>
        public void MoveLeft()
        {
            this.RoverPosition = AssociatedPlateau.GetRoverPosition(this.RoverPosition.XPoisition - 1, this.RoverPosition.YPosition); //new Position(this.RoverPosition.XPoisition - 1, this.RoverPosition.YPosition);
        }

        /// <summary>
        /// Changes the position. Called from direction concrete classes
        /// </summary>
        public void MoveRight()
        {
            this.RoverPosition = AssociatedPlateau.GetRoverPosition(this.RoverPosition.XPoisition + 1, this.RoverPosition.YPosition);
        }

        /// <summary>
        /// EXECUTE the rover motion based on a command list
        /// </summary>
        /// <param name="commands"></param>
        /// <returns></returns>
        public Rover Execute(List<char> commands)
        {
            foreach (char command in commands)
            {
                if (command.ToString().ToUpper() == CommandsEnum.L.ToString())
                {
                    this.RoverDirection.TurnLeft(this);
                }
                else if (command.ToString().ToUpper() == CommandsEnum.R.ToString())
                {
                    this.RoverDirection.TurnRight(this);
                }
                else if (command.ToString().ToUpper() == CommandsEnum.M.ToString())
                {
                    this.RoverDirection.Move(this);
                }
                else
                {
                    throw new Exception("Bad command");
                }
            }
            return this;
        }

        #endregion
    }
}
