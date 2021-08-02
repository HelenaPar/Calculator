using System;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            char again = 'd';
            while(again =='d')
            {
            Console.WriteLine("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_____________________________");
            Console.WriteLine("Введите номер операции: ");
            Console.WriteLine("1 - Сложение,");
            Console.WriteLine("2 - Вычитание,");
            Console.WriteLine("3 - Деление,");
            Console.WriteLine("4 - Умножение,");
            Console.WriteLine("5 - Процент от числа,");
            Console.WriteLine("6 - Квадратный корень числа.");
            Console.WriteLine("_____________________________");
                string number = Console.ReadLine();
            
                switch (number)
                {
                    case "1":
                        Console.WriteLine("Введите число B: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Результат: " + (a + b)); break;
                    case "2":
                        Console.WriteLine("Введите число B: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Результат: " + (a - b)); break;
                    case "3":
                        Console.WriteLine("Введите число B: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Результат: " + (a / b)); break;
                    case "4":
                        Console.WriteLine("Введите число B: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Результат: " + (a * b)); break;
                    case "5":
                        Console.WriteLine("Введите процент: ");
                        int per = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Результат: " + System.Math.Round((double)(a * per / 100))); break;
                    case "6": Console.WriteLine("Результат: " + (Math.Sqrt(a))); break;
                    default: Console.WriteLine("Error!"); break;
                }
            }
            Console.ReadKey();
        }
    }
}
