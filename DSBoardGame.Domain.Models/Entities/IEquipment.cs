namespace DSBoardGame.Domain.Models.Entities
{
    public interface IEquipment
    {
 
        IWeapon RightHand { get; }
        IWeapon LeftHand { get; }
    }
}
