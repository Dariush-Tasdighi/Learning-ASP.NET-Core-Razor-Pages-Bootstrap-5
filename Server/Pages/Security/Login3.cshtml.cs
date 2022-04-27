namespace Server.Pages.Security
{
	public class Login3Model : Infrastructure.BasePageModel
	{
		public Login3Model() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.Security.Login2ViewModel ViewModel { get; set; }

		public void OnGet()
		{
		}

		public void OnPost()
		{
		}
	}
}
