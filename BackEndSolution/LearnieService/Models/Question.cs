using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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

		[Required]
		public int QuestionSetID { get; set; }

		[JsonIgnore]
		public QuestionSet QuestionSet { get; set; }

		public ICollection<Answer> Answers { get; set; }
	}
}
