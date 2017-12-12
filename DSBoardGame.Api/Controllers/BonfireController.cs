using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DSBoardGame.Contracts.BehaviourModels.Game;

namespace DSBoardGame.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Bonfire")]
    public class BonfireController : Controller
    {
     

        // GET: api/Bonfire/5
        [HttpGet("{id}", Name = "Get")]
        public IBonfire Get(string gameId)
        {
            throw new NotImplementedException();
        }
        
        // POST: api/Bonfire
        [HttpPost]
        public void Post(IBonfire bonfire , string gameId)
        {
        }
        
        // PUT: api/Bonfire/5
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
