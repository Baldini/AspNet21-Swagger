using AspNet21_Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNet21_Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Get a List of string
        /// </summary>
        /// <returns>List of string</returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Return value
        /// </summary>
        /// <param name="id">ID of Value</param>
        /// <returns>Value</returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

       /// <summary>
       /// Find a list of ValueResponse
       /// </summary>
       /// <param name="request">Data to find</param>
       /// <returns>List of ValueResponse</returns>
        [HttpPost]
        public ActionResult<IEnumerable<ValuesResponse>> Post([FromBody] ValuesRequest request)
        {
            return Ok(new List<ValuesResponse>()
            {
                new ValuesResponse()
                {
                    ID = 1,
                    Value = "One"
                },
                new ValuesResponse()
                {
                    ID = 2,
                    Value = "Two"
                }
            });
        }

        /// <summary>
        /// Put a value
        /// </summary>
        /// <param name="id">ID of value</param>
        /// <param name="value">Value</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a Value
        /// </summary>
        /// <param name="id">ID of Value</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
