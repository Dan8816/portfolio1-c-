using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace example
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public static void ConfigureServices(IServiceCollection services)//static was added here per platform example
        {
            services.AddMvc();//added this line
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();//added this line
            //app.Run(async (context) => //commented out app.run
            //{
                //await context.Response.WriteAsync("Hello World!");
            //});
        }

        public Startup (IHostingEnvironment env)//this was added per platform example
        {
            System.Console.WriteLine(env.ContentRootPath);//this was added per platform example
            System.Console.WriteLine(env.IsDevelopment());//this was added per platform example
        }
    }
}
