namespace Server.Pages.Security
{
	public class Login2Model : Infrastructure.BasePageModel
	{
		public Login2Model() : base()
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
			if (ModelState.IsValid == false)
			{
				return;
			}
		}
	}
}
