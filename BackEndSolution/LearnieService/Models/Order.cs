using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LearnieService.Models
{
	public class Order
	{
		[Key]
		public int OrderID { get; set; }

		[Required]
		public double OrderPrice { get; set; }

		public DateTime OrderDate { get; set; } = DateTime.UtcNow;

		[ForeignKey("User")]
		public int UserID { get; set; }

		[JsonIgnore]
		public User User { get; set; }
	}
}
