using MiddleWare.Middlwares;

namespace MiddleWare.Extensions
{
	static public class Extension
	{
		public static IApplicationBuilder UseGreet(this IApplicationBuilder applicationBuilder)
		{
			return applicationBuilder.UseMiddleware<GreetMiddleware>();
		}

		public static IApplicationBuilder UseConnection(this IApplicationBuilder applicationBuilder)
		{
			return applicationBuilder.UseMiddleware<ConnectionMiddleware>();
		}

		public static IApplicationBuilder UseJsonDataCheck(this IApplicationBuilder applicationBuilder)
		{
			return applicationBuilder.UseMiddleware<JsonBodyMiddleware>();
		}
	}
}
