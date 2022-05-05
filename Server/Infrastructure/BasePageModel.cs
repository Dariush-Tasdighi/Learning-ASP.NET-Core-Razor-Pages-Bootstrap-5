namespace Infrastructure
{
	public abstract class BasePageModel :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public static readonly string ErrorToastsKeyName = "ErrorToasts";
		public static readonly string WarningToastsKeyName = "WarningToasts";
		public static readonly string SuccessToastsKeyName = "SuccessToasts";

		public static readonly string ErrorMessagesKeyName = "ErrorMessages";
		public static readonly string WarningMessagesKeyName = "WarningMessages";
		public static readonly string SuccessMessagesKeyName = "SuccessMessages";

		public BasePageModel() : base()
		{
		}

		public string? FixText(string? text)
		{
			if (string.IsNullOrWhiteSpace(text))
			{
				return null;
			}

			text =
				text.Trim();

			while (text.Contains("  "))
			{
				text =
					text.Replace("  ", " ");
			}

			return text;
		}

		public bool AddErrorMessage(string? message)
		{
			message =
				FixText(text: message);

			if (message == null)
			{
				return false;
			}

			//var list =
			//	ViewData["ErrorMessages"] as
			//	System.Collections.Generic.IList<string>;

			//var list =
			//	ViewData[index: ErrorMessagesKeyName] as
			//	System.Collections.Generic.IList<string>;

			var list =
				TempData[key: ErrorMessagesKeyName] as
				System.Collections.Generic.IList<string>;

			if (list == null)
			{
				list =
					new System.Collections.Generic.List<string>();

				//ViewData[index: ErrorMessagesKeyName] = list;

				TempData[key: ErrorMessagesKeyName] = list;
			}

			if (list.Contains(item: message))
			{
				return false;
			}

			list.Add(item: message);

			return true;
		}

		public bool AddWarningMessage(string? message)
		{
			message =
				FixText(text: message);

			if (message == null)
			{
				return false;
			}

			var list =
				TempData[key: WarningMessagesKeyName] as
				System.Collections.Generic.IList<string>;

			if (list == null)
			{
				list =
					new System.Collections.Generic.List<string>();

				TempData[key: WarningMessagesKeyName] = list;
			}

			if (list.Contains(item: message))
			{
				return false;
			}

			list.Add(item: message);

			return true;
		}

		public bool AddSuccessMessage(string? message)
		{
			message =
				FixText(text: message);

			if (message == null)
			{
				return false;
			}

			var list =
				TempData[key: SuccessMessagesKeyName] as
				System.Collections.Generic.IList<string>;

			if (list == null)
			{
				list =
					new System.Collections.Generic.List<string>();

				TempData[key: SuccessMessagesKeyName] = list;
			}

			if (list.Contains(item: message))
			{
				return false;
			}

			list.Add(item: message);

			return true;
		}

		public bool AddErrorToast(string? message)
		{
			message =
				FixText(text: message);

			if (message == null)
			{
				return false;
			}

			var list =
				TempData[key: ErrorToastsKeyName] as
				System.Collections.Generic.IList<string>;

			if (list == null)
			{
				list =
					new System.Collections.Generic.List<string>();

				TempData[key: ErrorToastsKeyName] = list;
			}

			if (list.Contains(item: message))
			{
				return false;
			}

			list.Add(item: message);

			return true;
		}

		public bool AddWarningToast(string? message)
		{
			message =
				FixText(text: message);

			if (message == null)
			{
				return false;
			}

			var list =
				TempData[key: WarningToastsKeyName] as
				System.Collections.Generic.IList<string>;

			if (list == null)
			{
				list =
					new System.Collections.Generic.List<string>();

				TempData[key: WarningToastsKeyName] = list;
			}

			if (list.Contains(item: message))
			{
				return false;
			}

			list.Add(item: message);

			return true;
		}

		public bool AddSuccessToast(string? message)
		{
			message =
				FixText(text: message);

			if (message == null)
			{
				return false;
			}

			var list =
				TempData[key: SuccessToastsKeyName] as
				System.Collections.Generic.IList<string>;

			if (list == null)
			{
				list =
					new System.Collections.Generic.List<string>();

				TempData[key: SuccessToastsKeyName] = list;
			}

			if (list.Contains(item: message))
			{
				return false;
			}

			list.Add(item: message);

			return true;
		}

		public Messages Messages
		{
			get
			{
				var messages =
					TempData[key: Messages.KeyName] as Messages;

				if (messages == null)
				{
					messages = new();

					TempData[key: Messages.KeyName] = messages;
				}

				return messages;
			}
		}
	}
}
