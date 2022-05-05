namespace ViewModels.FileManager.Step03
{
	public class CreateDirectory9ViewModel : object
	{
		public CreateDirectory9ViewModel() : base()
		{
		}

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Directory Name")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20,
			MinimumLength = 2,
			ErrorMessage = "The string length of {0} should be min. {2} and max {1} chars!")]
		public string? DirectoryName { get; set; }
		// **********
	}
}
