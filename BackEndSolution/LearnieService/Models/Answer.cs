using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LearnieService.Models
{
	public class Answer
	{
		[Key]
		public int AnswerID { get; set; }

		[Required]
		public int AnswerContent { get; set; }

		[Required]
		public bool IsRightAnswer { get; set; }

		[ForeignKey("Question")]
		public int QuestionID { get; set; }

		[JsonIgnore]
		public Question Question { get; set; }
	}
}
