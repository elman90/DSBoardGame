using DSBoardGame.Contracts.Input;
using DSBoardGame.Contracts.Output;
using System.Collections.Generic;

namespace DSBoardGame.Domain
{
    public interface IGameService
    {
        BaseGame Get(string Id);
        IEnumerable<BaseGame> GetList();
        string Create(GameCreate gameCreate);
        void AddPlayer(string Id);
        
        void SetMiniBoss();
        void SetMainBoss();


    }
}
