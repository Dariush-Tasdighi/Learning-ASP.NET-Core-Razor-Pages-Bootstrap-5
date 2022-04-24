namespace ViewModels.FileManager.Step3
{
	public class CreateDirectory5ViewModel : object
	{
		public CreateDirectory5ViewModel() : base()
		{
		}

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Directory Name")]

		//[System.ComponentModel.DataAnnotations.Required]

		//[System.ComponentModel.DataAnnotations.Required
		//	(AllowEmptyStrings = false)]

		//[System.ComponentModel.DataAnnotations.Required
		//	(AllowEmptyStrings = false,
		//	ErrorMessage = "You did not specify direcotry name!")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		//[System.ComponentModel.DataAnnotations.StringLength
		//	(maximumLength: 20,
		//	MinimumLength = 2,
		//	ErrorMessage = "The string length of Directory Name should be min. 2 and max 20 chars!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20,
			MinimumLength = 2,
			ErrorMessage = "The string length of {0} should be min. {2} and max {1} chars!")]
		public string? DirectoryName { get; set; }
		// **********
	}
}
