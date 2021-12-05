using System;

namespace prac61console
{
    class prac
    {
        public prac()
        {
            InOne();
            InTwo();
        }
        int[] arr1;
        int[,] arr2;
        int k, m, n;

        void InOne()
        {
            Console.WriteLine("ОДНОМЕРНЫЙ МАССИВ:");
        reTry:
            Console.WriteLine("Введите размер массива:");
            if (Int32.TryParse(Console.ReadLine(), out k))
            {
                arr1 = new int[k];
                for (int i = 0; i < arr1.Length; i++)
                {
                arrTry:
                    Console.Write($"Введите {i + 1}-ый элемент массива: ");
                    if (Int32.TryParse(Console.ReadLine(), out arr1[i])) { }
                    else
                    {
                        Console.WriteLine("Вы ввели не целочисленное значение");
                        goto arrTry;
                    }
                }
                Console.WriteLine("Нечётные элементы массива:");
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] % 2 == 1)
                    {
                        Console.Write(arr1[i]+" ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
                goto reTry;
            }
        }
        void InTwo()
        {
            Console.WriteLine("\nМНОГОМЕРНЫЙ МАССИВ");
            Console.WriteLine("Введите размер массива MxN:");
            reTryM:
            Console.Write("M: ");
            if (Int32.TryParse(Console.ReadLine(), out m))
            {
                reTryN:
                Console.Write("N: ");
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    arr2 = new int[m, n];
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                        arrTry:
                            Console.Write($"Введите элемент массива ({i+1},{j+1}): ");
                            if (Int32.TryParse(Console.ReadLine(), out arr2[i,j])) { }
                            else
                            {
                                Console.WriteLine("Вы ввели не целочисленное значение");
                                goto arrTry;
                            }
                        }
                    }
                    Console.WriteLine("Нечётные элементы массива:");
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (arr2[i, j] % 2 == 1) { Console.Write(arr2[i, j] + " "); }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Рамеры массива должны быть целлочисленными");
                    goto reTryN;
                }
            }
            else
            {
                goto reTryM;
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
