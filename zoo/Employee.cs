using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    public class Employee : IDisplayable
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public void PerformDuty()
        {
            Console.WriteLine($"{Name} є {Position}, виконує свої обов'язки.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Працівник: {Name}, Посада: {Position}");
        }
    }

}
