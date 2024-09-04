public class Cat : Pet
{
    public bool IsLonghaired { get; set; }

    public Cat(string name, Gender gender, string owner, bool isLonghaired)
        : base(name, gender, owner)
    {
        IsLonghaired = isLonghaired;
    }

    public override string ToString()
    {
        string hairType = IsLonghaired ? "Longhaired" : "Shorthair";
        return $"Cat - {base.ToString()}, Hair Type: {hairType}";
    }
}