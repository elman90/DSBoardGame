using TEMP.Game;

namespace TEMP.Items
{
    public interface IDice
    {
        DiceTypes DiceType { get; }

        int[] DiceValues { get; }
    }
}
