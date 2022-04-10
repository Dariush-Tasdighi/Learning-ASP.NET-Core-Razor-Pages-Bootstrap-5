using System.Linq;

namespace Server.Pages.FileManager.Step02
{
	public class IndexModel : Infrastructure.BasePageModel
	{
		#region Constructor
		public IndexModel
			(Microsoft.Extensions.Hosting.IHostEnvironment hostEnvironment) : base()
		{
			HostEnvironment = hostEnvironment;

			DisplayDateTimeFormat =
				"yyyy/MM/dd [HH:mm:ss]";

			PageAddress =
				"/FileManager/Step02/Index";

			PhysicalRootPath =
				$"{HostEnvironment.ContentRootPath}wwwroot";

			// بودن null برای خلاص شدن از شر اخطار
			Files = new System.Collections.Generic.List<System.IO.FileInfo>();
			Directories = new System.Collections.Generic.List<System.IO.DirectoryInfo>();
		}
		#endregion /Constructor

		#region Public Read Only Property(ies)
		public string PageAddress { get; }

		public string PhysicalRootPath { get; }

		public string DisplayDateTimeFormat { get; }

		public Microsoft.Extensions.Hosting.IHostEnvironment HostEnvironment { get; }
		#endregion /Public Read Only Property(ies)

		#region Public Property(ies)
		public string? CurrentPath { get; set; }

		public string? PhysicalCurrentPath { get; set; }

		public System.Collections.Generic.IList<System.IO.FileInfo> Files { get; set; }

		public System.Collections.Generic.IList<System.IO.DirectoryInfo> Directories { get; set; }
		#endregion /Public Property(ies)

		#region OnGet
		public void OnGet(string? path)
		{
			CheckPathAndSetCurrentPath(path: path);

			SetDirectoriesAndFiles();
		}
		#endregion /OnGet

		#region CheckPathAndSetCurrentPath
		/// <summary>
		/// قانون
		///
		/// CurrentPath:
		///		/
		///		/Images/
		///
		/// یعنی همیشه دو طرف آن / دارد
		/// </summary>
		public void CheckPathAndSetCurrentPath(string? path)
		{
			// **************************************************
			string fixedPath = "/";

			if (string.IsNullOrWhiteSpace(path) == false)
			{
				fixedPath =
					path.Replace("\\", "/");

				if (fixedPath.StartsWith("/") == false)
				{
					fixedPath =
						$"/{fixedPath}";
				}

				if (fixedPath.EndsWith("/") == false)
				{
					fixedPath =
						$"{fixedPath}/";
				}

				while (fixedPath.Contains("//"))
				{
					fixedPath =
						fixedPath.Replace("//", "/");
				}
			}
			// **************************************************

			// **************************************************
			CurrentPath = fixedPath;
			// **************************************************

			// **************************************************
			PhysicalCurrentPath =
				$"{PhysicalRootPath}{CurrentPath}"
				.Replace("/", "\\");

			if (System.IO.Directory.Exists(path: PhysicalCurrentPath) == false)
			{
				PhysicalCurrentPath = PhysicalRootPath;
			}
			// **************************************************
		}
		#endregion /CheckPathAndSetCurrentPath

		#region SetDirectoriesAndFiles
		public void SetDirectoriesAndFiles()
		{
			if (string.IsNullOrWhiteSpace(PhysicalCurrentPath) ||
				System.IO.Directory.Exists(PhysicalCurrentPath) == false)
			{
				Files = new System.Collections.Generic.List<System.IO.FileInfo>();
				Directories = new System.Collections.Generic.List<System.IO.DirectoryInfo>();

				return;
			}

			var directoryInfo =
				new System.IO.DirectoryInfo(path: PhysicalCurrentPath);

			Files =
				directoryInfo.GetFiles()
				.OrderBy(current => current.Extension)
				.ThenBy(current => current.Name)
				.ToList()
				;

			Directories =
				directoryInfo.GetDirectories()
				.OrderBy(current => current.Name)
				.ToList()
				;
		}
		#endregion /SetDirectoriesAndFiles
	}
}
