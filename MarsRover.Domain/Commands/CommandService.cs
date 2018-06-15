using MarsRover.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Domain.Commands
{
    public static class CommandService
    {
        private static readonly List<string> Directions = new List<string> { "N", "E", "S", "W" };
        public static void TurnRight(this Rover rover)
        {
            var currentIndex = Directions.FindIndex(d => d == rover.CurrentDirection);
            var nextIndex = currentIndex + 1;
            rover.CurrentDirection = nextIndex >= Directions.Count ? Directions[0] : Directions[nextIndex];
        }
        public static void TurnLeft(this Rover rover)
        {
            var currentIndex = Directions.FindIndex(d => d == rover.CurrentDirection);
            var prevIndex = currentIndex - 1;
            rover.CurrentDirection = prevIndex < 0 ? Directions[Directions.Count - 1] : Directions[prevIndex];
        }

        public static void MovePosition(this Rover rover)
        {
            var currentX = rover.CurrentX;
            var currentY = rover.CurrentY;
            switch (rover.CurrentDirection)
            {
                case "N":
                    rover.CurrentX = currentX;
                    rover.CurrentY = currentY + 1;
                    break;
                case "E":
                    rover.CurrentX = currentX + 1; 
                    rover.CurrentY = currentY;
                    break;
                case "S":
                    rover.CurrentX = currentX;
                    rover.CurrentY = currentY - 1;
                    break;
                case "W":
                    rover.CurrentX = currentX - 1;
                    rover.CurrentY = currentY;
                    break;
                default:
                    break;
            }
        }
    }
   
}
