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
//also need the Microsoft.Extensions.Configuration.Json dependency

namespace OdeToFood
{
    public class Startup
    {

        public Startup(IHostingEnvironment env){//constructor. Exucutes a bit of code before ConfigureServices and Configure execute
            //Need to tell asp.net about your appsettings.json file
            //Asp.NET can pass in an object which uses the IHostingEnvironoment.
            //One of the things which you can do with a class which implements the Ihosting Environment, is ask for the content root path. This allows the hosting environment to dynamically determine where the content is.
            var builder = new ConfigurationBuilder ()//creating an instance of a class called ConfigurationBuilder
            //It is in a namespace which is not being used by default, so need to add an appropriate using statement.
                .SetBasePath(env.ContentRootPath)//Tell it where the base path is. But you don't want to hardCode anything
                //Now, you need to tell the Configuration Builder about the appsettings.json file.
                .AddJsonFile("appsettings.json");//This requires a dependency
                //You can continue to add configuration sources to the Configuration builder if necessary
                //eg - more json files or EnvironmentVariables can be added.

                Configuration = builder.Build();//asking the builder to Build a configuration.
        }

        //defining a property 
        public IConfiguration Configuration {get;set;} //property of type IConfiguration which is called Configuration.

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)//setup Inversion of Control and Dependency injection.
        {
            //Need to create a service which implements IGreeter registered in the Services collection.
            services.AddSingleton(Configuration);//ASP.NET knows the type of Configuration and so, any object which needs IConfiguration, it will use the object on this line.
            services.AddSingleton<IGreeter, Greeter>();//This allows the implentation of the interface for the Greeter method. This is saying that whenever you see something which needs the IGreeter parameter, instantiate the Greeter class and pass in the IGreeter
            //Once again, this allows you to use different types of IGreeter. One could connect to a database or a json or whatever. Only this line knows what this particular IGreeter is connecting to.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory, 
            IGreeter greeter)//method now takes an Igreeter called greeter
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                //instead of the hardcoded string below:
                //await context.Response.WriteAsync("Hello World!!!!!!!!!!! Hello");
                //doesnt want the code on the inside of the Configuration method to access the configuration source directly.
                //Instead, you want the method to go through some application service. So, an object will retrieve the information. Need to add a class called Greeter.cs

                //Now, instead of going to configuration source, will now get the greeting from this greeter. That message will then be written into every http request
                var message =greeter.GetGreeting();//Going into the Configuration property (builder.Build()) and then find the message based on the index in the appsettings.json file 
                //So, will look for value associated with key of "Greeting"
                await context.Response.WriteAsync(message);
            });
        }
    }
}
