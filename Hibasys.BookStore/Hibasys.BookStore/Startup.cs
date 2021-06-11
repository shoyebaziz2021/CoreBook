using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hibasys.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>
            //  {
            //      await context.Response.WriteAsync("This is my First Middle Ware \n");
            //      await next();

            //      await context.Response.WriteAsync("This is my First Middle Ware Response");
            //  });

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("This is my Second Middle Ware \n");
            //    await next();

            //    await context.Response.WriteAsync("This is my Second Middle Ware Response \n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("This is my Third Middle Ware \n");
            //    await next();
            //});
            app.UseStaticFiles();

            // This is for testing purpose not use in this project 
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(
            //        Path.Combine(Directory.GetCurrentDirectory(), "MyStaticfiles")),
            //    RequestPath = "/MyStaticfiles"
            //});
            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World ! \n");
            //    });
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
