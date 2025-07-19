namespace Infrastructure.Messages;

public enum MessageType : byte
{
	PageError = 0,
	PageWarning = 1,
	PageSuccess = 2,

	ToastError = 10,
	ToastWarning = 11,
	ToastSuccess = 12,
}
