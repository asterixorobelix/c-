using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;//namespace for ConfigurationBuilder
//also need to add the Microsoft.Extensions.Configuration.FileExtensions dependency

namespace OdeToFood
{
    public class Startup
    {

        public Startup(){//constructor. Exucutes a bit of code before ConfigureServices and Configure execute
            //Need to tell asp.net about your appsettings.json file
            var builder = new ConfigurationBuilder ()//creating an instance of a class called ConfigurationBuilder
            //It is in a namespace which is not being used by default, so need to add an appropriate using statement.
                .SetBasePath()//Tell it where the base path is. But you don't want to hardCode anything

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)//setup Inversion of Control and Dependency injection.
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!!!!!!!!!!! Hello");
            });
        }
    }
}
