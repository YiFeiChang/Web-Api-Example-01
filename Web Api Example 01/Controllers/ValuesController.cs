using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Api_Example_01.Controllers
{
    public struct User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
    [Route("api/[controller]/[action]")]    //定義Controller的路徑
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/Values/GetAll
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Values?id={id}
        [HttpGet]
        public string Get(int id)
        {
            return "value " + id;
        }

        // POST api/Values/Post
        [HttpPost]
        public User Post([FromBody] User value)
        {
            value.Name = value.Name + "(Post:由伺服器回傳)";
            return value;
        }

        // PUT api/Values/Put?id={id}
        [HttpPut]
        public User Put(int id, [FromBody] User value)
        {
            value.Name = value.Name + "(Put:由伺服器回傳)";
            return value;
        }

        // DELETE api/Values/Delete?id={id}
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
