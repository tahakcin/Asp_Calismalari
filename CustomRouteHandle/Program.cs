using CustomRouteHandle.Handlers;

namespace CustomRouteHandle
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

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

			//app.Map("exampl-route",async c =>
			//{
			//	//https://localhost:7079//example-route endpoint'ine gelen herhangi bir istek controller'dan ziyade buradaki fonksiyon tarafýndan karsilanacktir.

			//});

			var env = app.Environment;

			app.Map("image/{imageName}",new ImageHandler().Handler(env.WebRootPath));

			app.Map("example-route", new ExampleHandler().Handler());

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");


			app.Run();
		}
	}
}
