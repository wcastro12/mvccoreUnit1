using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApliCountries.Models;

namespace WebApliCountries
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
            services.AddDbContext<AplicationContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString("conextion")));

            services.AddIdentity<AplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AplicationContext>()
                .AddDefaultTokenProviders();
                

     
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,AplicationContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            if (!context.Countries.Any())
            {
                context.Countries.AddRange(
                     new List<Country>() {
                         new Country() { Name="c",CountryID=1},
                         new Country() { Name="b",CountryID=2},}
                    );

                context.SaveChanges();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
