using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Telephone.Controllers;
using Telephone.Models;
using Newtonsoft.Json;
using Telephone.Interfaces.Repository;
using Telephone.GenericRepository;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.Net.Http.Headers;

namespace Telephone
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
            services.AddControllers();
            // Add Cors
            services.AddCors(o => o.AddPolicy("Policy", builder => {
                builder.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
            }));
            services.AddMvc(option => option.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            // services.AddScoped<telephoneContext>();
            services.AddDbContext<telephoneContext>(options =>
                     options.UseSqlServer(Configuration.GetConnectionString("telephone")));

            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<ITalksRepository, TalksRepository>();
            services.AddTransient<ISubscribesRepository, SubscribesRepository>();
            services.AddServerSideBlazor();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(policy => policy.WithOrigins("https://localhost:5001", "https://localhost:5000/")
            .AllowAnyMethod()
            .WithHeaders(HeaderNames.ContentType));

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("Policy");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
