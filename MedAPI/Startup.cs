using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MedAPI.Infra.Entity.Context;
using MedAPI.Repositories.Entity;

namespace MedAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddResponseCompression();

            services.AddScoped<MedAPIDBContext, MedAPIDBContext>();
            services.AddTransient<RepositoryPacientes, RepositoryPacientes>();
            services.AddTransient<RepositoryEnderecos, RepositoryEnderecos>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc();
            app.UseResponseCompression();
        }

    }
}
