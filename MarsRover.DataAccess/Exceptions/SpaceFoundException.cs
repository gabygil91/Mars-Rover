using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.DataAccess.Exceptions
{
    public class SpaceFoundException : SystemException
    {
        public SpaceFoundException(string message)
            : base(message)
        {
        }
    }
}
