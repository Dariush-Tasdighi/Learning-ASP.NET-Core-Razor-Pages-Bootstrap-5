namespace ViewModels.FileManager.Step03
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
