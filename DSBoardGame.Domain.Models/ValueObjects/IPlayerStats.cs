namespace DSBoardGame.Domain.Models.ValueObjects
{
    public interface IPlayerStats
    {
        int Dexterity { get; }
        int Strength { get; }
        int Faith { get; }
        int Intelligence { get; }
    }
}
