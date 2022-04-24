using Homework3;

// 1. uzd.

Phone phone1 = new Phone();
phone1.Brand = "Nokia";
phone1.Model = "3310";
phone1.SendMessage();

Console.WriteLine("----------------");
// 2. uzd.

Car car1 = new Car();
car1.Brand = "Toyota";
car1.NumberPlate = "A - 1234";
car1.StartMovement();
car1.IncreaseVelocity(15);
car1.IncreaseVelocity(25);
car1.DecreaseVelocity(30);
car1.FinishMovement();
car1.Signal();

Console.WriteLine("----------------");
// 3. uzd.

Console.WriteLine("Specify item width in cm:");
double width = double.Parse(Console.ReadLine());

Console.WriteLine("Specify item length in cm:");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("Specify item weight in g:");
double weight = double.Parse(Console.ReadLine());

Item item1 = new Item(width, length, weight);
item1.getItemParameters();

Console.WriteLine("----------------");
// 4. uzd.

Console.WriteLine("What is Your name?");
string firstName = Console.ReadLine();

Console.WriteLine("What is Your surname?");
string lastName = Console.ReadLine();

Console.WriteLine("Your date of birth? Put it in format dd.mm.yyyy");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Console.WriteLine("How about hobbies?");
string hobby = Console.ReadLine();

Console.WriteLine("What is Your gender? Type just one letter: 'f' for female, 'm' for male");
string gender = Console.ReadLine();

Person person1 = new Person(firstName, lastName, birthDate, hobby, gender);
person1.CalculateAge();
person1.Greeting();



