using System;

namespace prac64console
{
    class prac
    {
        public prac()
        {
            Main();
        }
        int[][] arr;
        int[] secArr;
        int n, k1, k2;
        void Main()
        {
            Console.WriteLine("Введите целочисленное значение для массива NxN");
        reTry:
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                arr = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = new int[n];
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                    reArrInTry:
                        Console.Write($"Введите элемент матрицы ({i + 1},{j + 1})");
                        if (Int32.TryParse(Console.ReadLine(), out arr[i][j])) { }
                        else
                        {
                            Console.WriteLine("Данная матрица может принимать только целочисленные значения");
                            goto reArrInTry;
                        }
                    }
                }

            reTryK1:
                Console.Write("Введите k1: ");
                if (Int32.TryParse(Console.ReadLine(), out k1)) { }
                else { Console.WriteLine("Элемент k1 должен быть целочисленным"); goto reTryK1; }
            reTryK2:
                Console.Write("Введите k2: ");
                if (Int32.TryParse(Console.ReadLine(), out k2)) { }
                else { Console.WriteLine("Элемент k2 должен быть целочисленным"); goto reTryK2; }
                secArr = new int[n];
                if (k2 - k1 > 0 && k1 > 0 && k2 > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        secArr[i] = 0;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = k1 - 1; j < k2; j++)
                        {
                            secArr[i] += arr[i][j];
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(secArr[i] + " ");
                    }
                }
                else
                {
                    Console.WriteLine("Разница между k2 и k1 должна быть положительной");
                    goto reTryK1;
                }

            }
            else
            {
                Console.WriteLine("Значение размера матрицы должно быть целочисленным");
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
