﻿namespace Infrastructure.Messages
{
	public interface IMessageHandler
	{
		bool AddPageError(string? message);

		bool AddPageWarning(string? message);

		bool AddPageSuccess(string? message);



		bool AddToastError(string? message);

		bool AddToastWarning(string? message);

		bool AddToastSuccess(string? message);



		bool AddMessage(MessageType type, string? message);
	}
}
