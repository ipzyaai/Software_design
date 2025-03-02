using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    public class Inventory
    {
        private List<Animal> animals;
        private List<Employee> employees;
        private List<Food> foods;

        public Inventory()
        {
            animals = new List<Animal>();
            employees = new List<Employee>();
            foods = new List<Food>();
        }

        public void AddAnimal(Animal animal) => animals.Add(animal);
        public void AddEmployee(Employee employee) => employees.Add(employee);
        public void AddFood(Food food) => foods.Add(food);

        public void DisplayInventory()
        {
            Console.WriteLine("\n📦 Інвентаризація зоопарку:");

            Console.WriteLine("\n🐾 Тварини:");
            foreach (var animal in animals) animal.DisplayInfo();

            Console.WriteLine("\n👨‍🔧 Працівники:");
            foreach (var employee in employees) employee.DisplayInfo();

            Console.WriteLine("\n🥩 Корм:");
            foreach (var food in foods) food.DisplayInfo();
        }
    }

}
