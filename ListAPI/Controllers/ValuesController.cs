using System;
using System.Collections.Generic;
using ListAPI.Models;
using ListAPI.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ListAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {        
        // GET api/values
        [HttpGet]
        public IEnumerable<ItemResponse> Get()
        {
            return ItemList.MapToReponse();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ItemResponse Get(Guid id)
        {
            var ret = ItemList.Get(id)?.MapToReponse();
            return ret;
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody]string value)
        {
            ItemList.Add(value);
            return true;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return ItemList.Delete(id);
        }
    }
}
