using System.Linq;
using Infrastructure;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Server.Pages.FileManager.Step05;

[RequestSizeLimit(bytes: 104_857_600)]
public class UploadFile1 : BasePageModel
{
	public UploadFile1() : base()
	{
	}

	public void OnGet()
	{
	}

	// Note: In Web.config (For Example: 100 MB = 100 * 1024 * 1024 KB)

	//	<configuration>
	//		<system.webServer>
	//			<security>
	//				<requestFiltering>
	//					<requestLimits maxAllowedContentLength="104857600" />
	//				</requestFiltering>
	//			</security>
	//		</system.webServer>
	//	</configuration>

	// کار نمی‌کند Razor Pages در
	//[Microsoft.AspNetCore.Mvc.RequestFormLimits(MultipartBodyLengthLimit = 104_857_600)]
	public async Task OnPostAsync(bool overwriteIfFileExists, IFormFile? file)
	{
		try
		{
			await CheckFileValidationAndSaveAsync
				(overwriteIfFileExists: overwriteIfFileExists, file: file);
		}
		catch (System.Exception ex)
		{
			AddToastError
				(message: ex.Message);
		}
	}

	private async Task<bool> CheckFileValidationAndSaveAsync(bool overwriteIfFileExists, IFormFile? file)
	{
		var result = CheckFileValidation(file: file);

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

		if (overwriteIfFileExists == false)
		{
			if (System.IO.File.Exists(path: physicalPathName))
			{
				var errorMessage = string.Format
					("File '{0}' already exists!", fileName);

				AddToastError
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

			AddToastSuccess
				(message: successMessage);
		}
		else
		{
			var successMessage = string.Format
				("File '{0}' with the name of '{1}' uploaded successfully.",
				file.FileName, fileName);

			AddToastSuccess
				(message: successMessage);
		}

		return true;
	}

	private bool CheckFileValidation(IFormFile? file)
	{
		if (file == null)
		{
			var errorMessage =
				"You did not specify any file for uploading!";

			AddToastError
				(message: errorMessage);

			return false;
		}

		if (file.Length == 0)
		{
			var errorMessage = string.Format
				("File '{0}' did not uploaded successfully!", file.FileName);

			AddToastError
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

			AddToastError
				(message: errorMessage);

			return false;
		}

		var permittedFileExtensions = new string[]
			{ ".mp3", ".mp4", ".pdf", ".zip", ".rar", ".doc", ".docx", ".ico", ".png", ".jpg", ".jpeg", ".bmp", ".txt" };

		if (permittedFileExtensions.ToList().Contains(item: fileExtension) == false)
		{
			var errorMessage = string.Format
				("Site does not support file '{0}' extension!", file.FileName);

			AddToastError
				(message: errorMessage);

			return false;
		}

		return true;
	}
}
