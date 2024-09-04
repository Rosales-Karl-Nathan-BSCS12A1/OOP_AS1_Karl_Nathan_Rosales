public class Lizard : Pet
{
    public bool CanFly { get; set; }

    public Lizard(string name, Gender gender, string owner, bool canFly)
        : base(name, gender, owner)
    {
        CanFly = canFly;
    }

    public override string ToString()
    {
        string flyStatus = CanFly ? "Can fly" : "Cannot fly";
        return $"Lizard - {base.ToString()}, {flyStatus}";
    }
}