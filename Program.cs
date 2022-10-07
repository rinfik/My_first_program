using System.IO.Pipes;

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

    names[questionnaire] = getName();

    ages[questionnaire] = getAge();

    jobs[questionnaire] = getJob();

    weights[questionnaire] = getWeight();

    Console.WriteLine();
}
People(names,ages,jobs,weights);


void People (string[] names, int[] ages, string[] jobs, double[] weights)
{
    Console.WriteLine("Имя\tВозраст\tРабота\tВес");

    for (int i = 0; i < names.Length; i++) 
    {
        Console.Write($"{names[i]}\t{ages[i]}\t{jobs[i]}\t{weights[i]}\n");
    }
}


string getName()
{
    Console.Write("Введите имя:");
    return Console.ReadLine();
}

int getAge()
{
   int birth;
    Console.Write("Введите год рождения:");
    while (!int.TryParse(Console.ReadLine(), out birth))
    {
        Console.WriteLine("Ошибка ввода! Введите год рождения");
    }
int currentyear = DateTime.Today.Year;
   int age = currentyear - birth;
    return age;
}

string getJob()
{
    Console.Write("Вы работаете? Введите да/нет:");
    bool isEmployed = Console.ReadLine().ToLower() == "да" ? true : false;

    if (isEmployed)
    {
        Console.Write("Кем? ");
      return Console.ReadLine();
    }
    else
    {
        Console.Write("Ха-ха, безработный \n");
        return "";
    }
}

double getWeight()
{
Console.Write("Введите вес:");
    return  Convert.ToDouble(Console.ReadLine());
}

