using System;
using System.Linq;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static List<string> surnames = new List<string>() { "Иванов", "Петров", "Сидоров", "Васильев", "Алексеев" };

        static void Main(string[] args)
        {
            try
            {
                Persons persons = new Persons(surnames);

                Console.WriteLine("Список фамилий до сортировки:");

                // Выводим элементы списка до сортировки
                foreach (var item in persons.Surnames)
                {
                    Console.WriteLine(item);
                }

                persons.Notify += SortSurnames;

                Console.WriteLine("\nВведите порядок сортировки: 1 - А-Я, 2 - Я-А");
                byte number = byte.Parse(Console.ReadLine());
                persons.SetNumber(number);

                /// Сортирует список фамилий
                void SortSurnames(Persons sender, PersonsEventArgs e)
                {
                    if (e.Num == 1)
                    {
                        persons.Surnames.Sort(); // Сортировка по возрастанию
                    }
                    else // Здесь может быть только 2, т.к. у нас выше есть обработка исплючения
                    {
                        persons.Surnames = persons.Surnames.OrderByDescending(x => x).ToList();
                    }
                    
                }

                Console.WriteLine("\nСписок фамилий после сортировки:");

                // Выводим элементы списка после сортировки
                foreach (var item in persons.Surnames)
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
