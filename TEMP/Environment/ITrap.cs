using TEMP.Characters;

namespace TEMP.Environment
{
    public interface ITrap : IBasePawn
    {
        int Damage { get; }

        bool IsEnabled { get; }
        void Trip(IPlayer target);

    }
}
