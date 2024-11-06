using AutoMapper;
using LearnieService.DTOs;
using LearnieService.LearnieDbContext;
using LearnieService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace LearnieService.Controllers
{
	[Route("service/[controller]")]
	[ApiController]
	public class QuestionSetController : ControllerBase
	{
		private LearnieDatabaseContext _db;
		private readonly IMapper _mapper;

		public QuestionSetController(LearnieDatabaseContext db, IMapper mapper)
		{
			_db = db;
			_mapper = mapper;
		}
        [HttpGet("GetAllQuestionSets")]
        public ActionResult<IEnumerable<QuestionSet>?> GetAllQuestionSets()
        {
            var email = HttpContext.Session.GetString("UserEmail"); // Lấy Email từ session
            if (string.IsNullOrEmpty(email))
            {
                return Unauthorized(new { message = "User not logged in" });
            }

            var user = _db.Users.FirstOrDefault(x => x.UserEmail == email);
            if (user == null)
            {

                return NotFound(new { message = "User not found" });
            }

            var list = _db.QuestionSets.Where(x => x.UserID == user.UserID).ToList();
            return list;
        }


        [HttpPost("CreateQuestionSet")]
        public ActionResult CreateQuestionSet([FromBody] CreateQuestionSetRequest createQuestionSetRequest)
        {
            if (createQuestionSetRequest == null)
            {
                return BadRequest(new { message = "Question set name cannot be empty." });
            }

            var email = HttpContext.Session.GetString("UserEmail");
            if (string.IsNullOrEmpty(email))
            {
                return Unauthorized(new { message = "User not logged in" });
            }

            var user = _db.Users.FirstOrDefault(x => x.UserEmail == email);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            var data = new QuestionSet
            {
                UserID = user.UserID,
                QuestSetName = createQuestionSetRequest.QuestionSet,  // Ensure to use the correct field
            };

            _db.QuestionSets.Add(data);
            _db.SaveChanges();

            return Ok(new { message = "Question set created successfully" });
        }





        [HttpGet("GetAllQuestions/{qsid}")]
		public ActionResult<IEnumerable<Question>?> GetAllQuestions(int qsid) => _db.Questions.Where(q => q.QuestionSetID == qsid).Include(q => q.Answers).ToList();
	}
}
