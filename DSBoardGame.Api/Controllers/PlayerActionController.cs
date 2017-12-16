using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DSBoardGame.Contracts.Input;
using DSBoardGame.Domain;

namespace DSBoardGame.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/PlayerAction")]
    public class PlayerActionController : Controller
    {
        private readonly IPlayerActionService _playerActionService;
        public PlayerActionController(IPlayerActionService playerActionService)
        {
            _playerActionService = playerActionService;
        }
       
        
        // POST: api/PlayerAction
        [HttpPost]
        public void Post(PlayerAction action)
        {
            _playerActionService.AddPlayerAction(action);
        }
        
       
    }
}
