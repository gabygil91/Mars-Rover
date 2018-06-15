using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Domain.Contracts;
using MarsRover.Domain.Models;

namespace MarsRover.Domain.Commands
{
    public class MoveCommand : ICommand
    {
        public void Execute(Rover rover)
        {
            rover.MovePosition();
        }
    }
}
