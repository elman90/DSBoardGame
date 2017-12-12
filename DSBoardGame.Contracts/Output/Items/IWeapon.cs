using System.Collections.Generic;

namespace DSBoardGame.Contracts.BehaviourModels
{
    public interface IWeapon:IItem
    { 
        List<IPlayerAttack> WeaponAttacks { get; }
        WeaponHandleType Handle { get; }

    }
}
