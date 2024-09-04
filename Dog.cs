public class Dog : Pet
{
    public string Breed { get; set; }

    public Dog(string name, Gender gender, string owner, string breed)
        : base(name, gender, owner)
    {
        Breed = breed;
    }

    public override string ToString()
    {
        return $"Dog - {base.ToString()}, Breed: {Breed}";
    }
}