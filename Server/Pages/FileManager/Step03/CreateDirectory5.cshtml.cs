namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel5 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel5() : base()
		{
			ViewModel = new();
		}

		public void OnGet()
		{
			ViewModel.DirectoryName = "Test";
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step3.CreateDirectory5ViewModel ViewModel { get; set; }

		//public void OnPost()
		//{
		//	if (ModelState.IsValid == false)
		//	{
		//		return;
		//	}

		//	// Do Something...
		//}

		public Microsoft.AspNetCore.Mvc.IActionResult OnPost()
		{
			if (ModelState.IsValid == false)
			{
				return Page();
			}

			return RedirectToPage(pageName: "Index");
		}
	}
}
