namespace TEMP.Data
{
   public interface IEnemyCard
    {
        string Id { get; }
        string Name { get; }
        int MaxHp { get; }
        int CurrentHp { get; }
        int PhysicalDefense { get; }
        int MagicalDefense { get; }
    }
}
