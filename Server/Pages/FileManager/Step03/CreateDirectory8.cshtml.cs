namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel8 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel8() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step03.CreateDirectory8ViewModel ViewModel { get; set; }

		public void OnGet()
		{
		}

		public void OnPost()
		{
			System.Threading.Thread.Sleep(millisecondsTimeout: 2000);

			if (ModelState.IsValid == false)
			{
				return;
			}

			// **************************************************
			AddErrorToast(message: null);
			AddErrorToast(message: string.Empty);
			AddErrorToast(message: "               ");

			AddErrorToast(message: "     Error     Toast     (1)     ");

			AddErrorToast(message: "Error Toast (2)");
			AddErrorToast(message: "Error Toast (3)");

			AddErrorToast(message: "Error Toast (3)");
			// **************************************************

			// **************************************************
			AddWarningToast(message: null);
			AddWarningToast(message: string.Empty);
			AddWarningToast(message: "               ");

			AddWarningToast(message: "     Warning     Toast     (1)     ");

			AddWarningToast(message: "Warning Toast (2)");
			AddWarningToast(message: "Warning Toast (3)");

			AddWarningToast(message: "Warning Toast (3)");
			// **************************************************

			// **************************************************
			AddSuccessToast(message: null);
			AddSuccessToast(message: string.Empty);
			AddSuccessToast(message: "               ");

			AddSuccessToast(message: "     Success     Toast     (1)     ");

			AddSuccessToast(message: "Success Toast (2)");
			AddSuccessToast(message: "Success Toast (3)");

			AddSuccessToast(message: "Success Toast (3)");
			// **************************************************

			return;
		}
	}
}
