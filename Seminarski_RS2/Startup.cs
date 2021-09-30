
using DB.DB_Access;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Models;
using WEB_API.Services;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WEB_API.Security;

namespace Seminarski_RS2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddAuthentication("jwt_bearer")
            //        .AddJwtBearer("jwt_bearer",
            //            config=> {
            //                config.Authority = "https://localhost:44324/";
            //                config.Audience = "TheMainApi";
            //            }   
            //        );         

            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Seminarski_RS2", Version = "v1" });
                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme() { Scheme:})
            });

            services.AddTransient<IKorisnikServis, KorisnikServis>();
            services.AddTransient<AuthService>();
            services.AddDbContext<DB_Context>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Seminarski_RS2 v1"));
            }
            app.UseHttpsRedirection();
            app.UseRouting();
           // app.UseAuthentication();
           // app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
