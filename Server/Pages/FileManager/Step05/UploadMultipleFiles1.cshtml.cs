using System.Linq;

namespace Server.Pages.FileManager.Step05
{
	[Microsoft.AspNetCore.Mvc.RequestSizeLimit(bytes: 104857600)]
	public class UploadMultipleFiles1 : Infrastructure.BasePageModel
	{
		public UploadMultipleFiles1() : base()
		{
			ViewModel = new();
		}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.FileManager.Step05.UploadMultipleFiles1ViewModel ViewModel { get; set; }

		public void OnGet()
		{
		}

		public async System.Threading.Tasks.Task OnPostAsync()
		{
			try
			{
				if(ModelState.IsValid == false)
				{
					return;
				}

				//if (ViewModel.Files == null || ViewModel.Files.Count == 0)
				//{
				//	var errorMessage =
				//		"You did not specify any file for uploading!";

				//	AddErrorToast
				//		(message: errorMessage);

				//	return;
				//}

				foreach (var file in ViewModel.Files!)
				{
					await CheckFileValidationAndSaveAsync
						(overrideIfFileExists: ViewModel.OverrideIfFileExists, file: file);
				}
			}
			catch (System.Exception ex)
			{
				AddErrorToast
					(message: ex.Message);
			}
		}

		private async System.Threading.Tasks.Task<bool>
			CheckFileValidationAndSaveAsync
			(bool overrideIfFileExists, Microsoft.AspNetCore.Http.IFormFile? file)
		{
			var result =
				CheckFileValidation(file: file);

			if (result == false)
			{
				return false;
			}

			var fileName =
				file!.FileName
				.Trim()
				.Replace(" ", "_");

			var physicalPathName =
				$"C:\\Temp\\{fileName}";

			if (overrideIfFileExists == false)
			{
				if (System.IO.File.Exists(path: physicalPathName))
				{
					var errorMessage = string.Format
						("File '{0}' already exists!", fileName);

					AddErrorToast
						(message: errorMessage);

					return false;
				}
			}

			using (var stream = System.IO.File.Create(path: physicalPathName))
			{
				await file.CopyToAsync(target: stream);

				await stream.FlushAsync();

				stream.Close();
			}

			if (string.Compare(file.FileName, fileName, ignoreCase: true) == 0)
			{
				var successMessage = string.Format
					("File '{0}' uploaded successfully.", fileName);

				AddSuccessToast
					(message: successMessage);
			}
			else
			{
				var successMessage = string.Format
					("File '{0}' with the name of '{1}' uploaded successfully.",
					file.FileName, fileName);

				AddSuccessToast
					(message: successMessage);
			}

			return true;
		}

		private bool CheckFileValidation
			(Microsoft.AspNetCore.Http.IFormFile? file)
		{
			if (file == null)
			{
				var errorMessage =
					"You did not specify any file for uploading!";

				AddErrorToast
					(message: errorMessage);

				return false;
			}

			if (file.Length == 0)
			{
				var errorMessage = string.Format
					("File '{0}' did not uploaded successfully!", file.FileName);

				AddErrorToast
					(message: errorMessage);

				return false;
			}

			var fileExtension =
				System.IO.Path.GetExtension
				(path: file.FileName)?.ToLower();

			if (fileExtension == null)
			{
				var errorMessage = string.Format
					("File '{0}' does not have any extension!", file.FileName);

				AddErrorToast
					(message: errorMessage);

				return false;
			}

			var permittedFileExtensions = new string[]
				{ ".mp3", ".mp4", ".pdf", ".zip", ".rar", ".doc", ".docx", ".ico", ".png", ".jpg", ".jpeg", ".bmp" };

			if (permittedFileExtensions.ToList().Contains(item: fileExtension) == false)
			{
				var errorMessage = string.Format
					("Site does not support your file '{0}' extension!", file.FileName);

				AddErrorToast
					(message: errorMessage);

				return false;
			}

			return true;
		}
	}
}
