using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Server.ViewModels.Pages.FileManager.Step03;

namespace Server.Pages.FileManager.Step03;

public class CreateDirectoryModel3 : BasePageModel
{
	public CreateDirectoryModel3() : base()
	{
		ViewModel = new();
	}

	[BindProperty]
	public CreateDirectory3ViewModel ViewModel { get; set; }

	public void OnGet()
	{
		ViewModel.DirectoryName = "Test";
	}

	public void OnPost()
	{
	}
}
