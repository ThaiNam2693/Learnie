using System.ComponentModel.DataAnnotations;

namespace LearnieService.DTOs
{
	public class UserModelForRegister
	{
		[EmailAddress]
		public string UserEmail { get; set; }

		[MinLength(8)]
		public string UserPassword { get; set; }
	}
}
