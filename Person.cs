using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public string name;
        public int age;
        public string job;
        public double weight;

       
        public void setName()
        {
            Console.Write("Введите имя:");
            name = Console.ReadLine();
        }

        public void setAge()
        {
            int birth;
            Console.Write("Введите год рождения:");
            while (!int.TryParse(Console.ReadLine(), out birth))
            {
                Console.WriteLine("Ошибка ввода! Введите год рождения");
            }
            int currentyear = DateTime.Today.Year;
            age = currentyear - birth;
        }

        public void setJob()
        {
            Console.Write("Вы работаете? Введите да/нет:");
            bool isEmployed = Console.ReadLine().ToLower() == "да" ? true : false;

            if (isEmployed)
            {
                Console.Write("Кем? ");
               job = Console.ReadLine();
            }
            else
            {
                Console.Write("Ха-ха, безработный \n");
            }
        }

        public void setWeight()
        {
            Console.Write("Введите вес:");
            weight = Convert.ToDouble(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name}\t  Возраст: {age}\t  Работа: {job}\t Вес: {weight}\t");
           
        }
    }
}
