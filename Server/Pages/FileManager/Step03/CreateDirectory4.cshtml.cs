using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Server.ViewModels.Pages.FileManager.Step03;

namespace Server.Pages.FileManager.Step03;

public class CreateDirectoryModel4 : BasePageModel
{
	public CreateDirectoryModel4() : base()
	{
		ViewModel = new();
	}

	[BindProperty]
	public CreateDirectory4ViewModel ViewModel { get; set; }

	public void OnGet()
	{
		ViewModel.DirectoryName = null;
	}

	public void OnPost()
	{
		if (string.IsNullOrWhiteSpace(value: ViewModel.DirectoryName))
		{
			// Error!
		}

		// Do Something...
	}
}
