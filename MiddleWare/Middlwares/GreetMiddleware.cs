namespace MiddleWare.Middlwares
{
	public class GreetMiddleware
	{
        RequestDelegate _next;
        public GreetMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //Custom operation...

            Console.WriteLine("Welcome! GreetMiddleware is running...");
            await _next(context);
            Console.WriteLine("Goodbye! GreetMiddleware is ending...");
        }
    }
}
