using System;

namespace TEMP.Environment
{
   public interface IBasePawn
    {
        Guid Id { get; }
        IPosition CurrentPosition { get; }
    }
}
