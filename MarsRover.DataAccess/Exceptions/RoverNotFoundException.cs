using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.DataAccess.Exceptions
{
    public class RoverNotFoundException : SystemException
    {
        public RoverNotFoundException(string message)
            : base(message)
        {
        }
    }
}
