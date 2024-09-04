using System;
using System.Collections.Generic;

class Program
{
    static List<Pet> pets = new List<Pet>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Pet Inventory!");

        bool addingPets = true;
        while (addingPets)
        {
            AddPet();
            Console.Write("Add another pet? (y/n): ");
            addingPets = Console.ReadLine().Trim().ToLower() == "y";
        }

        ListPets();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void AddPet()
    {
        Console.Write("Kind (Dog, Cat, Lizard, Bird): ");
        string kindInput = Console.ReadLine().Trim();
        Console.Clear();
        Kind kind;
        while (!Enum.TryParse(kindInput, true, out kind))
        {
            Console.Write("Invalid kind. Please enter Dog, Cat, Lizard, or Bird: ");
            kindInput = Console.ReadLine().Trim();
            
        }

        Console.Write("Name: ");
        string name = Console.ReadLine().Trim();

        Console.Write("Gender (M/F): ");
        string genderInput = Console.ReadLine().Trim().ToUpper();
        Gender gender;
        while (genderInput != "M" && genderInput != "F")
        {
            Console.Write("Invalid gender. Please enter M for Male or F for Female: ");
            genderInput = Console.ReadLine().Trim().ToUpper();
            Console.Clear();
        }
        gender = genderInput == "M" ? Gender.Male : Gender.Female;

        Console.Write("Owner: ");
        string owner = Console.ReadLine().Trim();

        switch (kind)
        {
            case Kind.Dog:
                Console.Write("Breed: ");
                string breed = Console.ReadLine().Trim();
                pets.Add(new Dog(name, gender, owner, breed));
                break;
            case Kind.Cat:
                Console.Write("Is Longhaired? (y/n): ");
                bool isLonghaired = Console.ReadLine().Trim().ToLower() == "y";
                pets.Add(new Cat(name, gender, owner, isLonghaired));
                break;
            case Kind.Lizard:
                Console.Write("Can Fly? (y/n): ");
                bool lizardCanFly = Console.ReadLine().Trim().ToLower() == "y";
                pets.Add(new Lizard(name, gender, owner, lizardCanFly));
                break;
            case Kind.Bird:
                Console.Write("Can Fly? (y/n): ");
                bool birdCanFly = Console.ReadLine().Trim().ToLower() == "y";
                pets.Add(new Bird(name, gender, owner, birdCanFly));
                break;
        }
    }

    static void ListPets()
    {
        Console.Write("Which type of animal would you like to list? (Dog, Cat, Lizard, Bird, or 'All'): ");
        string filter = Console.ReadLine().Trim();
        Console.WriteLine("\nAll pets in the inventory:");

        foreach (var pet in pets)
        {
            if (filter.Equals("All", StringComparison.OrdinalIgnoreCase) || pet.GetType().Name.Equals(filter, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("* " + pet.ToString());
            }
        }
    }
}

