namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel6 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel6() : base()
		{
			ViewModel = new();
		}

		public void OnGet()
		{
			ViewModel.DirectoryName = null;
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step3.CreateDirectory6ViewModel ViewModel { get; set; }

		public Microsoft.AspNetCore.Mvc.IActionResult OnPost()
		{
			if (ModelState.IsValid == false)
			{
				return Page();
			}

			ViewData["SuccessMessage"] =
				"Your directory was created successfully.";

			//return RedirectToPage(pageName: "Index");

			return Page();
		}
	}
}
