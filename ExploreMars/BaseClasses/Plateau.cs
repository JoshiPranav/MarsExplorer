using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public class Plateau : IPlateau
    {
        private int _height, _width;

        #region Properties

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        #endregion

        #region Initialise

        public Plateau() { }

        public Plateau(int Hght, int Wdth)
        {
            Height = Hght;
            Width = Wdth;
        }

        #endregion

        #region Private Methods

        private bool AreCoordinatesValid(int X, int Y)
        {
            return (IsXCoordValid(X) && IsYCoordValid(Y));
        }

        private bool IsXCoordValid(int X)
        {
            return (X >= 0 && X <= Height);
        }

        private bool IsYCoordValid(int Y)
        {
            return (Y >= 0 && Y <= Width);
        }

        #endregion

        #region Public Methods

        public Position GetRoverPosition(int Xpos, int Ypos)
        {
            if (!AreCoordinatesValid(Xpos, Ypos))
            {
                throw new Exception("This plateau does not contain these co-ordinates.");
            }
            else
            {
                return new Position(Xpos, Ypos);
            }
        }

        #endregion
    }
}
