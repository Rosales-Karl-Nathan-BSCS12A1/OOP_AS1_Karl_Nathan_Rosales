public class Pet : IAnimal
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public string Owner { get; set; }

    public Pet(string name, Gender gender, string owner)
    {
        Name = name;
        Gender = gender;
        Owner = owner;
    }

    public override string ToString()
    {
        return $"{Name} ({Gender}), Owner: {Owner}";
    }
}