//-----------------------------------------------------------------------
// <copyright file="ValuesController.cs" company="XTK Inc.">
//     Copyright (c) XTK Inc.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ServerMonitor.Api.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Controller that obtains Values from the bacckend
    /// </summary>
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        /// <summary>
        /// Holds the logger
        /// </summary>
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesController"/> class
        /// </summary>
        public ValuesController()
        {
            
        }

        /// <summary>
        /// Gets the Values
        /// </summary>
        /// <returns>The list of values</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Gets a value by its unique identifier
        /// </summary>
        /// <param name="id">Value's unique identifier</param>
        /// <returns>The value</returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Inserts a value
        /// </summary>
        /// <param name="value">Value to insert</param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Updates an existing value
        /// </summary>
        /// <param name="id">Unique identifier of the value</param>
        /// <param name="value">Value to update</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Deletes a value
        /// </summary>
        /// <param name="id">Unique identifier of the value to delete</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
