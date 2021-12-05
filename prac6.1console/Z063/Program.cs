using System;

namespace prac63console
{
    class prac
    {
        public prac()
        {
            Main();
        }
        int n;
        int[,] arr;
        void Main()
        {
            Console.WriteLine("Введите размер квадратной матрицы NxN:");
        reTry:
            Console.Write("N: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                arr = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                    arrReTry:
                        Console.Write($"Введите элемент матрицы ({i + 1},{j + 1}):");
                        if (Int32.TryParse(Console.ReadLine(), out arr[i, j])) { }
                        else
                        {
                            Console.WriteLine("Вы ввели не целое число");
                            goto arrReTry;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    if ((i + 1) % 2 == 1)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(arr[i, j].ToString() + " ");
                        }
                    }
                    else
                    {
                        for (int j = n - 1; j >= 0; j--)
                        {
                            Console.Write(arr[i, j].ToString() + " ");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Размер матрицы должен быть целочисленным");
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

