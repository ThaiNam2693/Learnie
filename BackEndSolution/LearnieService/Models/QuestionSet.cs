using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LearnieService.Models
{
	public class QuestionSet
	{
		[Key]
		public int QuestionSetID { get; set; }

		[Required]
		public string QuestSetName { get; set; }

		[ForeignKey("User")]
		public int UserID { get; set; }

		public User CreatedBy { get; set; }

		[JsonIgnore]
		public virtual ICollection<Note>? Note { get; set; }

		[JsonIgnore]
		public ICollection<Question> Questions { get; set; }

		[DataType(DataType.Date)]
		public DateOnly CreatedAt { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
	}
}
