﻿using System.Collections.Generic;

namespace DSBoardGame.Contracts.BehaviourModels.Game
{
    public interface IBonfire :ILocation
    {
       // List<IItem> Deck { get; }
        //List<IItem> TotalInventory { get; }
        int SoulsCache { get; }
        int SparksCount { get; }

        //void DrawDeck(IItem item);

        //void UseSparkCount(IGame game);

    }
}
