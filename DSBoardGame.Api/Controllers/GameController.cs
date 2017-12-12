using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DSBoardGame.Domain.BehaviourModels;
using DSBoardGame.Domain;
using DSBoardGame.Contracts.Input;
using DSBoardGame.Contracts.Output;
using DSBoardGame.Contracts.BehaviourModels;

namespace DSBoardGame.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Game")]
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        public IEnumerable<IBaseGame> Get()
        {
            return _gameService.GetList();
        }

        [HttpGet("{id}", Name = "Get")]
        public IGame Get(string id)
        {
            return _gameService.Get(id);
        }

        // POST: api/Game
        [HttpPost]
        public string Post(IGameCreate gameCreate)
        {
            return _gameService.Create(gameCreate);
        }
        
        // PUT: api/Game/5
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
