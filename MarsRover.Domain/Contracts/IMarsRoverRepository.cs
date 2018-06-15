using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Domain.Models;

namespace MarsRover.Domain.Contracts
{
    public interface IMarsRoverRepository
    {
        void Create(int roverId, string roverName);

        void Update(int roverId, string roverName);

        Rover Move(int roverId, string movementInstruction);

        Rover Get(int roverId);
    }
}
