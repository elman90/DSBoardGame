using DSBoardGame.Contracts.BehaviourModels;
using DSBoardGame.Contracts.Input;
using DSBoardGame.Contracts.Output;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DSBoardGame.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Location")]
    public class LocationController : Controller
    {
  

        // GET: api/Location/5
        [HttpGet("{id}", Name = "Get")]
        public LocationState Get(LocationStateRequest request)
        {
            throw new NotImplementedException();

        }

        // POST: api/Location
        [HttpPost]
        public void Post(LocationMovement locationMovement)
        {
        }
        
        // PUT: api/Location/5
        [HttpPut("{id}")]
        public void Put(EncounterCard encounterCard)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
