using System.ComponentModel.DataAnnotations;

namespace Server.ViewModels.Pages.FileManager.Step03;

public class CreateDirectory4ViewModel : object
{
	public CreateDirectory4ViewModel() : base()
	{
	}

	[Display(Name = "Directory Name")]
	public string? DirectoryName { get; set; }
}
