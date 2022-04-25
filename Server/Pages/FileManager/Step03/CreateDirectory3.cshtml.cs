namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel3 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel3() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step03.CreateDirectory3ViewModel ViewModel { get; set; }

		public void OnGet()
		{
			ViewModel.DirectoryName = "Test";
		}

		public void OnPost()
		{
		}
	}
}
