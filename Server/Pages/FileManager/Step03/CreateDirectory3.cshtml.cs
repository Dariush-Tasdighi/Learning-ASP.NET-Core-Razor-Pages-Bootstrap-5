namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel3 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel3() : base()
		{
			ViewModel = new();
		}

		public void OnGet()
		{
			ViewModel.DirectoryName = "Test";
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step3.CreateDirectory3ViewModel ViewModel { get; set; }

		public void OnPost()
		{
		}
	}
}
