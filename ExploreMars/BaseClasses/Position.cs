using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreMars.BaseClasses
{
    public class Position
    {
        private int _xPosition, _yPosition;

        #region Public Properties

        public int XPoisition
        {
            get
            {
                return _xPosition;
            }
            set
            {
                _xPosition = value;
            }
        }

        public int YPosition
        {
            get
            {
                return _yPosition;
            }
            set
            {
                _yPosition = value;
            }
        }

        #endregion

        #region Initialise

        public Position(int XPos, int YPos)
        {
            XPoisition = XPos;
            YPosition = YPos;
        }

        #endregion
    }
}
