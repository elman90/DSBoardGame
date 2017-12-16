namespace DSBoardGame.Domain.Models.Environment
{
   public interface IBarrel:IBasePawn
    {
        bool IsDestroyed { get; }
        void Destroy();
    }
}
