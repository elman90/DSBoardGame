using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.BehaviourModels
{
   public interface IItem
    {
        string Id { get; }

        string Name { get; }
    }
}
