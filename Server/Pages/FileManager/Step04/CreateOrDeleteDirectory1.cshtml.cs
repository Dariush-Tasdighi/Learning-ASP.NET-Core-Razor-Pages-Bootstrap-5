namespace Server.Pages.FileManager.Step04
{
	public class CreateOrDeleteDirectory1 : Infrastructure.BasePageModel
	{
		public CreateOrDeleteDirectory1() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step04.CreateOrDeleteDirectory1ViewModel ViewModel { get; set; }

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

			AddSuccessToast
				(message: "The directory has been created successfully.");
		}

		public void OnPostDelete()
		{
			System.Threading.Thread.Sleep(millisecondsTimeout: 2000);

			if (ModelState.IsValid == false)
			{
				return;
			}

			AddSuccessToast
				(message: "The directory has been deleted successfully.");
		}
	}
}
