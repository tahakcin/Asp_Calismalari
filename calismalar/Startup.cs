using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;

namespace ornek
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			services.
				AddFluentValidationAutoValidation().
				AddFluentValidationClientsideAdapters().
				AddValidatorsFromAssemblyContaining<Startup>();
		}
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseRouting();
			app.UseStaticFiles();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapDefaultControllerRoute();
			});
		}
	}
}