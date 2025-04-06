using dependency_injection.Services;
using dependency_injection.Services.Interfaces;

namespace dependency_injection
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			
			//builder.Services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog())); //Burada davran�� default olarak SINGLETON'd�r. 
			//builder.Services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog(9), ServiceLifetime.Transient));//Gelen her talebe kar��l�k bir nesne �retilir.

			//builder.Services.AddSingleton<ConsoleLog>();//B�t�n isteklerle, b�t�n taleplerde tek bir tane nesne �retip onu g�nderir.  
			//E�er constructor parametre al�yorsa:
			//builder.Services.AddSingleton<ConsoleLog>(p => new ConsoleLog(9));

			//builder.Services.AddScoped<ConsoleLog>(p => new ConsoleLog(9));

			//builder.Services.AddTransient<ConsoleLog>(p => new ConsoleLog(9));

			//builder.Services.AddScoped<ILog>(p => new ConsoleLog(5));

			builder.Services.AddScoped<ILog, TextLog>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
