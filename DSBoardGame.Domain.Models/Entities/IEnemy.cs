using DSBoardGame.Domain.Models.Environment;

namespace DSBoardGame.Domain.Models.Entities
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
