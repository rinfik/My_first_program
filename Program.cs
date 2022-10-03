Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

Console.WriteLine("Привет Git \n");

Console.WriteLine("Привет! Напиши, пожалуйста, свои данные. \n");

  Console.Write("Введите имя:");
 string name = Console.ReadLine();

int birth;
Console.Write("Введите год рождения:");

while (!int.TryParse(Console.ReadLine(), out birth))
{
    Console.WriteLine("Ошибка ввода! Введите год рождения");
}

Console.Write("Вы работаете? Введите да/нет:");
bool isEmployed = Console.ReadLine().ToLower() == "да" ? true : false;

 string job="";
if (isEmployed)
{
    Console.Write("Кем? ");   
    job = Console.ReadLine();    
}
else 
{
    Console.Write("Ха-ха, безработный \n");
}



Console.Write("Введите вес:");
string weight = Console.ReadLine();


int currentyear = DateTime.Today.Year;
int age = currentyear - birth;



Console.WriteLine($"\nИмя: {name}");
Console.WriteLine($"Возраст: {age}");

if (isEmployed)
{
    Console.WriteLine($"Работа: {job}");
}


Console.WriteLine($"Вес: {weight}");
