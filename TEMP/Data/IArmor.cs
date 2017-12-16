using TEMP.Data;

namespace TEMP.Items
{
    public interface IArmor : IItem
    {
        IItemValue PhysicalDefense { get; }
        IItemValue MagicalDefense { get; }
        IItemValue RollValues { get; }
    }
}
