using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ory.Client.Api;
using Ory.Client.Client;


namespace WebApiClover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

       

            //var builder = WebApplication.CreateBuilder(args);

            //// configure http port explicitly to override generated settings from launchSettings.json
            //builder.WebHost.ConfigureKestrel(opt => {
            //    var port = builder.Configuration.GetValue<int>("APP_PORT", 5001);
            //    opt.ListenAnyIP(port);
            //});

            //var app = builder.Build();

            //// create a new Ory Client with the BasePath set to the Ory Tunnel enpoint
            //var oryBasePath = builder.Configuration.GetValue<string>("ORY_BASEPATH") ?? "http://localhost:4000";
            //var ory = new FrontendApi(new Configuration
            //{
            //    BasePath = oryBasePath
            //});

            //// add session middleware
            //app.Use(async (ctx, next) =>
            //{
            //    async Task Login()
            //    {
            //        // this will redirect the user to the managed Ory Login UI
            //        var flow = await ory.CreateBrowserLoginFlowAsync() ?? throw new InvalidOperationException("Could not create browser login flow");
            //        ctx.Response.Redirect(flow.RequestUrl);
            //    }

            //    try
            //    {
            //        // check if we have a session
            //        var session = await ory.ToSessionAsync(cookie: ctx.Request.Headers.Cookie, cancellationToken: ctx.RequestAborted);
            //        if (session?.Active is not true)
            //        {
            //            await Login();
            //            return;
            //        }

            //        // add session to HttpContext
            //        ctx.Items["req.session"] = session;
            //    }
            //    catch (ApiException)
            //    {
            //        await Login();
            //        return;
            //    }

            //    await next(ctx);
            //});

            //app.MapGet("/", () => "Hello World!");

            //app.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        //Ovo sam kopirao,pokusavajuci da napravim isto za CrateBuilder
        //public static IHostBuilder CreateBuilder(string[] args) =>
        // Host.CreateDefaultBuilder(args)
        //     .ConfigureWebHostDefaults(webBuilder =>
        //     {
        //         webBuilder.UseStartup<Startup>();
        //     });
        // configure http port explicitly to override generated settings from launchSettings.json



    }
}
