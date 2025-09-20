using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Server.Pages.FileManager.Step03;

public class DoSomethingModel : BasePageModel
{
	public DoSomethingModel() : base()
	{
	}

	public IActionResult OnGet()
	{
		// **************************************************
		var errorMessages = new List<string>();

		errorMessages.Add(item: "Error Message");

		// کار نمی‌کند Redirect در زمان
		ViewData["ErrorMessages"] = errorMessages;
		// **************************************************

		// **************************************************
		//var errorMessages = new List<string>();

		//errorMessages.Add(item: "Error Message");

		//TempData["ErrorMessages"] = errorMessages;
		// **************************************************

		// **************************************************
		//AddErrorMessage(message: "Error Message");
		//AddWarningMessage(message: "Warning Message");
		//AddSuccessMessage(message: "Success Message");
		// **************************************************

		return RedirectToPage(pageName: "CreateDirectory7");
	}
}
