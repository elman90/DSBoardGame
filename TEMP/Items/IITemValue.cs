using System.Collections.Generic;

namespace DSBoardGame.Contracts.BehaviourModels
{
    public interface IItemValue
    {
      List<IDice> Dices { get; }
        int FixedValue { get; }
    }
}
