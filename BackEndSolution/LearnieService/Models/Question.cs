using System.ComponentModel.DataAnnotations;

namespace LearnieService.Models
{
	public class Question
	{
		[Key]
		public int QuestionID { get; set; }

		[Required]
		public string QuestionContent { get; set; }

		[Required]
		public string? QuestionDescription { get; set; }

		public ICollection<Answer> Answers { get; set; }
	}
}
