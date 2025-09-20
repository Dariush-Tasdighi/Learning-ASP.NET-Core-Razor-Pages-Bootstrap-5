using Infrastructure;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Server.ViewModels.Pages.FileManager.Step04;

namespace Server.Pages.FileManager.Step04;

//[ValidateAntiForgeryToken]
public class CreateOrDeleteDirectory1 : BasePageModel
{
	public CreateOrDeleteDirectory1() : base()
	{
		ViewModel = new();
	}

	[BindProperty]
	public CreateOrDeleteDirectory1ViewModel ViewModel { get; set; }

	public void OnGet()
	{
	}

	public void OnPost()
	{
		Thread.Sleep(millisecondsTimeout: 5000);

		if (ModelState.IsValid == false)
		{
			return;
		}

		AddToastSuccess(message: "The directory has been created successfully.");
	}

	public void OnPostDelete()
	{
		Thread.Sleep(millisecondsTimeout: 5000);

		if (ModelState.IsValid == false)
		{
			return;
		}

		AddToastSuccess(message: "The directory has been deleted successfully.");
	}
}
