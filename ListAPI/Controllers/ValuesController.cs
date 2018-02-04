﻿using System;
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
        public ItemListResponse Get()
        {
            return ItemList.MapToReponse();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ItemResponse Get(Guid id)
        {
            return ItemList.Get(id).MapToReponse();
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
