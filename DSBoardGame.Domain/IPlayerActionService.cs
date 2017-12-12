using DSBoardGame.Contracts.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Domain
{
   public interface IPlayerActionService
    {
        void AddPlayerAction(IPlayerAction playerAction);
    }
}
