using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.DataAccess.Exceptions;
using MarsRover.DataAccess.Services;
using MarsRover.DataAccess.Util;
using MarsRover.Domain.Contracts;
using MarsRover.Domain.Models;

namespace MarsRover.DataAccess.Repositories
{
    public class MarsRoverRepository : IMarsRoverRepository
    {
        public void Create(int roverId, string roverName)
        {
            var rover = new Rover(roverId, roverName);
            RoverGlobalState.SetNewRover(rover);          
        }

        public void Update(int roverId, string roverName)
        {
            var rover = Get(roverId);
            rover.RoverName = roverName;
            RoverGlobalState.UpdateRover(roverId, rover);
        }

        public Rover Move(int roverId, string movementInstruction)
        {
            var rover = Get(roverId);
            var commands = MovementInstructionParser.ParseInstruction(movementInstruction);
            foreach (var command in commands)
            {
                command.Execute(rover);
            }

            return rover;
        }

        public Rover Get(int roverId)
        {
            var rover = RoverGlobalState.GetRoverById(roverId);
            if (rover == null)
            {
                throw new RoverNotFoundException("Rover with id " + roverId + " not found");
            }

            return rover;
        }
    }
}
