using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DSBoardGame.Contracts.BehaviourModels;
using DSBoardGame.Contracts.Output;

namespace DSBoardGame.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/TeamInventory")]
    public class TeamInventoryController : Controller
    {
        // GET: api/GameDeck
        [HttpGet]
        public IEnumerable<Item> Get(string gameId)
        {
            throw new NotImplementedException();
        }

     
    
        // POST: api/GameDeck
        [HttpPost]
        public void Post(string gameId,string itemId)
        {
        }
        

        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string gameId, string itemId)
        {
        }
    }
}
