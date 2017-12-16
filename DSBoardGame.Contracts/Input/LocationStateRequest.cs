using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.Input
{
   public class LocationStateRequest
    {
        public Guid GameId { get; set; }
        public Guid LocationId { get; set; }
    }
}
