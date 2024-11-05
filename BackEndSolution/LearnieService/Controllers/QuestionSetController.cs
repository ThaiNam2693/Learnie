using AutoMapper;
using LearnieService.LearnieDbContext;
using LearnieService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
		public ActionResult<IEnumerable<QuestionSet>?> GetAllQuestionSets() => _db.QuestionSets.ToList();

		[HttpGet("GetAllQuestions/{qsid}")]
		public ActionResult<IEnumerable<Question>?> GetAllQuestions(int qsid) => _db.Questions.Where(q => q.QuestionSetID == qsid).Include(q => q.Answers).ToList();

		[HttpPost("CreateQuestionSet")]
		public IActionResult CreateQuestionSet(QuestionSet questionSet) 
		{
			return Ok();
		}
	}
}
