namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel4 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel4() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step03.CreateDirectory4ViewModel ViewModel { get; set; }

		public void OnGet()
		{
			ViewModel.DirectoryName = null;
		}

		public void OnPost()
		{
			if (string.IsNullOrWhiteSpace(ViewModel.DirectoryName))
			{
				// Error!
			}

			// Do Something...
		}
	}
}
