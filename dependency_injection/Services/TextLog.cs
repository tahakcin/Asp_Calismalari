using dependency_injection.Services.Interfaces;

namespace dependency_injection.Services
{
	public class TextLog : ILog
	{
		public void Log()
		{
            // codes...
            Console.WriteLine("Text file logging successfully completed.");
		}
	}
}
