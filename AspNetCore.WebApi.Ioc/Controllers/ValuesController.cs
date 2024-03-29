﻿using AspNetCore.WebApi.IService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCore.WebApi.Ioc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDemoService _demoService;
        public ValuesController(IDemoService demoService)
        {
            _demoService = demoService;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            await _demoService.NoReturnTask();
            return await Task.FromResult(_demoService.GetString("123"));
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
