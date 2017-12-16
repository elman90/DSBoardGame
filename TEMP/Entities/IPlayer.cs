using System.Collections.Generic;
using TEMP.Data;
using TEMP.Environment;
using TEMP.Items;

namespace TEMP.Characters
{
    public interface IPlayer : IBasePawn
    {
        string Name { get; }
        int MaxHp { get; }
        int CurrentHp { get; }
        IEquipment Equipment { get; }
        List<IItem> Inventory { get; }
        IPlayerClass Class { get; }
        IPlayerStats Stats { get; }
        void ChangeEquipment(IEquipment equipment);
        void Attack(IEnemy target);
        void Move(IPosition position);
        void ReceiveDamage(IDamage damage, int defense);
    }
}
