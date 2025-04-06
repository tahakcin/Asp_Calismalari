using dependency_injection.Services;

namespace dependency_injection
{
	public class Example
	{
        public Example()
        {
            IServiceCollection services = new ServiceCollection(); // built-in IoC
            services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog(3)));
            services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));
            ServiceProvider provider =  services.BuildServiceProvider();// somut container/provider/sağlayıcı
           
            provider.GetService<ConsoleLog>();
            provider.GetService<TextLog>();
        }
    }
}
