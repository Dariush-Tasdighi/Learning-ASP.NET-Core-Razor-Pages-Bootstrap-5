namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel2 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel2() : base()
		{
		}

		public void OnGet()
		{
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public string? DirectoryName { get; set; }

		public void OnPost()
		{
		}
	}
}
