using AutoMapper;
using LearnieService.DTOs;
using LearnieService.LearnieDbContext;
using LearnieService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace LearnieService.Controllers
{
    [Route("service/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private LearnieDatabaseContext _db;
        private readonly IMapper _mapper;

        public UsersController(LearnieDatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserModelForLogin userModel)
        {
            var user = _db.Users.FirstOrDefault(u => u.UserEmail == userModel.UserEmail && u.UserPassword == (userModel.UserPassword));

            if (user != null)
            {
                HttpContext.Session.SetString("UserEmail", user.UserEmail);

                return Ok(new { message = "Login Successfully" });
            }

            return Unauthorized(new { message = "Invalid email or password" });
        }


        [HttpPost("Register")]
        public IActionResult Register([FromBody] UserModelForRegister userModel)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                                        .SelectMany(v => v.Errors)
                                        .Select(e => e.ErrorMessage)
                                        .ToList();

                return BadRequest(new { message = "Validation errors", errors });
            }
            var check = _db.Users.FirstOrDefault(x => x.UserEmail == userModel.UserEmail);
            if (check != null)
            {
                return BadRequest(new { message = "Email already registered" });
            }

            var user = _mapper.Map<User>(userModel);

            _db.Users.Add(user);
            _db.SaveChanges();

            return Ok(new { message = "Registeration Successfully" });
        }
    }
}
