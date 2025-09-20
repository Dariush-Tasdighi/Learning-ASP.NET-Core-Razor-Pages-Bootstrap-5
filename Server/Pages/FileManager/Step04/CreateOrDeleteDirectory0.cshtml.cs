using Infrastructure;
using System.Threading;

namespace Server.Pages.FileManager.Step04;

public class CreateOrDeleteDirectory0 : BasePageModel
{
	public CreateOrDeleteDirectory0() : base()
	{
	}

	public void OnGet()
	{
	}

	public void OnPost(string? directoryName)
	{
		Thread.Sleep(millisecondsTimeout: 5000);

		if (string.IsNullOrWhiteSpace(value: directoryName))
		{
			AddToastError(message: "You did not specify directory name!");

			return;
		}
	}

	/// <summary>
	/// Delete -> OnPostDelete
	/// </summary>
	public void OnPostDelete(string? directoryName)
	{
		Thread.Sleep(millisecondsTimeout: 5000);

		if (string.IsNullOrWhiteSpace(value: directoryName))
		{
			AddToastError(message: "You did not specify directory name!");

			return;
		}
	}
}
