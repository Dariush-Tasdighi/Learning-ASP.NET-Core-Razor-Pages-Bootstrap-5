namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel6 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel6() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.Pages.FileManager.Step03.CreateDirectory6ViewModel ViewModel { get; set; }

		public void OnGet()
		{
		}

		public void OnPost()
		{
			if (ModelState.IsValid == false)
			{
				ViewData["ErrorMessage"] =
					"Your directory was not created!";

				return;
			}

			ViewData["SuccessMessage"] =
				"Your directory was created successfully.";

			//return RedirectToPage(pageName: "Index");

			return;
		}
	}
}
