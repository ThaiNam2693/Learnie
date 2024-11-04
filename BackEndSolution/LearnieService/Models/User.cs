using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LearnieService.Models
{
	public class User
	{
		[Key]
		public int UserID { get; set; }

		[EmailAddress]
		[Required]
		public string UserEmail { get; set; }

		[Required]
		public string UserPassword { get; set; }

		public string? Fullname { get; set; }

		[DataType(DataType.DateTime)]
		public string? Birthday { get; set; }

		public bool Subcription { get; set; } = false;

		public DateOnly SubcriptionStartAt { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);

		public DateOnly SubcriptionExpiredAt { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);

		[JsonIgnore]
		public ICollection<QuestionSet>? QuestionSets { get; set; }

		[JsonIgnore]
		public ICollection<Order>? Orders { get; set; }

		[JsonIgnore]
		public ICollection<Note>? Notes { get; set; }
	}
}
