using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.DataAccess.Exceptions;
using MarsRover.Domain.Commands;
using MarsRover.Domain.Contracts;

namespace MarsRover.DataAccess.Util
{
    public static class MovementInstructionParser
    {
        
        public static List<ICommand> ParseInstruction(string instruction)
        {
           
            var hasSpace = instruction.Contains(" ");
            if (hasSpace)
            {
                throw new SpaceFoundException("No spaces allowed");
            }
            var commands = GetCommands(instruction);

            return commands;
        }

        private static List<ICommand> GetCommands(string instruction)
        {
            var commands = new List<ICommand>();
            foreach (var charCommand in instruction)
            {
                switch (charCommand)
                {
                    case 'L':
                        commands.Add(new LeftCommand());
                        break;
                    case 'R':
                        commands.Add(new RightCommand());
                        break;
                    case 'M':
                        commands.Add(new MoveCommand());
                        break;
                    default:
                        throw new UnknownCommandException("Only L,R, and M characters are allowed");
                }
            }

            return commands;
        }
    }
}
