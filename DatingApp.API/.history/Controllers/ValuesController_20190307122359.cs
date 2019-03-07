﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {

        private readonly DataContext _context ;

        public ValuesController (DataContext context) {
       _context = context;

        }

        // GET api/values
        [HttpGet]
        public Task<IActionResult> Get () {
            var values = _context.Values.ToListAsync();
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public ActionResult<string> Get (int id) {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post ([FromBody] string value) { }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}