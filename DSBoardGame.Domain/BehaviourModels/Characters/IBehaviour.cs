using DSBoardGame.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Domain.BehaviourModels.Characters
{
    public interface IBehaviour
    {
        BehaviourTarget Target{get;}
    }
}
