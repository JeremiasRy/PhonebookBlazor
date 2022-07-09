using System.ComponentModel.DataAnnotations;

namespace PhonebookOnceAgain.Data
{
	public class ContactDisplayModel
	{
		[Required]
		public string? Name { get; set; }
		[Required]
		[RegularExpression(@"^[0-9]{3}-[0-9]{7}|^[0-9]{2}-[0-9]{8}", ErrorMessage = "Number in incorrect form")]
		public string? Number { get; set; }

		public int Id { get; set; }

		// public bool HiddenBool { get => (Hidden == 1); }

	}
}
