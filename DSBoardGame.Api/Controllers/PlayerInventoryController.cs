using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DSBoardGame.Contracts.BehaviourModels;

namespace DSBoardGame.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/PlayerInventory")]
    public class PlayerInventoryController : Controller
    {
        // GET: api/PlayerInventory
        [HttpGet]
        public IEnumerable<IItem> Get(string gameId)
        {
            throw new NotFiniteNumberException();
        }

        // GET: api/PlayerInventory/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/PlayerInventory
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/PlayerInventory/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
