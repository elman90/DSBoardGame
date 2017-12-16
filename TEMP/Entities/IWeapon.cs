using System.Collections.Generic;
using TEMP.Data;
using TEMP.Game;

namespace TEMP.Items
{
    public interface IWeapon:IItem
    { 
        List<IWeaponAttack> WeaponAttacks { get; }
        WeaponHandleType Handle { get; }

    }

    public interface IWeaponAttack
    {
        IItemValue Value { get; }
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
