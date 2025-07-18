using Infrastructure;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Server.ViewModels.Pages.FileManager.Step03;

namespace Server.Pages.FileManager.Step03;

public class CreateDirectoryModel8 : BasePageModel
{
	public CreateDirectoryModel8() : base()
	{
		ViewModel = new();
	}

	[BindProperty]
	public CreateDirectory8ViewModel ViewModel { get; set; }

	public void OnGet()
	{
	}

	public void OnPost()
	{
		Thread.Sleep(millisecondsTimeout: 5_000);

		if (ModelState.IsValid == false)
		{
			return;
		}

		// **************************************************
		AddToastError(message: null);
		AddToastError(message: string.Empty);
		AddToastError(message: "               ");

		AddToastError(message: "     Error     Toast     (1)     ");

		AddToastError(message: "Error Toast (2)");
		AddToastError(message: "Error Toast (3)");

		AddToastError(message: "Error Toast (3)");
		// **************************************************

		// **************************************************
		AddToastWarning(message: null);
		AddToastWarning(message: string.Empty);
		AddToastWarning(message: "               ");

		AddToastWarning(message: "     Warning     Toast     (1)     ");

		AddToastWarning(message: "Warning Toast (2)");
		AddToastWarning(message: "Warning Toast (3)");

		AddToastWarning(message: "Warning Toast (3)");
		// **************************************************

		// **************************************************
		AddToastSuccess(message: null);
		AddToastSuccess(message: string.Empty);
		AddToastSuccess(message: "               ");

		AddToastSuccess(message: "     Success     Toast     (1)     ");

		AddToastSuccess(message: "Success Toast (2)");
		AddToastSuccess(message: "Success Toast (3)");

		AddToastSuccess(message: "Success Toast (3)");
		// **************************************************

		return;
	}
}
