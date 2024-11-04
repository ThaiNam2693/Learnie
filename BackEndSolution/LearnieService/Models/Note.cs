using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

		public QuestionSet QuestionSet { get; set; }
	}
}
