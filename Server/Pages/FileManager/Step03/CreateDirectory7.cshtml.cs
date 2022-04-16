namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel7 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel7() : base()
		{
			ViewModel = new();
		}

		public void OnGet()
		{
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step3.CreateDirectory7ViewModel ViewModel { get; set; }

		public void OnPost()
		{
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			if (ModelState.IsValid == false)
			{
				return;
			}

			// **************************************************
			AddErrorMessage(message: null);
			AddErrorMessage(message: string.Empty);
			AddErrorMessage(message: "               ");

			AddErrorMessage(message: "     Error     Message     (1)     ");

			AddErrorMessage(message: "Error Message (2)");
			AddErrorMessage(message: "Error Message (3)");

			AddErrorMessage(message: "Error Message (3)");
			// **************************************************

			// **************************************************
			AddWarningMessage(message: null);
			AddWarningMessage(message: string.Empty);
			AddWarningMessage(message: "               ");

			AddWarningMessage(message: "     Warning     Message     (1)     ");

			AddWarningMessage(message: "Warning Message (2)");
			AddWarningMessage(message: "Warning Message (3)");

			AddWarningMessage(message: "Warning Message (3)");
			// **************************************************

			// **************************************************
			AddSuccessMessage(message: null);
			AddSuccessMessage(message: string.Empty);
			AddSuccessMessage(message: "               ");

			AddSuccessMessage(message: "     Success     Message     (1)     ");

			AddSuccessMessage(message: "Success Message (2)");
			AddSuccessMessage(message: "Success Message (3)");

			AddSuccessMessage(message: "Success Message (3)");
			// **************************************************

			return;
		}
	}
}
