namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel5 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel5() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step03.CreateDirectory5ViewModel ViewModel { get; set; }

		public void OnGet()
		{
			ViewModel.DirectoryName = null;
		}

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
			// یک بار هم با غیر فعال کردن
			// Client Validation
			// این کد را تست کنید
			if (ModelState.IsValid == false)
			{
				return Page();
			}

			return RedirectToPage(pageName: "Index");
		}
	}
}
