using System.IO;
using System.Linq;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Hosting;

namespace Server.Pages.FileManager.Step02;

public class IndexModel : BasePageModel
{
	public IndexModel(IHostEnvironment hostEnvironment) : base()
	{
		DisplayDateTimeFormat = "yyyy/MM/dd [HH:mm:ss]";
		RootRelativePageAddress = "/FileManager/Step02/Index";
		PhysicalRootPath = $@"{hostEnvironment.ContentRootPath}\wwwroot";

		CurrentPath = "/";
		PhysicalCurrentPath = PhysicalRootPath;
	}

	public string PhysicalRootPath { get; init; }
	public string DisplayDateTimeFormat { get; init; }
	public string RootRelativePageAddress { get; init; }

	public string CurrentPath { get; set; }
	public string PhysicalCurrentPath { get; set; }
	public IList<FileInfo> Files { get; set; } = [];
	public IList<DirectoryInfo> Directories { get; set; } = [];

	public IActionResult OnGet(string? path = null)
	{
		var result = CheckPathAndSetCurrentPath(path: path);

		SetDirectoriesAndFiles();

		if (result == false)
		{
			return LocalRedirect(localUrl: RootRelativePageAddress);
		}

		return Page();
	}

	public bool CheckPathAndSetCurrentPath(string? path)
	{
		var fixedPath = "/";

		if (!string.IsNullOrWhiteSpace(value: path))
		{
			fixedPath = path.Replace(oldValue: @"\", newValue: "/");

			if (!fixedPath.StartsWith(value: "/"))
			{
				fixedPath = $"/{fixedPath}";
			}

			if (!fixedPath.EndsWith(value: "/"))
			{
				fixedPath = $"{fixedPath}/";
			}

			while (fixedPath.Contains(value: "//"))
			{
				fixedPath = fixedPath.Replace(oldValue: "//", newValue: "/");
			}
		}

		CurrentPath = fixedPath;

		PhysicalCurrentPath =
			$"{PhysicalRootPath}{CurrentPath}"
			.Replace(oldValue: "/", newValue: @"\");

		if (Directory.Exists(path: PhysicalCurrentPath) == false)
		{
			CurrentPath = "/";
			PhysicalCurrentPath = PhysicalRootPath;

			return false;
		}

		return true;
	}

	public void SetDirectoriesAndFiles()
	{
		var directoryInfo =
			new DirectoryInfo(path: PhysicalCurrentPath);

		Files =
			[.. directoryInfo.GetFiles()
			.OrderBy(current => current.Extension)
			.ThenBy(current => current.Name)];

		Directories =
			[.. directoryInfo.GetDirectories()
			.OrderBy(current => current.Name)];
	}
}
