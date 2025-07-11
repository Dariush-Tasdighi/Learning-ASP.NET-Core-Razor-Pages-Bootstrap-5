namespace Server.ViewModels.Pages.Security
{
	public class Register1ViewModel : object
	{
		public Register1ViewModel() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Username")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20,
			ErrorMessage = "The maximum length of {0} is {1}!")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Infrastructure.RegularExpression.Username,
			ErrorMessage = "{0} is not valid!")]
		public string? Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Password")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20,
			ErrorMessage = "The maximum length of {0} is {1}!")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Infrastructure.RegularExpression.Password,
			ErrorMessage = "{0} is not valid!")]

		[System.ComponentModel.DataAnnotations.DataType
			(dataType: System.ComponentModel.DataAnnotations.DataType.Password)]
		public string? Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Confirm Password")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.DataType
			(dataType: System.ComponentModel.DataAnnotations.DataType.Password)]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: nameof(Password),
			ErrorMessage = "The {0} should be equql to {1}!")]
		public string? ConfirmPassword { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Email Address")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250,
			ErrorMessage = "The maximum length of {0} is {1}!")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Infrastructure.RegularExpression.EmailAddress,
			ErrorMessage = "{0} is not valid!")]

		//[System.ComponentModel.DataAnnotations.DataType
		//	(dataType: System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
		public string? EmailAddress { get; set; }
		// **********
	}
}
