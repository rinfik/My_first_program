

Console.WriteLine("Привет! Напиши, пожалуйста, свои данные:");

Console.WriteLine("Введите имя:");
string name = Console.ReadLine();

Console.WriteLine("Ведите год рождения");
string birth = Console.ReadLine();

Console.WriteLine("Ввведите работу");
string isEmployed = Console.ReadLine();

Console.WriteLine("Введите вес");
string weight = Console.ReadLine();

int i1 = Convert.ToInt32 (birth);
Console.WriteLine(DateTime.Today.Year);
int currentyear = DateTime.Today.Year;
int age = currentyear - i1;



Console.WriteLine($"Имя: {name}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Работает: {isEmployed}");
Console.WriteLine($"Вес: {weight}");