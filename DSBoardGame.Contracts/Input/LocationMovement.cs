using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.Input
{
   public class LocationMovement
    {
        Guid GameId { get; }
        Guid NewLocationId { get; }
    }
}
