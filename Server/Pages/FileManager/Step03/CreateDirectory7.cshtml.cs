namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel7 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel7() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.Pages.FileManager.Step03.CreateDirectory7ViewModel ViewModel { get; set; }

		public void OnGet()
		{
		}

		public void OnPost()
		{
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			if (ModelState.IsValid == false)
			{
				return;
			}

			// **************************************************
			AddPageError(message: null);
			AddPageError(message: string.Empty);
			AddPageError(message: "               ");

			AddPageError(message: "     Error     Message     (1)     ");

			AddPageError(message: "Error Message (2)");
			AddPageError(message: "Error Message (3)");

			AddPageError(message: "Error Message (3)");
			// **************************************************

			// **************************************************
			AddPageWarning(message: null);
			AddPageWarning(message: string.Empty);
			AddPageWarning(message: "               ");

			AddPageWarning(message: "     Warning     Message     (1)     ");

			AddPageWarning(message: "Warning Message (2)");
			AddPageWarning(message: "Warning Message (3)");

			AddPageWarning(message: "Warning Message (3)");
			// **************************************************

			// **************************************************
			AddPageSuccess(message: null);
			AddPageSuccess(message: string.Empty);
			AddPageSuccess(message: "               ");

			AddPageSuccess(message: "     Success     Message     (1)     ");

			AddPageSuccess(message: "Success Message (2)");
			AddPageSuccess(message: "Success Message (3)");

			AddPageSuccess(message: "Success Message (3)");
			// **************************************************

			return;
		}
	}
}
