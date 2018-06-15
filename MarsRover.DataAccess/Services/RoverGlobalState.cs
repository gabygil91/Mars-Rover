using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using MarsRover.Domain.Models;

namespace MarsRover.DataAccess.Services
{
    public static class RoverGlobalState
    {
        private static ConcurrentDictionary<int, Rover> _rovers = new ConcurrentDictionary<int, Rover>();
        public static ConcurrentDictionary<int, Rover> Rover
        {
            get
            {
                if (_rovers.IsEmpty) _rovers = new ConcurrentDictionary<int, Rover>();
                return _rovers;
            }
        }

        public static void SetNewRover(Rover rover)
        {
            _rovers.TryAdd(rover.RoverId, rover);
        }

        public static void UpdateRover(int id, Rover rover)
        {
            _rovers[id] = rover;
        }

        public static Rover GetRoverById(int id)
        {
            _rovers.TryGetValue(id, out var rover);
            return rover;
        }
    }

}
