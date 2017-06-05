using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;//for the Configuration property
using System.IO;

namespace AspNetCoreVideo
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }//Adding a property called Configuration, of type IConfiguration, to the Startup class.
        public Startup()//Adding a constructor to the Startup class
        {
            var builder = new ConfigurationBuilder()//creating an instance of the ConfigurationBuilder class called builder in the constructor,

              .SetBasePath(Directory.GetCurrentDirectory())//the SetBasePath method lets the application know where to search for the files
                .AddJsonFile("appsettings.json");//In order to read the JSON file, you need to add the AddJsonFile method. If you need to include other files, you need to add more methods.

            Configuration = builder.Build();//Building the configuration structure from the ConfigurationBuilder object and store it in the Configuration property. You do this by calling the Build method on the builder variable.
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
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
                var message = Configuration["Message"];
                await context.Response.WriteAsync(message);
            });
        }
    }
}