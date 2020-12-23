using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertiseSDK;
using Core;
using Core.Logger;
using Core.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using yq.ibase;

namespace Tool
{
    public class Startup : CommonStartup
    {
        public Startup(IConfiguration configuration) : base(configuration)
        {

        }

        public override void CommonServices(IServiceCollection services)
        {
            services.Configure<MysqlSettings>(Configuration.GetSection("MysqlSettings"));
            var settings = services.BuildServiceProvider().GetService<IOptions<MysqlSettings>>().Value;
            DbHelper.CreateConnection(settings.DefaultConnection, settings.DevConnection);

            services.AddSingleton(typeof(Client), sp =>
            {
                var logger = sp.GetRequiredService<ILogger<Client>>();
                return new Client(logger);
            });

            services.AddCoreSwagger()
                        .AddCoreSeriLog();
        }

        public override void CommonConfigure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCoreSwagger();
        }
    }
}
