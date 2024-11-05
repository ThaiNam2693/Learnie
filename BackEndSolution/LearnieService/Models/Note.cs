using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LearnieService.Models
{
	public class Note
	{
		[Key]
		public int NoteID { get; set; }

		public string NoteContent { get; set; }

		public string UserEmail { get; set; }

		[ForeignKey("QuestionSet")]
		public int QuestionSetID { get; set; }

		[JsonIgnore]
		public QuestionSet QuestionSet { get; set; }
	}
}
