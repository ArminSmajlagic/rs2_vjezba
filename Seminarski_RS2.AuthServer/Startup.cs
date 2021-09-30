using AuthServer.SecurityConfig;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Seminarski_RS2.AuthServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski_RS2.AuthServer
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

            services.AddIdentity<ApplicationUser, IdentityRole>(
                config =>
                {
                    //config.Password.RequiredLength = 8;
                    //config.Password.RequireDigit = true;
                    //config.Password.RequireNonAlphanumeric = true;
                    //config.Password.RequireUppercase = true;                 
                }
            ).AddDefaultTokenProviders();

            var builder = services.AddIdentityServer(
                opt=> {
                    //opt.Events.RaiseErrorEvents = true;
                    //opt.Events.RaiseInformationEvents  = true;
                    //opt.Events.RaiseFailureEvents = true;
                    //opt.Events.RaiseSuccessEvents = true;
                    opt.EmitStaticAudienceClaim = true;

                }
                ).AddInMemoryIdentityResources(AuthConfig.GetIdentityResources())
                 .AddInMemoryApiResources(AuthConfig.GetApiResources())
                 .AddInMemoryApiScopes(AuthConfig.GetApiScopes())
                 .AddInMemoryClients(AuthConfig.GetClients())
                 .AddDeveloperSigningCredential()
                 .AddAspNetIdentity<ApplicationUser>();


            builder.AddDeveloperSigningCredential();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Seminarski_RS2.AuthServer", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Seminarski_RS2.AuthServer v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();


            app.UseIdentityServer();


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
