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
			string hashedPassword = HashPassword(userModel.UserPassword);

			var user = _db.Users.FirstOrDefault(u => u.UserEmail == userModel.UserEmail && u.UserPassword == hashedPassword);

			if (user != null)
			{
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

			if (_db.Users.Any(u => u.UserEmail == userModel.UserEmail))
			{
				return BadRequest(new { message = "Email already registered" });
			}

			userModel.UserPassword = HashPassword(userModel.UserPassword);
			var user = _mapper.Map<User>(userModel);

			_db.Users.Add(user);
			_db.SaveChanges();

			return Ok(new { message = "Login Successfully" });
		}

		private string HashPassword(string password)
		{
			using (var sha256 = SHA256.Create())
			{
				var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
				return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
			}
		}
	}
}
