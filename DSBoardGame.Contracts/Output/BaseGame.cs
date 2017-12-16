using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.Output
{
    public class BaseGame
    {

        string Name { get; }
        List<BasePlayer> Players { get; }
        Guid MiniBossId { get; }
        Guid MainBossId { get; }
    }

    public class BasePlayer
    {
        public string Name { get; set; }
        public string Class { get; set; }
    }
}
