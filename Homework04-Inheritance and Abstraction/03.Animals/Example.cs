using System;
using System.Collections.Generic;
using System.Linq;
using Animals;

class Example
{
    public static void Main()
    {
        List<Animal> animals = new List<Animal>() { new Dog("Lacy", 5, Genders.Female),
                                                    new Dog("Sinaia", 9, Genders.Female),
                                                    new Frog("Preshus", 5, Genders.Male),
                                                    new Frog("Merry", 5, Genders.Female),
                                                    new Cat("Liucy", 4, Genders.Female),
                                                    new Cat("Garfild", 2, Genders.Male),
                                                    new Kitten("Poli", 6),
                                                    new Kitten("Geri", 4),
                                                    new Tomcat("Tom", 1),
                                                    new Tomcat("Michael", 10)
                                                  };
        animals[0].ProduceSound();
        animals[2].ProduceSound();
        animals[4].ProduceSound();
        animals[6].ProduceSound();
        animals[8].ProduceSound();
        Console.WriteLine();

        var groupedAnimals = from animal in animals
                             group animal by (animal is Cat) ? typeof(Cat) : animal.GetType() into g
                             select new { GroupName = g.Key, AverageAge = g.ToList().Average(an => an.Age) };
        
        foreach (var animal in groupedAnimals)
        {
            Console.WriteLine("{0} - average age: {1:N2}", animal.GroupName.Name, animal.AverageAge);
        }
    }
}

