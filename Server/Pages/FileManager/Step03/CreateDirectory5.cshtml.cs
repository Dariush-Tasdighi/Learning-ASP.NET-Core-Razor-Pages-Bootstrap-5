using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Server.ViewModels.Pages.FileManager.Step03;

namespace Server.Pages.FileManager.Step03;

public class CreateDirectoryModel5 : BasePageModel
{
	public CreateDirectoryModel5() : base()
	{
		ViewModel = new();
	}

	[BindProperty]
	public CreateDirectory5ViewModel ViewModel { get; set; }
	//public CreateDirectory5ViewModel ViewModel { get; set; } = new();

	public void OnGet()
	{
		ViewModel.DirectoryName = null;
	}

	//public void OnPost()
	//{
	//	if (ModelState.IsValid == false)
	//	{
	//		return;
	//	}

	//	// Do Something...
	//}

	public IActionResult OnPost()
	{
		// یک بار هم با غیر فعال کردن
		// Client Validation
		// این کد را تست کنید
		if (ModelState.IsValid == false)
		{
			return Page();
		}

		return RedirectToPage(pageName: "Index");
	}
}
