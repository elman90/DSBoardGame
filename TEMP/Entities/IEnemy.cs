using TEMP.Environment;
using TEMP.Items;

namespace TEMP.Characters
{
    public interface IEnemy :IBasePawn
    {
        string Name { get; }
        int MaxHp { get; }
        int CurrentHp { get; }
        int PhysicalDefense { get; }
        int MagicalDefense { get; }
        void Attack(IPlayer target);
        void Move(IPosition position);
        void ReceiveDamage(IDamage damage);
    }
}
