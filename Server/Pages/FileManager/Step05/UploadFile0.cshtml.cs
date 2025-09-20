using System;
using System.IO;
using System.Linq;
using Infrastructure;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Server.Pages.FileManager.Step05;

public class UploadFile0 : BasePageModel
{
	public UploadFile0() : base()
	{
	}

	public void OnGet()
	{
	}

	/// <summary>
	/// Step (3): IFormFile? file
	/// </summary>
	//public void OnPost(IFormFile? file)
	public async Task OnPostAsync(IFormFile? file)
	{
		try
		{
			if (file is null)
			{
				var errorMessage = "You did not specify any file for uploading!";

				AddToastError(message: errorMessage);

				return;
			}

			var fileName = file.FileName.Trim()
				.Replace(oldValue: " ", newValue: "_");

			if (file.Length == 0)
			{
				//var errorMessage =
				//	$"File '{fileName}' did not uploaded successfully!";

				var errorMessage =
					string.Format("File '{0}' did not uploaded successfully!", fileName);

				AddToastError(message: errorMessage);

				return;
			}

			var fileExtension = Path.GetExtension(path: fileName)?.ToLower();

			if (fileExtension is null)
			{
				var errorMessage =
					string.Format("File '{0}' must have extension!", fileName);

				AddToastError(message: errorMessage);

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
			var permittedFileExtensions = new string[]
				{ ".mp3", ".mp4", ".pdf", ".zip", ".rar", ".doc", ".docx", ".ico", ".png", ".jpg", ".jpeg", ".bmp", ".txt" };

			if (permittedFileExtensions.ToList().Contains(item: fileExtension) == false)
			{
				var errorMessage =
					string.Format("The extension of file '{0}' is not valid!", fileName);

				AddToastError(message: errorMessage);

				return;
			}

			// https://www.sitepoint.com/mime-types-complete-list/

			switch (file.ContentType.ToLower())
			{
				case "image/png": // PNG
				case "application/pdf": // PDF
				case "image/jpeg": // JPG, JPEG
				{
					break;
				}

				// "application/x-msdownload" // EXE, DLL
				default:
				{
					// Error!

					return;
				}
			}

			var physicalPathName = $"C:\\Temp\\{fileName}";

			if (System.IO.File.Exists(path: physicalPathName))
			{
				var errorMessage =
					string.Format("File '{0}' already exists!", fileName);

				AddToastError(message: errorMessage);

				return;
			}

			using var stream = System.IO.File.Create(path: physicalPathName);

			await file.CopyToAsync(target: stream);

			await stream.FlushAsync();

			var successMessage =
				string.Format("File '{0}' uploaded successfully.", fileName);

			AddToastSuccess(message: successMessage);
		}
		catch (Exception ex)
		{
			AddToastError(message: ex.Message);
		}
	}
}
