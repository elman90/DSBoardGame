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
    [Route("api/Items")]
    public class ItemsController : Controller
    {
        // GET: api/Items
        [HttpGet]
        public IEnumerable<IItem> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Items/5
        [HttpGet("{id}", Name = "Get")]
        public IItem Get(int id)
        {
            throw new NotImplementedException();
        }
        
      
    }
}
