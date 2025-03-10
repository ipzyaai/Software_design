# Зоопарк - Лабораторна робота

Це програма для управління зоопарком, яка включає в себе клас для тварин, працівників та корму. Програма демонструє застосування різних принципів програмування.

## Принципи програмування

### 1. **DRY (Don't Repeat Yourself)**

Принцип DRY означає, що кожен шматок логіки програми повинен бути написаний тільки один раз. У нашому коді цей принцип дотримується за допомогою створення загальних методів і класів. Наприклад, метод `DisplayInfo` є спільним для класів `Animal`, `Employee` і `Food`, що дозволяє уникнути дублювання коду в кожному з класів.

**Файл**: `Animal.cs`, `Employee.cs`, `Food.cs`  
**Рядки**: [24](https://github.com/ipzyaai/Software_design/blob/main/zoo/Animal.cs#L24), [24](https://github.com/ipzyaai/Software_design/blob/main/zoo/Employee.cs#L24), [24](https://github.com/ipzyaai/Software_design/blob/main/zoo/Food.cs#L24)

### 2. **KISS (Keep It Simple, Stupid)**

Принцип KISS полягає в тому, щоб програма була простою і легкою для розуміння. У нашому коді ми застосовуємо цей принцип, мінімізуючи складність класів і методів. Наприклад, методи в класах `Animal`, `Employee` і `Food` мають чітке та просте призначення: або вони відображають інформацію, або виконують дії, що не створюють зайвої складності.

**Файл**: `Animal.cs`, `Employee.cs`, `Food.cs`  
**Рядки**: [18–30](https://github.com/ipzyaai/Software_design/blob/main/zoo/Animal.cs#L18-L30), [18–30](https://github.com/ipzyaai/Software_design/blob/main/zoo/Employee.cs#L18-L30), [18–30](https://github.com/ipzyaai/Software_design/blob/main/zoo/Food.cs#L18-L30)

### 3. **SOLID**

#### a. **Single Responsibility Principle (SRP)**

Кожен клас має лише одну відповідальність. Клас `Animal` відповідає лише за тварин, клас `Employee` за працівників, а клас `Food` за корм. Це дозволяє легко підтримувати та розширювати систему.

**Файл**: `Animal.cs`, `Employee.cs`, `Food.cs`  
**Рядки**: [7–30](https://github.com/ipzyaai/Software_design/blob/main/zoo/Animal.cs#L7-L30), [7–30](https://github.com/ipzyaai/Software_design/blob/main/zoo/Employee.cs#L7-L30), [7–30](https://github.com/ipzyaai/Software_design/blob/main/zoo/Food.cs#L7-L30)

#### b. **Open/Closed Principle (OCP)**

Класи є відкритими для розширення, але закритими для модифікації. Наприклад, можна додавати нові типи тварин, працівників і кормів без необхідності змінювати існуючий код класів.

**Файл**: Всі файли, що містять класи

#### c. **Liskov Substitution Principle (LSP)**

Враховуючи, що наші класи не мають явної ієрархії успадкування, цей принцип в даному контексті не використовується.

#### d. **Interface Segregation Principle (ISP)**

Ми використовуємо інтерфейс `IDisplayable` для надання можливості класам реалізувати метод `DisplayInfo`. Це дозволяє дотримуватись принципу розподілу інтерфейсів.

**Файл**: `IDisplayable.cs`  
**Рядки**: [7–9](https://github.com/ipzyaai/Software_design/blob/main/zoo/IDisplayable.cs#L7-L9)

#### e. **Dependency Inversion Principle (DIP)**

Ми не маємо явних залежностей між класами, але принцип інверсії залежностей можна застосувати для більш складних систем, де залежності від конкретних реалізацій можна замінити на абстракції.

### 4. **YAGNI (You Aren't Gonna Need It)**

Принцип YAGNI вказує на те, що не слід додавати функціональність, яка не є необхідною. У нашій програмі ми реалізуємо лише основні функції для зоопарку: додавання тварин, працівників і корму, а також відображення інформації.

**Файл**: Всі файли програми

### 5. **Composition Over Inheritance**

Ми використовуємо композицію для організації об'єктів, а не спадкування. Наприклад, замість того, щоб створювати ієрархії тварин і працівників, ми використовуємо списки для зберігання різних об'єктів.

**Файл**: `Inventory.cs`  
**Рядки**: [8–13](https://github.com/ipzyaai/Software_design/blob/main/zoo/Inventory.cs#L8-L13)

### 6. **Program to Interfaces, not Implementations**

Ми використовуємо інтерфейс `IDisplayable` для забезпечення гнучкості при додаванні нових типів об'єктів, які можуть відображати свою інформацію. Класи `Animal`, `Employee`, і `Food` реалізують цей інтерфейс, а не конкретні реалізації.

**Файл**: `IDisplayable.cs`  
**Рядки**: [7–9](https://github.com/ipzyaai/Software_design/blob/main/zoo/IDisplayable.cs#L7-L9)

### 7. **Fail Fast**

Програма не має явних механізмів для обробки помилок, але це може бути реалізовано для кращої стабільності. Наприклад, ми могли б додати перевірку на порожні або некоректні значення під час додавання тварин, працівників або кормів.

**Файл**: Всі файли програми
