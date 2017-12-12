using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DSBoardGame.Contracts.BehaviourModels.Game;
using DSBoardGame.Contracts.Input;
using DSBoardGame.Contracts.BehaviourModels;

namespace DSBoardGame.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Location")]
    public class LocationController : Controller
    {
        // GET: api/Location
        [HttpGet]
        public IEnumerable<ILocation> Get(string gameId)
        {
            throw new NotImplementedException();
        }

        // GET: api/Location/5
        [HttpGet("{id}", Name = "Get")]
        public ILocation Get(string gameId,string locationId)
        {
            throw new NotImplementedException();

        }

        // POST: api/Location
        [HttpPost]
        public void Post(ILocationMovement locationMovement)
        {
        }
        
        // PUT: api/Location/5
        [HttpPut("{id}")]
        public void Put(IEncounterCard encounterCard)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
