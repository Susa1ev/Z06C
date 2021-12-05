using System;

namespace prac62console
{
    class prac
    {
        public prac()
        {
            Main();
        }
        int n;
        double F = Int32.MinValue;
        double[] arr;
        void Main()
        {
        reTry:
            Console.WriteLine("Введите размер массива:");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                arr = new double[n];
                for (int i = 0; i < arr.Length; i++)
                {
                arrTry:
                    Console.Write($"Введите {i + 1}-ый элемент массива: ");
                    if (Double.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        if (arr[i] < 0 && arr[i] > F) { F = arr[i]; }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не действительное значение");
                        goto arrTry;
                    }
                }
                Console.WriteLine("Максимальное число из отрицательных: " + F);
            }
            else
            {
                Console.WriteLine("Размер массива должен быть целочисленным");
                goto reTry;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            prac p = new prac();
        }
    }
}

