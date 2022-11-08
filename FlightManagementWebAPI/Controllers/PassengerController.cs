using DomainModel.Models;
using FlightManagementWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly PassengerRepository _passengerRepository;
        public PassengerController(PassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }
        [HttpGet("{flightId:int}")]
        public IActionResult GetPassengers(int flightId)
        {
            try
            {
                var passengers = _passengerRepository.GetPassengers(flightId);
                return Ok(passengers);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("EditPassenger/{passengerId:int}")]
        public IActionResult GetPassenger(int passengerId)
        {
            try
            {
                var passenger = _passengerRepository.GetPassenger(passengerId);
                return Ok(passenger);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
        [HttpPut("checkPassenger")]
        public IActionResult CheckPassenger([FromBody]Passenger passenger)
        {
            if (passenger == null)
                return BadRequest();
            try
            {
                _passengerRepository.CheckPassenger(passenger);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public IActionResult AddPassenger([FromBody] Passenger passenger)
        {
            if (passenger == null)
                return BadRequest();

            try
            {
                _passengerRepository.InsertPassenger(passenger);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult UpdatePassenger([FromBody] Passenger passenger)
        {
            if (passenger == null)
                return BadRequest();
            try
            {
                _passengerRepository.UpdatePassenger(passenger);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{passengerId:int}")]
        public IActionResult DeletePassenger(int passengerId)
        {
            try
            {
                _passengerRepository.DeletePassenger(passengerId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
