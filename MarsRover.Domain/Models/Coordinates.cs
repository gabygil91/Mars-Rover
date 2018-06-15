using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Domain.Models
{
    public class Coordinates
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">the x coordinate to travel</param>
        /// <param name="y">the y coordinate to travel</param>
        public Coordinates(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }

    }
}
