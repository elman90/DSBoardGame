using System;

namespace DSBoardGame.Domain.Models.Data
{
   public interface IItem
    {
        Guid Id { get; }

        string Name { get; }
    }
}
