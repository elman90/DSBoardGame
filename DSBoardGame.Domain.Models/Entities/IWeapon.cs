using System.Collections.Generic;
using DSBoardGame.Domain.Models.Data;

namespace DSBoardGame.Domain.Models.Entities
{
    public interface IWeapon:IItem
    { 
        List<IWeaponAttack> WeaponAttacks { get; }
        WeaponHandleType Handle { get; }

    }

    public interface IWeaponAttack
    {

        AttackTypes AttackType { get; }
        int StaminaCost { get; }
        IDamage LaunchAttack(int damage);
    }

    public interface IDamage
    {
        int DamageValue { get; }
        AttackTypes DamageType { get; }
    }
}
