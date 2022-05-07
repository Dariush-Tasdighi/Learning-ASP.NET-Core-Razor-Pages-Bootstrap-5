namespace Server.Pages.Security
{
	public class Login1Model : Infrastructure.BasePageModel
	{
		public Login1Model() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.Security.Login1ViewModel ViewModel { get; set; }

		public void OnGet()
		{
		}

		public void OnPost()
		{
			if (ModelState.IsValid == false)
			{
				return;
			}
		}
	}
}
