using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Server.ViewModels.Pages.FileManager.Step03;

namespace Server.Pages.FileManager.Step03;

public class CreateDirectoryModel6 : BasePageModel
{
	public CreateDirectoryModel6() : base()
	{
		ViewModel = new();
	}

	[BindProperty]
	public CreateDirectory6ViewModel ViewModel { get; set; }

	public void OnGet()
	{
	}

	public void OnPost()
	{
		if (ModelState.IsValid == false)
		{
			ViewData["ErrorMessage"] = "Your directory was not created!";

			return;
		}

		ViewData["SuccessMessage"] = "Your directory was created successfully.";

		//return RedirectToPage(pageName: "Index");

		return;
	}
}
