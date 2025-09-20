using System.ComponentModel.DataAnnotations;

namespace Server.ViewModels.Pages.FileManager.Step04;

public class CreateOrDeleteDirectory1ViewModel : object
{
	[Display(Name = "Directory Name")]
	[Required(AllowEmptyStrings = false,
		ErrorMessage = "You did not specify {0}!")]
	[StringLength(maximumLength: 20, MinimumLength = 2,
		ErrorMessage = "The string length of {0} should be min. {2} and max {1} chars!")]
	public string? DirectoryName { get; set; }
}
