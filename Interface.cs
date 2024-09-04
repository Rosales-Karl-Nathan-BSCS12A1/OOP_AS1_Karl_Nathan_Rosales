public interface IAnimal
{
    string Name { get; set; }
    Gender Gender { get; set; }
    string Owner { get; set; }
    string ToString();
}