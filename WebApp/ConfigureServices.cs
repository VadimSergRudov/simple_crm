using Application.Common.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebApp.Helpers;
using WebApp.Services;
using WebApp.Utils;

namespace WebApp
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddWebUIServices(this IServiceCollection services, IConfiguration configuration)
        {
            //    services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //        .AddCookie(options => //CookieAuthenticationOptions
            //        {
            //            options.Cookie.SameSite = SameSiteMode.None;
            //            options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            //            options.Events = new CookieAuthenticationEvents
            //            {
            //                OnRedirectToLogin = redirectContext =>
            //                {
            //                    redirectContext.HttpContext.Response.StatusCode = 401;
            //                    return Task.CompletedTask;
            //                }
            //            };

            //        });
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
            services.AddScoped<IJwtUtils, JwtUtils>();
            services.AddScoped<IUserService, UserService>();

            services.AddControllers();
        //    services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();

        //    // In production, the React files will be served from this directory
        //    services.AddSpaStaticFiles(configuration =>
        //    {
        //        configuration.RootPath = "ClientApp/build";
        //    });

            return services;
        }
    }
}
