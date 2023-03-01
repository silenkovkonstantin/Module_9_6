using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = { new ArgumentNonDigitalException("Введенное значение не является цифрой 1 или 2"), new IndexOutOfRangeException(),
        new ArgumentNullException(), new DivideByZeroException(), new FormatException()};


            foreach (var exeption in exceptions)
            {
                try
                {
                    throw exeption;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadKey();
                }
            }
            
        }
    }
}
