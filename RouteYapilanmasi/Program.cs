using Microsoft.Extensions.Options;
using RouteYapilanmasi.Constraints;

namespace RouteYapilanmasi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			builder.Services.Configure<RouteOptions>(options => options.ConstraintMap.Add("custom", typeof(CustomConstraint)));
			
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

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();//Controller'lardan gelen istegi controller'larla eslestirir.Attribute routing pattern'i kullaniliyorsa yazilmasi zorunludur. 
				//Rotalari özelden genele siralamak dogru bir yaklasim olacaktir.
				//endpoints.MapControllerRoute("Default3","{controller=Home}/{action=Index}/{id:custom}/{x:maxlength(5)}/{y:int?}");
				//endpoints.MapControllerRoute("Default2", "anasayfa", new { controller = "Home", action = "Index"});
				//endpoints.MapControllerRoute("Default", "{controller=Personel}/{action=index}" );
				//endpoints.MapDefaultControllerRoute();
			});

			app.Run();
		}
	}
}
