using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ListAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        static ItemList itemList = new ItemList();

        // GET api/values
        [HttpGet]
        public ItemList Get()
        {
            return itemList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Item Get(Guid id)
        {
            return itemList.Get(id);
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody]string value)
        {
            itemList.Add(value);
            return true;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return itemList.Delete(id);
        }
    }
}
