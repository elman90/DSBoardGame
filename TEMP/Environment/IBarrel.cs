namespace TEMP.Environment
{
   public interface IBarrel:IBasePawn
    {
        bool IsDestroyed { get; }
        void Destroy();
    }
}
