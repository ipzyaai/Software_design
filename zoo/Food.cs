using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    public class Food : IDisplayable
    {
        public string Name { get; set; }
        public string Type { get; set; } 

        public Food(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Корм: {Name}, Тип: {Type}");
        }
    }

}
