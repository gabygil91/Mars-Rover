using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Domain.Models;

namespace MarsRover.Domain.Contracts
{
    public interface ICommand
    {
        void Execute(Rover rover);
    }
}
