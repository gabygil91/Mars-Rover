using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MarsRover.DataAccess.Repositories;
using MarsRover.Domain.Contracts;
using MarsRover.Domain.Models;

namespace MarsRoverApi.Controllers
{
    /// <inheritdoc />
    /// <summary>
    /// Controller to control the rover in mars using a combination of string characters : L, R, and M
    /// </summary>
    public class MarsRoversController : ApiController
    {
        public IMarsRoverRepository MarsRoverRepository { get; set; }

        //TODO: Implement Dependency Injection 
        ///// <inheritdoc />
        //public MarsRoverController(IMarsRoverRepository marsRoverRepository)
        //{
        //    MarsRoverRepository = marsRoverRepository;
        //}

        /// <summary>
        /// Creates a new Rover
        /// </summary>
        /// <param name="roverId"></param>
        /// <param name="roverName"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Rovers")]
        public void CreateRover(int roverId, string roverName)
        {
            MarsRoverRepository = new MarsRoverRepository();
            MarsRoverRepository.Create(roverId, roverName);
        }

        /// <summary>
        /// Updates the name of a rover
        /// </summary>
        /// <param name="roverId"></param>
        /// <param name="roverName"></param>
        [HttpPut]
        [Route("Rovers/{roverId}")]
        public void UpdateRover(int roverId, string roverName)
        {
            MarsRoverRepository = new MarsRoverRepository();
            MarsRoverRepository.Update(roverId, roverName);
        }

        /// <summary>
        /// Moves the Rover depending on the L, R, M istructions
        /// </summary>
        /// <param name="roverId">The unique id of the rover to move</param>
        /// <param name="movementInstruction">Valid instructions letters include “L”, “R”, “M”. No other characters (or spaces) should be allowed.</param>
        [HttpPost]
        [Route("Rovers/{roverId}/Move")]
        public Rover MoveRover(int roverId, string movementInstruction)
        {
            MarsRoverRepository = new MarsRoverRepository();
            return MarsRoverRepository.Move(roverId, movementInstruction);
        }

        /// <summary>
        /// Get Rover by Id
        /// </summary>
        /// <param name="roverId"></param>
        [HttpGet]
        [Route("Rovers/{roverId}")]
        public Rover GetRover(int roverId)
        {
            MarsRoverRepository = new MarsRoverRepository();
            return MarsRoverRepository.Get(roverId);
        }
    }
}
