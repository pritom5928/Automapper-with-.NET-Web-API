using AutoMapper;
using AutoMapper_Project1.DTOs;
using AutoMapper_Project1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_Project1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private IMapper _mapper;
        public List<User> Users;
        public List<UserDto> UserDtos;

        public UserController(ILogger<UserController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            Users = new List<User>
            {
                new User
                {
                     Id = 1,
                      Name = "Harry",
                       Age = 22
                },
                new User
                {
                     Id = 2,
                      Name = "Smith",
                       Age = 35
                },
                new User
                {
                     Id = 3,
                      Name = "Roy",
                       Age = 40
                }
            };
            UserDtos = new List<UserDto>
            {
                new UserDto
                {
                     UserId = 1,
                      UserName = "Harry",
                       UserAge = 22
                },
                new UserDto
                {
                     UserId = 2,
                      UserName = "Smith",
                       UserAge = 35
                },
                new UserDto
                {
                     UserId = 3,
                      UserName = "Roy",
                       UserAge = 40
                }
            };
        }

        [HttpGet]
        public ActionResult<List<UserDto>> GetAll()
        {
            var result = _mapper.Map<List<UserDto>>(Users);
            return Ok(result);
        }

        [HttpGet]
        public ActionResult<List<User>> GetAllReverse()
        {
            var result = _mapper.Map<List<User>>(UserDtos);
            return Ok(result);
        }

    }
}