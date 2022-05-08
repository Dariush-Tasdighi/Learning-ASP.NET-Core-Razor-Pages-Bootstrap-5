using System.Linq;

namespace Infrastructure
{
	/// <summary>
	/// Version 2.0
	/// </summary>
	public abstract class BasePageModel :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public enum MessageType : byte
		{
			PageError,
			PageWarning,
			PageSuccess,

			ToastError,
			ToastWarning,
			ToastSuccess,
		}

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

		private bool AddMessage(string key, string? message)
		{
			message =
				FixText(text: message);

			if (message == null)
			{
				return false;
			}

			// **************************************************
			// به دلایل خیلی زیادی، کد ذیل به صورتی که ملاحظه می‌کنید
			// نوشته شده است، لذا در آن هیچ‌گونه تغییری اعمال نکنید
			// **************************************************
			System.Collections.Generic.List<string>? list;

			var tempDataItems =
				(TempData[key: key] as
				System.Collections.Generic.IList<string>);

			if (tempDataItems == null)
			{
				list = new System.Collections.Generic.List<string>();
			}
			else
			{
				list =
					tempDataItems as
					System.Collections.Generic.List<string>;

				if (list == null)
				{
					list = tempDataItems.ToList();
				}
			}

			TempData[key: key] = list;
			// **************************************************

			if (list.Contains(item: message))
			{
				return false;
			}

			list.Add(item: message);

			return true;
		}

		public bool AddMessage(MessageType type, string? message)
		{
			return AddMessage(key: type.ToString(), message: message);
		}

		public bool AddPageError(string? message)
		{
			return AddMessage
				(key: MessageType.PageError.ToString(), message: message);
		}

		public bool AddPageWarning(string? message)
		{
			return AddMessage
				(key: MessageType.PageWarning.ToString(), message: message);
		}

		public bool AddPageSuccess(string? message)
		{
			return AddMessage
				(key: MessageType.PageSuccess.ToString(), message: message);
		}

		public bool AddToastError(string? message)
		{
			return AddMessage
				(key: MessageType.ToastError.ToString(), message: message);
		}

		public bool AddToastWarning(string? message)
		{
			return AddMessage
				(key: MessageType.ToastWarning.ToString(), message: message);
		}

		public bool AddToastSuccess(string? message)
		{
			return AddMessage
				(key: MessageType.ToastSuccess.ToString(), message: message);
		}
	}
}
