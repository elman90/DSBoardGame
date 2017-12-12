using DSBoardGame.Contracts.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Domain
{
   public interface IGameEngine
    {
        void UpdateGame(IPlayerAction playerAction);
    }
}
