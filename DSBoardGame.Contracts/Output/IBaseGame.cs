using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.Output
{
    public interface IBaseGame
    {
        string Id { get; }
        string Name { get; }
        List<IPlayerCreate> Players { get; }
        string MiniBossId { get; }
        string MainBossId { get; }
    }
}
