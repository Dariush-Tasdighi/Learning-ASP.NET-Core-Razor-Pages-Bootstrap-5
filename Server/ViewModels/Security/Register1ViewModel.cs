namespace ViewModels.Security
{
	public class Register1ViewModel : object
	{
		public Register1ViewModel() : base()
		{
		}

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Username")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20,
			MinimumLength = 6,
			ErrorMessage = "The string length of {0} should be min. {2} and max {1} chars!")]
		public string? Username { get; set; }
		// **********

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Password")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20,
			MinimumLength = 8,
			ErrorMessage = "The string length of {0} should be min. {2} and max {1} chars!")]

		[System.ComponentModel.DataAnnotations.DataType
			(dataType: System.ComponentModel.DataAnnotations.DataType.Password)]
		public string? Password { get; set; }
		// **********

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Confirm Password")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.DataType
			(dataType: System.ComponentModel.DataAnnotations.DataType.Password)]

		// New
		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: nameof(Password),
			ErrorMessage = "The {0} value is not equql to {1} value!")]
		public string? ConfirmPassword { get; set; }
		// **********

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Email Address")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250,
			MinimumLength = 5,
			ErrorMessage = "The string length of {0} should be min. {2} and max {1} chars!")]

		//[System.ComponentModel.DataAnnotations.DataType
		//	(dataType: System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
		public string? EmailAddress { get; set; }
		// **********
	}
}
