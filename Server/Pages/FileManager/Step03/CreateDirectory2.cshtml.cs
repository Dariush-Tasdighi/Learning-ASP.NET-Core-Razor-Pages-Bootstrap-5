using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Server.Pages.FileManager.Step03;

public class CreateDirectoryModel2 : BasePageModel
{
	public CreateDirectoryModel2() : base()
	{
	}

	/// <summary>
	/// MVC + MVVM
	/// </summary>
	[BindProperty]
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
