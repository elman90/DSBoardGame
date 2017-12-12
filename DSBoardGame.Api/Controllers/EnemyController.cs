using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DSBoardGame.Contracts.BehaviourModels;
using DSBoardGame.Contracts.Output.Data;

namespace DSBoardGame.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Enemy")]
    public class EnemyController : Controller
    {
        // GET: api/Enemy
        [HttpGet]
        public IEnumerable<ISpawnedEnemy> Get()
        {
            throw new NotImplementedException();

        }

        // GET: api/Enemy/5
        [HttpGet("{id}", Name = "Get")]
        public IEnemyCard Get(string id)
        {
            throw new NotImplementedException();

        }
     

    }
}
