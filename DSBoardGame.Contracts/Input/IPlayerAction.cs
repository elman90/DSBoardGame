using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.Input
{
    public interface IPlayerAction
    {
        string GameId { get; }
        string PlayerId { get; }
        int ActionIndex { get; }
        string Target { get; }
    }
}
