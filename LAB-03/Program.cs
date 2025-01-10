using System.Collections.Generic;

namespace LAB_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            int n = 10;
            do
            {
                Console.WriteLine(n);
                n--;
            }
            while (n >= 0);

            //zadanie 2
            string haslo;
            do
            {
                Console.WriteLine("wpizs haslo");
                haslo = Console.ReadLine();
            }
            while (haslo != "koniec");

            //zadanie 3
            int a = 0;
            while (a <= 100)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            }

            //zadanie 4
            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine(i * i);
            }

            //zadanie 5
            List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number / 7);
                //zadanie 6
                if (number % 7 == 0)
                {
                    Console.WriteLine(number / 7);
                    break;
                }
            }

            //zadanie 7
            double[] array = new double[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Sqrt(i);
                Console.WriteLine(array[i]);
            }

            //zadanie 8
            int b = 0;
            int[,] intArray = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    intArray[i, j] = b;
                    b++;
                }
            }
            int[,] intArray2 = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    intArray2[i, j] = intArray[j, i];
                }
            }

            //zadanie 9
            void PrintMassage(string letters)
            {
                Console.WriteLine(letters.ToUpper());
            }
            PrintMassage("hello");

            //zadanie 10
            void dollarArray(int x, int y)
            {
                string[,] strings = new string[x, y];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        strings[i, j] = "$";
                        Console.WriteLine(strings[i, j]);
                    }
                }
            }
            dollarArray(1, 2);

            //zadanie 11
            string OddOrEven(int chosenNumber)
            {
                if (chosenNumber % 2 == 0)
                {
                    return "Even";
                }
                else
                {
                    return "Odd";
                }
            }
            Console.WriteLine(OddOrEven(7));

            //zadanie 12
            Console.WriteLine("Podaj liczbę wierszy (k):");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę kolumn (m):");
            int m = int.Parse(Console.ReadLine());

            char[,] tablica = new char[k, m];

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    {
                        tablica[i, j] = '#';
                    }
                    else
                    {
                        tablica[i, j] = ' ';
                    }
                }
            }

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(tablica[i, j]);
                }
                Console.WriteLine();
            }

            //Zadanie 13

            Console.WriteLine("Podaj liczbę a:");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b:");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj iczbę c:");
            double c1 = double.Parse(Console.ReadLine());

            double delta = b1 * b1 - 4 * a1 * c1;

            double[] rozwiazania;
            if (delta < 0)
            {
                rozwiazania = new double[0];
                Console.WriteLine("Brak rozwiązań.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                rozwiazania = new double[] { x };
                Console.WriteLine($"Jedno rozwiązanie: x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                rozwiazania = new double[] { x1, x2 };
                Console.WriteLine($"Dwa rozwiązania: x1 = {x1}, x2 = {x2}");
            }

            if (rozwiazania.Length > 0)
            {
                Console.WriteLine("Rozwiązania równania kwadratowego:");
                foreach (double rozwiazanie in rozwiazania)
                {
                    Console.WriteLine(rozwiazanie);
                }
            }

        }
    }
}
