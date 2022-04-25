namespace Server.Pages.FileManager.Step04
{
	public class CreateOrDeleteDirectory0 : Infrastructure.BasePageModel
	{
		public CreateOrDeleteDirectory0() : base()
		{
		}

		public void OnGet()
		{
		}

		public void OnPost(string directoryName)
		{
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			if(string.IsNullOrWhiteSpace(directoryName))
			{
				AddErrorToast("You did not specify directory name!");

				return;
			}
		}

		public void OnPostDelete(string directoryName)
		{
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			if (string.IsNullOrWhiteSpace(directoryName))
			{
				AddErrorToast("You did not specify directory name!");

				return;
			}
		}
	}
}
