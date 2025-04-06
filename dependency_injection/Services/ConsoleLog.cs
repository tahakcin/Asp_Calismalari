using dependency_injection.Services.Interfaces;

namespace dependency_injection.Services
{
	public class ConsoleLog : ILog
	{
        public ConsoleLog(int a)
        {
            
        }
        public void Log() 
		{
            //codes...
            Console.WriteLine("Console logging succesfully completed.");
		}
	}
}
