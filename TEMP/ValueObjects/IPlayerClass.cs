using TEMP.Items;

namespace TEMP.Characters
{
    public interface IPlayerClass
    {
        string ClassName { get; }
        IEquipment BaseEquipment { get; }
        IPlayerStats BaseStats { get; }
        //TODO: heroic actions
    }
}
