using DomainModel.Models;
using FlightManagementWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public IActionResult GetAccounts()
        {
            try
            {
                var users = _userRepository.GetUsers();
                return Ok(users);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{userName}")]
        public IActionResult GetUser(string userName)
        {
            try
            {
                var user = _userRepository.GetUserByUserName(userName);
                return Ok(user);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
        [HttpGet("{userId:int}")]
        public IActionResult GetUser(int userId)
        {
            try
            {
                var user = _userRepository.GetUser(userId);
                return Ok(user);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user == null)
                return BadRequest();

            try
            {
                _userRepository.InsertUser(user);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult UpdateUser([FromBody] User user)
        {
            if (user == null)
                return BadRequest();
            try
            {
                _userRepository.UpdateUser(user);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{userId:int}")]
        public IActionResult DeleteUser(int userId)
        {
            try
            {
                _userRepository.DeleteUser(userId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
