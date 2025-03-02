using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    public class Animal : IDisplayable
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Diet { get; set; }

        public Animal(string name, string species, int age, string diet)
        {
            Name = name;
            Species = species;
            Age = age;
            Diet = diet;
        }

        public Animal(string name, int age)
            : this(name, "Невідомий", age, "Невідомий") { }

        public void Eat()
        {
            Console.WriteLine($"{Name} їсть {Diet}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Тварина: {Name}, Вид: {Species}, Вік: {Age}, Раціон: {Diet}");
        }
    }
}
