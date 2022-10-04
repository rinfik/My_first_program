Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");



Console.WriteLine("Привет Git \n");

int respondents;
do
{
    Console.WriteLine("Привет! Скажи, сколько человек будет проходить эту анкету? (❁´◡`❁)");
}
while (!int.TryParse(Console.ReadLine(), out respondents));
Console.WriteLine();

string[] names = new string[respondents];
int[] ages = new int[respondents];
string[] jobs = new string[respondents];
double[] weights = new double[respondents];

for (int questionnaire = 0; questionnaire < respondents; questionnaire++)
{
   Console.WriteLine($"Заполните анкету №{questionnaire+1} из {respondents} \n");

    Console.Write("Введите имя:");
    names[questionnaire] = Console.ReadLine();

    int birth;
    Console.Write("Введите год рождения:");
    while (!int.TryParse(Console.ReadLine(), out birth))
    {
        Console.WriteLine("Ошибка ввода! Введите год рождения");
    }

    Console.Write("Вы работаете? Введите да/нет:");
    bool isEmployed = Console.ReadLine().ToLower() == "да" ? true : false;

    if (isEmployed)
    {
        Console.Write("Кем? ");
        jobs[questionnaire] = Console.ReadLine();
    }
    else
    {
        Console.Write("Ха-ха, безработный \n");
    }

    Console.Write("Введите вес:");
    weights[questionnaire] = Convert.ToDouble(Console.ReadLine());

    int currentyear = DateTime.Today.Year;
    ages[questionnaire] = currentyear - birth;
    Console.WriteLine();
}

Console.Write("Имя");
foreach (string name in names) 
{
    Console.Write("\t"+name);
}

Console.Write("\nВозраст");
foreach (int age in ages)
{
    Console.Write("\t" + age);
}

Console.Write("\nРабота");
foreach (string job in jobs)
{
   Console.Write("\t" + job);
}

Console.Write("\nВес");
foreach (double weight in weights)
{
    Console.Write("\t" + weight);
}
