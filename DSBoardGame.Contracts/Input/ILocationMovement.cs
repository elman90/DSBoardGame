using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.Input
{
   public interface ILocationMovement
    {
        string GameId { get; }
        string NewLocationId { get; }
    }
}
