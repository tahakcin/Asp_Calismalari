using System.Collections.Concurrent;

namespace MiddleWare.Middlwares
{
	public class ConnectionMiddleware
	{
		RequestDelegate _next;
		public ConnectionMiddleware(RequestDelegate next)
		{
			_next = next;
		}
		public async Task Invoke(HttpContext context)
		{
            Console.WriteLine("Connection: " + context.Connection.Id);
            Console.WriteLine("Protocol: " + context.Request.Protocol);
			await _next(context);
            Console.WriteLine("Connection Middleware is ending...");
		}
	}
}
