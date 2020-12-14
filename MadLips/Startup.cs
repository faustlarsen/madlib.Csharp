using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Madlips
{
  public class Startup
  {
    public Startup(IHostingEnvironment env) //constructor
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddEnvironmentVariables();
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; }

    public void ConfigureServices(IServiceCollection services) //this method is required to configure other framework services
    {
      services.AddMvc();
    }

    public void Configure(IApplicationBuilder app) // this method is required for telling our app how to handle requests
    {
      app.UseDeveloperExceptionPage(); // This will produce a friendly error report when Razor fails to load.
      app.UseMvc(routes => // tells our app to use MVC framework to respond to HTTP requests
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });

      app.Run(async (context) => // allow to test that our Configure() method is working
      {
        await context.Response.WriteAsync("Hello World!");
      });
    }
  }
}