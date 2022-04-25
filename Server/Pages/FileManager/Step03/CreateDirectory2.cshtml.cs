namespace Server.Pages.FileManager.Step03
{
	public class CreateDirectoryModel2 : Infrastructure.BasePageModel
	{
		public CreateDirectoryModel2() : base()
		{
		}

		/// <summary>
		/// MVC + MVVM
		/// </summary>
		[Microsoft.AspNetCore.Mvc.BindProperty]
		public string? DirectoryName { get; set; }

		/// <summary>
		/// Handler
		/// </summary>
		public void OnGet()
		{
			DirectoryName = "Test";
		}

		/// <summary>
		/// Handler
		/// </summary>
		public void OnPost()
		{
		}
	}
}
