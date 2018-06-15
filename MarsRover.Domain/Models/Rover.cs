using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Domain.Models
{
    public class Rover
    {
        public int RoverId { get; set; }
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
        public string RoverName { get; set; }

        public string CurrentDirection { get; set; }
        public Rover(int id, string name)
        {
            RoverId = id;
            RoverName = name;
            CurrentDirection = "N";
            CurrentX = 0;
            CurrentY = 0;
        }
    }
}
