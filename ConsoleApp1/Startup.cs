using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleApp1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware1>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            #region Middleware
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("hello from run");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello from use 1 - 1 \n");

            //    await next();

            //    await context.Response.WriteAsync("hello from use 1 - 2 \n");
            //});

            //app.UseMiddleware<CustomMiddleware1>();

            //app.Map("/gnanu", customCode);

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello from use 3 - 1 \n");

            //    await next();

            //    await context.Response.WriteAsync("hello from use 3 - 2 \n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("request complete \n");
            //    //await next();
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("hello from run - 1 \n");
            //});
            #endregion


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllers();
                #region routing
                //Without using controller routing
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync(" First web api app");
                //});

                //endpoints.MapGet("/test1", async context =>
                //{
                //    await context.Response.WriteAsync("First web api route - test1");
                //});

                //endpoints.MapGet("/test2", async context =>
                //{
                //    await context.Response.WriteAsync("First web app api route - test2");
                //});
                #endregion

            });
        }

        private void customCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("hello from gnanu \n");                
            });
        }
    }
}
