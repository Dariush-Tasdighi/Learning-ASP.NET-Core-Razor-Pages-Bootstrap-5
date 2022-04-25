﻿using System.Linq;

namespace Server.Pages.FileManager.Step05
{
	public class UploadFile0 : Infrastructure.BasePageModel
	{
		public UploadFile0() : base()
		{
		}

		public void OnGet()
		{
		}

		//public void OnPost(Microsoft.AspNetCore.Http.IFormFile? file)

		public async System.Threading.Tasks.Task
			OnPostAsync(Microsoft.AspNetCore.Http.IFormFile? file)
		{
			try
			{
				if (file == null)
				{
					var errorMessage =
						"You did not specify any file for uploading!";

					AddErrorToast(message: errorMessage);

					return;
				}

				var fileName =
					file.FileName
					.Trim()
					.Replace(" ", "_");

				if (file.Length == 0)
				{
					var errorMessage =
						string.Format("File '{0}' did not uploaded successfully!", fileName);

					AddErrorToast(message: errorMessage);

					return;
				}

				// https://www.sitepoint.com/mime-types-complete-list/

				//switch (file.ContentType.ToLower())
				//{
				//	case "image/png": // PNG
				//	case "application/pdf": // PDF
				//	case "image/jpeg": // JPG, JPEG
				//	{
				//		break;
				//	}

				//	// "application/x-msdownload" // EXE, DLL
				//	default:
				//	{
				//		// Error!

				//		return;
				//	}
				//}

				var fileExtension =
					System.IO.Path.GetExtension(path: fileName)?.ToLower();

				if (fileExtension == null)
				{
					var errorMessage =
						string.Format("File '{0}' should have extension!", fileName);

					AddErrorToast(message: errorMessage);

					return;
				}

				//switch (fileExtension)
				//{
				//	case ".pdf":
				//	case ".png":
				//	case ".jpg":
				//	case ".jpeg":
				//	{
				//		break;
				//	}

				//	default:
				//	{
				//		// Error!

				//		return;
				//	}
				//}

				// می‌خوانیم Application Settings که البته در پروژه واقعی، مقدار ذیل را از 
				var permittedFileExtensions =
					new string[]
					{ ".mp3", ".mp4", ".pdf", ".zip", ".rar", ".doc", ".docx", "ico", "png", "jpg", "jpeg", "bmp" };

				if (permittedFileExtensions.ToList().Contains(item: fileExtension) == false)
				{
					var errorMessage =
						string.Format("The extension of file '{0}' does not support!", fileName);

					AddErrorToast(message: errorMessage);

					return;
				}

				var physicalPathName =
					$"C:\\Temp\\{fileName}";

				if (System.IO.Directory.Exists(path: physicalPathName))
				{
					var errorMessage =
						string.Format("File '{0}' already exists!", fileName);

					AddErrorToast(message: errorMessage);

					return;
				}

				using (var stream = System.IO.File.Create(path: physicalPathName))
				{
					await file.CopyToAsync(target: stream);

					await stream.FlushAsync();

					stream.Close();
				}

				var successMessage =
					string.Format("File '{0}' uploaded successfully.", fileName);

				AddSuccessToast(message: successMessage);
			}
			catch (System.Exception ex)
			{
				AddErrorToast(message: ex.Message);
			}
		}
	}
}
