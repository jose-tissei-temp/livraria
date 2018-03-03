using AutoMapper;
using Livraria.CrossCutting.IoC;
using Livraria.CrossCutting.IoC.Container;
using Livraria.CrossCutting.IoC.Registros;
using Livraria.Infra.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the servicesContainer.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddMvc();
            services.AddCors();
            services.AddScoped(typeof(IRegistroContainer), typeof(RegistroDados));

            new ServicesContainer(services).CarregarRegistros();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options =>
            {
                var appUrl = Configuration.GetSection("UISettings")["AppUrl"];
                options.WithOrigins(appUrl).AllowAnyMethod().AllowAnyHeader();
            });

            app.UseMvc();
        }
    }
}
