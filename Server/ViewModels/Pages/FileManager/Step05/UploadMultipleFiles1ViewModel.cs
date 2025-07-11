namespace Server.ViewModels.Pages.FileManager.Step05
{
	public class UploadMultipleFiles1ViewModel : object
	{
		public UploadMultipleFiles1ViewModel() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Overwrite If File Exists")]
		public bool OverwriteIfFileExists { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Select Files")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify any files!")]
		public System.Collections.Generic.IList<Microsoft.AspNetCore.Http.IFormFile>? Files { get; set; }
		// **********
	}
}
