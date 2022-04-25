namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel6 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel6() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step03.CreateDirectory6ViewModel ViewModel { get; set; }

		public void OnGet()
		{
			ViewModel.DirectoryName = null;
		}

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
