using System;
using System.Collections.Generic;
using System.Text;
using DSBoardGame.Contracts.BehaviourModels;

namespace DSBoardGame.Contracts.Output
{
   public class LocationState
    {
        public List<PlayerState> PlayerStates { get; set; }
        public List<PawnState> PawnStates { get; set; }
    }

    public class PlayerState
    {
        public Guid PlayerId { get; set; }
        public int Hp { get; set; }
        public int Stamina { get; set; }
        public Positions Position { get; set; }
    }

    public class PawnState
    {
        public Guid PawnId { get; set; }
        public int Hp { get; set; }
        public Positions Position { get; set; }


    }
}
