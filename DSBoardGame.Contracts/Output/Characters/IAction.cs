using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.BehaviourModels
{
    public enum ActionType
    {
        Move=1,
        Attack=2,

    }
    public interface IAction
    {
        int Index { get; }
        ActionType ActionType { get; }
        List<string> PossibleTargets { get; }
        //List<IActionTarget> PossibleTargets { get; }
    }


}
