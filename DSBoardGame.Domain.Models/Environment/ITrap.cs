using DSBoardGame.Domain.Models.Entities;

namespace DSBoardGame.Domain.Models.Environment
{
    public interface ITrap : IBasePawn
    {
        int Damage { get; }

        bool IsEnabled { get; }
        void Trip(IPlayer target);

    }
}
