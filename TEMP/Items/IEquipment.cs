namespace DSBoardGame.Contracts.BehaviourModels
{
    public interface IEquipment
    {
        IArmor Body { get; }
        IWeapon RightHand { get; }
        IWeapon LeftHand { get; }
    }
}
