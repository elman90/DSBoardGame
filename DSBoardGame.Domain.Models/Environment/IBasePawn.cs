using System;

namespace DSBoardGame.Domain.Models.Environment
{
   public interface IBasePawn
    {
        Guid Id { get; }
        IPosition CurrentPosition { get; }
    }
}
