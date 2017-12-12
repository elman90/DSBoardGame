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
    [Route("api/Equipment")]
    public class EquipmentController : Controller
    {
        // GET: api/Equipment
        [HttpGet]
        public IEnumerable<IEquipment> Get(string playerId)
        {
            throw new NotImplementedException();
        }

      

        
        // POST: api/Equipment
        [HttpPost]
        public void Post(IEquipment equipment)
        {
        }
       
    }
}
