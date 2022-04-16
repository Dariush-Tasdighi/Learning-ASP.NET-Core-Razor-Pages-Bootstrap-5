namespace ViewModels.FileManager.Step3
{
	public class CreateDirectory4ViewModel : object
	{
		public CreateDirectory4ViewModel() : base()
		{
		}

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Directory Name")]
		public string? DirectoryName { get; set; }
		// **********
	}
}
