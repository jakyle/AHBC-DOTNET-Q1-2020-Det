using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Startup_Forms.Services;

namespace Startup_Forms
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IAllCapsContactService, AllCapsContactService>();
            services.AddSingleton<IHomeFacade, HomeFacade>();
            services.AddSingleton<IPaymentValidator, PaymentValidator>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request/response pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
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
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }

    public class PaymentValidator : IPaymentValidator
    {
        public string HeyClass { get; set; } = "hey guys, just showing you that we have this service lol, I like cheese";

        public bool ValidateCheck(Check check)
        {
            return false;
        }

        public bool ValidateCredit(CreditCard creditCard)
        {
            return true;
        }
    }

    public interface IPaymentValidator
    {
        bool ValidateCheck(Check check);
        bool ValidateCredit(CreditCard creditCard);
    }


    public class Check
    {

    }

    public class CreditCard
    {

    }
}