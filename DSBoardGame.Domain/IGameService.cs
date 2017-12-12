using DSBoardGame.Contracts.BehaviourModels;
using DSBoardGame.Contracts.Input;
using DSBoardGame.Contracts.Output;
using DSBoardGame.Domain.BehaviourModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Domain
{
   public interface IGameService
    {
        IGame Get(string Id);
        IEnumerable<IBaseGame> GetList();
        string Create(IGameCreate gameCreate);
        void AddPlayer(string Id);
        
        void SetMiniBoss();
        void SetMainBoss();


    }
}
