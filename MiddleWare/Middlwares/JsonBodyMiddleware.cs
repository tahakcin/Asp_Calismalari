namespace MiddleWare.Middlwares
{
	public class JsonBodyMiddleware
	{
		class HttpMethods
		{
			public const string POST = "POST";
			public const string PUT = "PUT";
		}

		private readonly RequestDelegate _next;
		public JsonBodyMiddleware(RequestDelegate next)
		{
			_next = next;
		}
		public async Task Invoke(HttpContext context)
		{
			await _next(context);
		}
		private bool isPostRequest(HttpContext context)
		{
			return context.Request.Method == HttpMethods.POST;
		}
		private bool isPutRequest(HttpContext context)
		{
			return context.Request.Method == HttpMethods.PUT;
		}
		private bool isJsonRequest(HttpContext context)
		{
			return context.Request.ContentType.StartsWith("application/json");
		}
		private bool isAvailableFilter(HttpContext context)
		{
			return (isPostRequest(context) || isPutRequest(context) && isJsonRequest(context));
		}
	}
}
