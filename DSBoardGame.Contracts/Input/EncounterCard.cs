using System;

using System.Collections.Generic;

namespace DSBoardGame.Contracts.BehaviourModels
{
    public enum Positions
    {
        A1 = 0,
        A2 = 1,
        A3 = 2,
        B1 = 3,
        B2 = 4,
        C1 = 5,
        C2 = 6,
        C3 = 7,
        D1 = 8,
        D2 = 9,
        E1 = 10,
        E2 = 11,
        E3 = 12,
    }
    public class EncounterCard
    {

        List<Guid> EnemyList { get; }
        bool IsTrapped { get; }
        TreasureChest TreasureChest { get; }
        List<string> BarrelLocations { get; }

    }

    public class TreasureChest
    {
        public Positions Position { get; set; }
    }
}
