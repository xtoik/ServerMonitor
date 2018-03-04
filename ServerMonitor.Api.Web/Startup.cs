//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="XTK Inc.">
//     Copyright (c) XTK Inc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ServerMonitor.Api.Web
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    /// <summary>
    /// Starts up the application
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Starts up the Web API
        /// </summary>
        /// <param name="configuration">Configuration received</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the configuration 
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configures the services provided
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">Services collection</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        /// <summary>
        /// Configures the HTTP request pipe
        /// </summary>
        /// <param name="app">Application builder</param>
        /// <param name="env">Hosting environment</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
