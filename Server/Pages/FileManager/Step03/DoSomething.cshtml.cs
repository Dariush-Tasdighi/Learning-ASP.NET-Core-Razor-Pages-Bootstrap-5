namespace Server.Pages.FileManager.Step03
{
	public class DoSomethingModel : Infrastructure.BasePageModel
	{
		public DoSomethingModel() : base()
		{
		}

		public Microsoft.AspNetCore.Mvc.IActionResult OnGet()
		{
			// **************************************************
			var errorMessages =
				new System.Collections.Generic.List<string>();

			errorMessages.Add(item: "Error Message");

			// کار نمی‌کند Redirect در زمان
			ViewData["ErrorMessages"] = errorMessages;
			// **************************************************

			// **************************************************
			//var errorMessages =
			//	new System.Collections.Generic.List<string>();

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
}
