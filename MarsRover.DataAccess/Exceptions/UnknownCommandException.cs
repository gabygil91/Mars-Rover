using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.DataAccess.Exceptions
{
    public class UnknownCommandException : SystemException
    {
        public UnknownCommandException(string message)
            : base(message)
        {
        }
    }
}
