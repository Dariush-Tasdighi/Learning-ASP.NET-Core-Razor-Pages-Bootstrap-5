namespace Infrastructure;

public static class Utility : object
{
	public static string? FixText(string? text)
	{
		if (string.IsNullOrWhiteSpace(value: text))
		{
			return null;
		}

		text = text.Trim();

		while (text.Contains(value: "  "))
		{
			text = text.Replace(oldValue: "  ", newValue: " ");
		}

		return text;
	}
}
