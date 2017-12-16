using DSBoardGame.Domain.Models.Entities;

namespace DSBoardGame.Domain.Models.ValueObjects
{
    public interface IPlayerClass
    {
        string ClassName { get; }
        IEquipment BaseEquipment { get; }
        IPlayerStats BaseStats { get; }
        //TODO: heroic actions
    }
}
