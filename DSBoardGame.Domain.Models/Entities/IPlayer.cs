using System.Collections.Generic;
using DSBoardGame.Domain.Models.Data;
using DSBoardGame.Domain.Models.Environment;
using DSBoardGame.Domain.Models.ValueObjects;

namespace DSBoardGame.Domain.Models.Entities
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
