namespace Server.Pages.FileManager.Step03
{
	public class DoSomethingModel : Infrastructure.BasePageModel
	{
		public DoSomethingModel() : base()
		{
		}

		public Microsoft.AspNetCore.Mvc.IActionResult OnGet()
		{
			AddErrorMessage(message: "Error Message");
			AddWarningMessage(message: "Warning Message");
			AddSuccessMessage(message: "Success Message");

			return RedirectToPage(pageName: "CreateDirectory7");
		}
	}
}
