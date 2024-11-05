using AutoMapper;
using LearnieService.DTOs;
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

		[HttpGet("GetAllQuestionSets/{Email}")]
		public ActionResult<IEnumerable<QuestionSet>?> GetAllQuestionSets(string Email) {
			var user = _db.Users.FirstOrDefault(x => x.UserEmail == Email);
			var list = _db.QuestionSets.Where(x => x.UserID == user.UserID).ToList();
			return list;
		}

		[HttpPost("CreateQuestionSet")]
		public ActionResult CreateQuestionSet(QuestionSetDTO questionSet)
		{
			var user = _db.Users.FirstOrDefault(x => x.UserEmail == questionSet.Email);
			QuestionSet data = new QuestionSet
			{
				UserID = user.UserID,
				QuestSetName = questionSet.QuestSetName
			};
			_db.QuestionSets.Add(data);
			_db.SaveChanges();
			return Ok();
		}

		[HttpGet("GetAllQuestions/{qsid}")]
		public ActionResult<IEnumerable<Question>?> GetAllQuestions(int qsid) => _db.Questions.Where(q => q.QuestionSetID == qsid).Include(q => q.Answers).ToList();
	}
}
