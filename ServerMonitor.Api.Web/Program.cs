//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="XTK Inc.">
//     Copyright (c) XTK Inc.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ServerMonitor.Api.Web
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Main entry of the program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Initializes a new instance of the <seee cref="Program"/> class
        /// </summary>
        /// <param name="args">Arguments provided</param>
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        /// <summary>
        /// Prepares the Web Host to answer requests
        /// </summary>
        /// <param name="args">Arguments provided in the command line</param>
        /// <returns>The web host ready to rumble</returns>
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
