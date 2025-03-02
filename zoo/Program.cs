using System;
using System.Globalization;
using System.Text;
using zoo;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Animal lion = new Animal("Сімба", "Лев", 5, "М'ясо");
        Animal elephant = new Animal("Дамбо", "Слон", 8, "Трава");
        Animal giraffe = new Animal("Мелман", "Жираф", 4, "Листя");

        Employee caretaker = new Employee("Олександр", "Доглядач");
        Employee vet = new Employee("Марина", "Ветеринар");

        Food meat = new Food("М'ясо", "Харчування для хижаків");
        Food grass = new Food("Трава", "Їжа для травоїдних");

        Inventory zooInventory = new Inventory();
        zooInventory.AddAnimal(lion);
        zooInventory.AddAnimal(elephant);
        zooInventory.AddAnimal(giraffe);
        zooInventory.AddEmployee(caretaker);
        zooInventory.AddEmployee(vet);
        zooInventory.AddFood(meat);
        zooInventory.AddFood(grass);

        zooInventory.DisplayInventory();

        Console.WriteLine("\n✅ Тестування завершено успішно!");
    }

}
