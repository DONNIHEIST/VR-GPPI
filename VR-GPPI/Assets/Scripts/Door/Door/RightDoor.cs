public class RightDoor : Door
{
    public override bool IsLocked
    {
        get => isLocked;
        set => isLocked = Angle <= LimitsMin;
    }
}