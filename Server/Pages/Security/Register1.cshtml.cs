namespace Server.Pages.Security
{
	public class Register1Model : Infrastructure.BasePageModel
	{
		public Register1Model() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.Security.Register1ViewModel ViewModel { get; set; }

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
