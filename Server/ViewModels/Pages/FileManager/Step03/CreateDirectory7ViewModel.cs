using System.ComponentModel.DataAnnotations;

namespace Server.ViewModels.Pages.FileManager.Step03;

public class CreateDirectory7ViewModel : object
{
	public CreateDirectory7ViewModel() : base()
	{
	}

	[Display(Name = "Directory Name")]
	[Required(AllowEmptyStrings = false,
		ErrorMessage = "You did not specify {0}!")]
	[StringLength(maximumLength: 20, MinimumLength = 2,
		ErrorMessage = "The string length of {0} should be min. {2} and max {1} chars!")]
	public string? DirectoryName { get; set; }
}
