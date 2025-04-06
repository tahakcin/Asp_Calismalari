using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;

namespace ornek
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Bu uygulamada kullanılacak servislerin eklendiği/konfigüre edilidiği metottur.
			// servis  = modül = kütüphane 
            services.AddControllersWithViews();
            services.
                AddFluentValidationAutoValidation().
                AddFluentValidationClientsideAdapters().
                AddValidatorsFromAssemblyContaining<Startup>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Bu metotta da uygulamada kullanılacak olan middleware'lerimizi/ara yazılımlarımızı çağırmaktayız.
            if (env.IsDevelopment()) 
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting(); // Gelen isteğin rotası bu middleware sayesinde belirlenir.
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                //Endpoint: Yapılan isteğin varış noktası URL. istek adresi.
                //Bu uygulamaya gelen isteklerin hangi rotalar eşiliğinde gelebileceğini buradan bildireceğiz.

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!!!");
                //});
                // {controller = Home}/{action = Index}/{id?}             
                // Default olan endpoint yapısı bu şekildedir.
                //Bu uygulamaya yapılacak olan istekler bu yapıya uygun bir şekilde yapılacaktır.
                //Endpoint tanımlamasında süslü parantez içerisinde parametreler tanımlanabilmektedir
                // ÖR: {conroller}/{action}/{example}
                endpoints.MapControllerRoute("CustomRoute", "{controller=Home}/{action=Index}/{a}/{b}/{id}");
                endpoints.MapDefaultControllerRoute();
            });
        }   
    }
}
