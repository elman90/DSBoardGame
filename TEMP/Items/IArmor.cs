using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.BehaviourModels
{
    public interface IArmor : IItem
    {
        IItemValue PhysicalDefense { get; }
        IItemValue MagicalDefense { get; }
        IItemValue RollValues { get; }
    }
}
