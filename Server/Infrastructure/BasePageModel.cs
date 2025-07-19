using Infrastructure.Messages;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Infrastructure;

public abstract class BasePageModel : PageModel, IMessageHandler
{
	public BasePageModel() : base()
	{
	}

	public bool AddPageError(string? message)
	{
		return MessagesUtility.AddMessage
			(tempData: TempData, type: MessageType.PageError, message: message);
	}

	public bool AddPageWarning(string? message)
	{
		return MessagesUtility.AddMessage
			(tempData: TempData, type: MessageType.PageWarning, message: message);
	}

	public bool AddPageSuccess(string? message)
	{
		return MessagesUtility.AddMessage
			(tempData: TempData, type: MessageType.PageSuccess, message: message);
	}

	public bool AddToastError(string? message)
	{
		return MessagesUtility.AddMessage
			(tempData: TempData, type: MessageType.ToastError, message: message);
	}

	public bool AddToastWarning(string? message)
	{
		return MessagesUtility.AddMessage
			(tempData: TempData, type: MessageType.ToastWarning, message: message);
	}

	public bool AddToastSuccess(string? message)
	{
		return MessagesUtility.AddMessage
			(tempData: TempData, type: MessageType.ToastSuccess, message: message);
	}
}
