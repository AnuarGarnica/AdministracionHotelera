using AdministracionHoteles.Models;
using AdministracionHoteles.Tools.Services;
using AdministracionHoteles.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Globalization;

namespace AdministracionHoteles.Web
{
    public class Startup
    {
       public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //Está rutina llama al método 'gets'. Este método se usa para agregar servicios al contenedor
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddResponseCompression();  
            services.AddResponseCaching();
            string conn = Configuration.GetConnectionString("connAH");
            services.AddDbContext<DataContextLPL>(options => options.UseSqlServer(conn));
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            services.AddSingleton<IEmailSender, EmailSender>();  
        }

        //Esta rutina llama al método 'gets'. Se utiliza este método para configurar la respuesta(REQUEST PIPELINE) de la tubería HTTP.

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                //The default HSTS value is 30 days. you may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.com
                app.UseHsts();
            }

            var cultureInfo = new CultureInfo("es-Mx");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            app.UseHttpsRedirection();
            app.UseResponseCompression();
            app.UseResponseCaching();

            app.UseStaticFiles();


            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }
}
