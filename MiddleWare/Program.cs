using MiddleWare.Extensions;
using System.Security.Cryptography.X509Certificates;

namespace MiddleWare
{
	public class Program
	{
		public static void Main(string[] args)
		{

			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddSwaggerGen();
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			//Asp.NET Core mimarisinde tüm middleware'ler "Use" ile baslar.
			//Middleware'lerde tetiklenme sirasi onemlidir.


			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}
			else
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.UseGreet();//Olusturdugumuz Middleware...

			app.UseConnection();//ornek middleware
			
			//app.Run(async context =>
			//{
			//	await context.Response.WriteAsync("Hello from 2nd delegate.");
			//}); 
			//app.Run(async context =>
			//{
			//	await context.Response.WriteAsync("Hello from 3nd delegate.");
			//});


			//burada next parametresi ile sonraki middleware cagrilmaktadir.
			//app.Use(async (context, next) =>
			//{
   //             Console.WriteLine("Start 'Use' Middleware");
			//	await next.Invoke();
   //             Console.WriteLine("Stop 'Use' Middleware");
			//});

			////Bu middleware sayesinde istek gonderen path'e göre filtreleme iþlemi yapabiliriz. Bunu if-else gibi düsünebilirsiniz.
			//app.Map("/ornekyol",async context =>
			//{
			//	//codes...
			//});

			////gelen request'in herhangi bir özelliðine göre filtreleme iþlemi gerçekleþtirilebilir.
			//app.MapWhen(c => c.Request.Method == "GET", builder => 
			//{
			//	builder.Use(async (context,next) =>
			//	{
			//		await context.Response.WriteAsync("We using MapWhen!");
			//		await next.Invoke();
			//		await context.Response.WriteAsync("The end.");
			//	});
			//});



			////Sonuna bos bir app.Run() middleware'ý eklenerek uygulama istek alabilecek duruma gelir ve middleware sonlanmýs olur.
			//app.Run(async c =>
			//{
   //             Console.WriteLine("Start 'Run' Middleware");
			//});
			//app.Run();
			app.Run();
			


		}
	}
}
